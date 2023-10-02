using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SecurityRole
{
    [DataMember(Name = "browserClientCustomViewId", EmitDefaultValue = false)]
    public string BrowserClientCustomViewId { get; set; }

    [DataMember(Name = "businessObjectExcludeList", EmitDefaultValue = false)]
    public List<string> BusinessObjectExcludeList { get; set; }

    [DataMember(Name = "culture", EmitDefaultValue = false)]
    public string Culture { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "mobileClientCustomViewId", EmitDefaultValue = false)]
    public string MobileClientCustomViewId { get; set; }

    [DataMember(Name = "primaryBusObId", EmitDefaultValue = false)]
    public string PrimaryBusObId { get; set; }

    [DataMember(Name = "roleId", EmitDefaultValue = false)]
    public string RoleId { get; set; }

    [DataMember(Name = "roleName", EmitDefaultValue = false)]
    public string RoleName { get; set; }

    [DataMember(Name = "smartClientCustomViewId", EmitDefaultValue = false)]
    public string SmartClientCustomViewId { get; set; }
}