﻿
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.Models
{
    public class StaticData
    {
        public static ServiceInfoResponse ActiveServiceInfo { get; set; }
        public static TokenResponse ActiveToken { get; set; }
        public static UserV2 ActiveUser { get; set; }
        public static bool IsLoggedIn { get; set; }
        


    }
}