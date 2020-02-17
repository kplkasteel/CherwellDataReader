using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FFImageLoading.Svg.Forms;
using Mobile1.Helpers.Sqlite.SqlClasses;
using Mobile1.Helpers.Sqlite.SqlModels.BusinessObjects.Lookup;
using Mobile1.Helpers.Swagger.Model;
using SQLite;
using Xamarin.Forms;

namespace Mobile1.Helpers.Sqlite.SqlModels.BusinessObjects.Major
{
    public class Customer : CherwellBusinessObject
    {
        public Customer()
        {
            SqlDbBase.Instance.Initialize<Customer>();
        }

        public byte[] AvatarBytes { get; set; }

        [Ignore]
        public ImageSource AvatarImage
        {
            get
            {
                if (AvatarBytes != null && AvatarBytes.Length != 0) return ImageSource.FromStream(() => new MemoryStream(AvatarBytes));
                return SvgImageSource.FromResource("Mobile1.Resources.Images.no_profile_picture.svg");
            }
        }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(150)]
        public string FullName { get; set; }
        [MaxLength(30)]
        public string CustomerTypeName { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Department { get; set; }
        [MaxLength(100)]
        public string Avatar { get; set; }
        [MaxLength(30)]
        public string LastModDateTime { get; set; }
        [MaxLength(40)]
        public string Address1 { get; set; }
        [MaxLength(40)]
        public string Address2 { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(100)]
        public string Country { get; set; }
        [MaxLength(100)]
        public string Office { get; set; }
        [MaxLength(15)]
        public string Building { get; set; }
        [MaxLength(15)]
        public string Room { get; set; }
        [MaxLength(100)]    
        public string Manager { get; set; }
        [MaxLength(50)]
        public string SLAName { get; set; }
        [MaxLength(255)]
        public string ProvinceStateName { get; set; }
        [MaxLength(30)]
        public string Mobile { get; set; }

        [Ignore]
        public override string Name => GetType().Name;

        public  CherwellBusinessObject CreateSqlModel(ReadResponse readResponse, byte[] avatarBytes)
        {
            return new Customer()
            {
                BusObId = readResponse.BusObRecId,
                BusObPublicId = readResponse.BusObPublicId,
                BusObRecId = readResponse.BusObRecId,
                AvatarBytes = avatarBytes,
                FirstName = readResponse.ReadFieldInformation(nameof(FirstName)),
                LastName = readResponse.ReadFieldInformation(nameof(LastName)),
                FullName = readResponse.ReadFieldInformation(nameof(FullName)),
                CustomerTypeName = readResponse.ReadFieldInformation(nameof(CustomerTypeName)),
                Email = readResponse.ReadFieldInformation(nameof(Email)),
                Phone = readResponse.ReadFieldInformation(nameof(Phone)),
                Department = readResponse.ReadFieldInformation(nameof(Department)),
                Avatar = readResponse.ReadFieldInformation(nameof(Avatar)),
                LastModDateTime = readResponse.ReadFieldInformation(nameof(LastModDateTime)),
                City = readResponse.ReadFieldInformation(nameof(City)),
                Address1 = readResponse.ReadFieldInformation(nameof(Address1)),
                Address2 = readResponse.ReadFieldInformation(nameof(Address2)),
                Office = readResponse.ReadFieldInformation(nameof(Office)),
                Building = readResponse.ReadFieldInformation(nameof(Building)),
                Room = readResponse.ReadFieldInformation(nameof(Room)),
                Country = readResponse.ReadFieldInformation(nameof(Country)),
                Manager = readResponse.ReadFieldInformation(nameof(Manager)),
                SLAName = readResponse.ReadFieldInformation(nameof(SLAName)),
                ProvinceStateName = readResponse.ReadFieldInformation(nameof(ProvinceStateName)),
                Mobile = readResponse.ReadFieldInformation(nameof(Mobile))
            };
        }


        public List<FilterInfo> CreateFilterInfo(SchemaResponse schemaResponse, List<CustomerStatus> readResponseList, string[] exclusionList, string fieldName)
        {
            var fieldId = schemaResponse.FieldDefinitions.SingleOrDefault(x => x.Name == fieldName)?.FieldId;
            return string.IsNullOrEmpty(fieldId) ? new List<FilterInfo>() : (from item in readResponseList where !exclusionList.Contains(item.Status) select new FilterInfo { FieldId = fieldId, Operator = "eq", Value = item.Status }).ToList();
        }

        public int StoreOrUpdateCherwellBusinessObject(ReadResponse businessObjects, byte[] avatarBytes)
        {
            if (businessObjects == null) return 0;
            try { 
            
                var customer = CreateSqlModel(businessObjects, avatarBytes);
                var result =
                    SqlDbBase.Instance.DatabaseConnection.Update(customer,typeof(Customer));
                if (result == 0)
                {
                    result = SqlDbBase.Instance.DatabaseConnection.Insert(customer, typeof(Customer));
                }
                return result;
            }
            catch (SQLiteException sqLiteException)
            {
                Display.DisplayMessage($"SQL Error ({Name})", sqLiteException.Message, "OK");
                return 0;
            }
        }

        public Customer GetCustomerByBusObRecId(string busObRecId)
        {
            try
            {
                return SqlDbBase.Instance.DatabaseConnection.Table<Customer>()
                    .SingleOrDefault(x => x.BusObRecId == busObRecId);
            }
            catch (SQLiteException sqLiteException)
            {
                Display.DisplayMessage($"SQL Error ({Name})", sqLiteException.Message, "OK");
                return null;
            }

        }
        public int DeleteUserInfoByObject(Customer customer)
        {
            try
            {
                return SqlDbBase.Instance.DatabaseConnection.Delete<Customer>(customer.BusObRecId);
            }
            catch (SQLiteException sqLiteException)
            {
                Display.DisplayMessage($"SQL Error ({Name})", sqLiteException.Message, "OK");
                return 0;
            }
        }

        public override List<string> GetFields(Summary summary)
        {
            var properties = GetType().GetProperties();
            var fieldList = properties.Select(item => item.Name);
            var schema = new SqlSchemaResponse().GetSchemaResponseByBusObId(summary.BusObId);
            var fieldIds = fieldList
                .Select(field => schema.FieldDefinitions.SingleOrDefault(x => x.Name == field)?.FieldId)
                .Where(item => !string.IsNullOrEmpty(item)).ToList();
            return fieldIds;
        }
    }
} 