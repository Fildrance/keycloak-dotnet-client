using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UPAttributePermissions {
    /// <summary>
    /// Gets or Sets View
    /// </summary>
    [DataMember(Name="view", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "view")]
    public List<string> View { get; set; }

    /// <summary>
    /// Gets or Sets Edit
    /// </summary>
    [DataMember(Name="edit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "edit")]
    public List<string> Edit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UPAttributePermissions {\n");
      sb.Append("  View: ").Append(View).Append("\n");
      sb.Append("  Edit: ").Append(Edit).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
