using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class StoredSearchResults
{
    [DataMember(Name = "columns", EmitDefaultValue = false)]
    public List<SearchesColumnSchema> Columns { get; set; }

    [DataMember(Name = "rows", EmitDefaultValue = false)]
    public List<List<object>> Rows { get; private set; }
}