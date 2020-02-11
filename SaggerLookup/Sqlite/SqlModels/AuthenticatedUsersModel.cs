using Newtonsoft.Json;
using SaggerLookup.Swagger.Model;
using SQLite;

namespace SaggerLookup.Sqlite.SqlModels
{
    public class AuthenticatedUsersModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(42)]
        public string UserRecId { get; set; }
        [MaxLength(255)]
        public string Company { get; set; }
        [MaxLength(255)]
        public string UserName { get; set; }
        [MaxLength(255)]
        public string Password { get; set; }    
        [MaxLength(255)]
        public string DatabaseName { get; set; }
        [MaxLength(255) ]
        public string DbKey { get; set; }
        public bool DatabaseInitialized { get; set; }
        [MaxLength(255)]
        public string ServiceInfoString { get; set; }

        [Ignore]
        public ServiceInfoResponse ServiceInfo
        {
            get => string.IsNullOrEmpty(ServiceInfoString) ? new ServiceInfoResponse() : JsonConvert.DeserializeObject<ServiceInfoResponse>(ServiceInfoString);
            set
            {
                if (value != null) ServiceInfoString = JsonConvert.SerializeObject(value);
            }
        }

    }
}
    