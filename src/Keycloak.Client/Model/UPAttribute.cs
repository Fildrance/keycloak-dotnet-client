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
  public class UPAttribute {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Validations
    /// </summary>
    [DataMember(Name="validations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validations")]
    public Dictionary<string, Dictionary<string, Object>> Validations { get; set; }

    /// <summary>
    /// Gets or Sets Annotations
    /// </summary>
    [DataMember(Name="annotations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "annotations")]
    public Dictionary<string, Object> Annotations { get; set; }

    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public UPAttributeRequired Required { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public UPAttributePermissions Permissions { get; set; }

    /// <summary>
    /// Gets or Sets Selector
    /// </summary>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selector")]
    public UPAttributeSelector Selector { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UPAttribute {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Validations: ").Append(Validations).Append("\n");
      sb.Append("  Annotations: ").Append(Annotations).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
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
