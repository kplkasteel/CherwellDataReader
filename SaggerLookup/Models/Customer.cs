using SQLite;

namespace SaggerLookup.Models
{
    public class Customer
    {
        public string BusObId { get; set; }
        public string BusObPublicId { get; set; }
        public string BusObRecId { get; set; }
        public byte[] AvatarBytes { get; set; }
        [MaxLength(50)] public string FirstName { get; set; }
        [MaxLength(50)] public string LastName { get; set; }
        [MaxLength(150)] public string FullName { get; set; }
        [MaxLength(30)] public string CustomerTypeName { get; set; }
        [MaxLength(200)] public string Email { get; set; }
        [MaxLength(30)] public string Phone { get; set; }
        [MaxLength(100)] public string Department { get; set; }
        [MaxLength(100)] public string Avatar { get; set; }
        [MaxLength(30)] public string LastModDateTime { get; set; }
        [MaxLength(40)] public string Address1 { get; set; }
        [MaxLength(40)] public string Address2 { get; set; }
        [MaxLength(50)] public string City { get; set; }
        [MaxLength(100)] public string Country { get; set; }
        [MaxLength(100)] public string Office { get; set; }
        [MaxLength(15)] public string Building { get; set; }
        [MaxLength(15)] public string Room { get; set; }
        [MaxLength(100)] public string Manager { get; set; }
        [MaxLength(50)] public string SLAName { get; set; }
        [MaxLength(255)] public string ProvinceStateName { get; set; }
        [MaxLength(30)] public string Mobile { get; set; }
    }

} 