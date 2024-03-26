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
  public class UPGroup {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DisplayHeader
    /// </summary>
    [DataMember(Name="displayHeader", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayHeader")]
    public string DisplayHeader { get; set; }

    /// <summary>
    /// Gets or Sets DisplayDescription
    /// </summary>
    [DataMember(Name="displayDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayDescription")]
    public string DisplayDescription { get; set; }

    /// <summary>
    /// Gets or Sets Annotations
    /// </summary>
    [DataMember(Name="annotations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "annotations")]
    public Dictionary<string, Object> Annotations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UPGroup {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayHeader: ").Append(DisplayHeader).Append("\n");
      sb.Append("  DisplayDescription: ").Append(DisplayDescription).Append("\n");
      sb.Append("  Annotations: ").Append(Annotations).Append("\n");
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
