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
  public class PathConfig {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets Methods
    /// </summary>
    [DataMember(Name="methods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "methods")]
    public List<MethodConfig> Methods { get; set; }

    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [DataMember(Name="scopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopes")]
    public List<string> Scopes { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets EnforcementMode
    /// </summary>
    [DataMember(Name="enforcement-mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enforcement-mode")]
    public EnforcementMode EnforcementMode { get; set; }

    /// <summary>
    /// Gets or Sets ClaimInformationPoint
    /// </summary>
    [DataMember(Name="claim-information-point", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claim-information-point")]
    public Dictionary<string, Dictionary<string, Object>> ClaimInformationPoint { get; set; }

    /// <summary>
    /// Gets or Sets Invalidated
    /// </summary>
    [DataMember(Name="invalidated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invalidated")]
    public bool? Invalidated { get; set; }

    /// <summary>
    /// Gets or Sets StaticPath
    /// </summary>
    [DataMember(Name="staticPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staticPath")]
    public bool? StaticPath { get; set; }

    /// <summary>
    /// Gets or Sets _Static
    /// </summary>
    [DataMember(Name="static", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "static")]
    public bool? _Static { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PathConfig {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Methods: ").Append(Methods).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  EnforcementMode: ").Append(EnforcementMode).Append("\n");
      sb.Append("  ClaimInformationPoint: ").Append(ClaimInformationPoint).Append("\n");
      sb.Append("  Invalidated: ").Append(Invalidated).Append("\n");
      sb.Append("  StaticPath: ").Append(StaticPath).Append("\n");
      sb.Append("  _Static: ").Append(_Static).Append("\n");
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
