using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SecurityRight
{
    [DataMember(Name = "add", EmitDefaultValue = false)]
    public bool? Add { get; set; }

    [DataMember(Name = "allow", EmitDefaultValue = false)]
    public bool? Allow { get; set; }

    [DataMember(Name = "categoryDescription", EmitDefaultValue = false)]
    public string CategoryDescription { get; set; }

    [DataMember(Name = "categoryId", EmitDefaultValue = false)]
    public string CategoryId { get; set; }

    [DataMember(Name = "categoryName", EmitDefaultValue = false)]
    public string CategoryName { get; set; }

    [DataMember(Name = "Delete", EmitDefaultValue = false)]
    public bool? Delete { get; set; }

    [DataMember(Name = "edit", EmitDefaultValue = false)]
    public bool? Edit { get; set; }

    [DataMember(Name = "isYesNoRight", EmitDefaultValue = false)]
    public bool? IsYesNoRight { get; set; }

    [DataMember(Name = "nonScopeOwnerAdd", EmitDefaultValue = false)]
    public bool? NonScopeOwnerAdd { get; set; }

    [DataMember(Name = "nonScopeOwnerDelete", EmitDefaultValue = false)]
    public bool? NonScopeOwnerDelete { get; set; }

    [DataMember(Name = "nonScopeOwnerEdit", EmitDefaultValue = false)]
    public bool? NonScopeOwnerEdit { get; set; }

    [DataMember(Name = "nonScopeOwnerView", EmitDefaultValue = false)]
    public bool? NonScopeOwnerView { get; set; }

    [DataMember(Name = "rightId", EmitDefaultValue = false)]
    public string RightId { get; set; }

    [DataMember(Name = "rightName", EmitDefaultValue = false)]
    public string RightName { get; set; }

    [DataMember(Name = "standardRightName", EmitDefaultValue = false)]
    public string StandardRightName { get; set; }

    [DataMember(Name = "viewRunOpen", EmitDefaultValue = false)]
    public bool? ViewRunOpen { get; set; }
}