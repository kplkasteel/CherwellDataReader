using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    
    public class SearchResultsRequest
    {

        [DataMember(Name="association", EmitDefaultValue=false)]
        public string Association { get; set; }

        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        [DataMember(Name="customGridDefId", EmitDefaultValue=false)]
        public string CustomGridDefId { get; set; }

        [DataMember(Name="dateTimeFormatting", EmitDefaultValue=false)]
        public string DateTimeFormatting { get; set; }

        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }

        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FilterInfo> Filters { get; set; }

        [DataMember(Name="includeAllFields", EmitDefaultValue=false)]
        public bool? IncludeAllFields { get; set; }

        [DataMember(Name="includeSchema", EmitDefaultValue=false)]
        public bool? IncludeSchema { get; set; }

        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }

        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }

        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public string SearchId { get; set; }

        [DataMember(Name="searchName", EmitDefaultValue=false)]
        public string SearchName { get; set; }

        [DataMember(Name="searchText", EmitDefaultValue=false)]
        public string SearchText { get; set; }

        [DataMember(Name="sorting", EmitDefaultValue=false)]
        public List<SortInfo> Sorting { get; set; }

        [DataMember(Name="promptValues", EmitDefaultValue=false)]
        public List<PromptValue> PromptValues { get; set; }

       
    }

}
