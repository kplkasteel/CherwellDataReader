using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class FieldPermission
{
    [DataMember(Name = "departmentMemberEdit", EmitDefaultValue = false)]
    public bool? DepartmentMemberEdit { get; set; }

    [DataMember(Name = "departmentMemberView", EmitDefaultValue = false)]
    public bool? DepartmentMemberView { get; set; }

    [DataMember(Name = "edit", EmitDefaultValue = false)]
    public bool? Edit { get; set; }

    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }

    [DataMember(Name = "fieldName", EmitDefaultValue = false)]
    public string FieldName { get; set; }

    [DataMember(Name = "managerOfOwnerEdit", EmitDefaultValue = false)]
    public bool? ManagerOfOwnerEdit { get; set; }

    [DataMember(Name = "managerOfOwnerView", EmitDefaultValue = false)]
    public bool? ManagerOfOwnerView { get; set; }

    [DataMember(Name = "ownerEdit", EmitDefaultValue = false)]
    public bool? OwnerEdit { get; set; }

    [DataMember(Name = "ownerView", EmitDefaultValue = false)]
    public bool? OwnerView { get; set; }

    [DataMember(Name = "teamEdit", EmitDefaultValue = false)]
    public bool? TeamEdit { get; set; }

    [DataMember(Name = "teamManagerOfOwnerEdit", EmitDefaultValue = false)]
    public bool? TeamManagerOfOwnerEdit { get; set; }

    [DataMember(Name = "teamManagerOfOwnerView", EmitDefaultValue = false)]
    public bool? TeamManagerOfOwnerView { get; set; }

    [DataMember(Name = "teamView", EmitDefaultValue = false)]
    public bool? TeamView { get; set; }

    [DataMember(Name = "view", EmitDefaultValue = false)]
    public bool? View { get; set; }
}