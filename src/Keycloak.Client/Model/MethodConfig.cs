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
  public class MethodConfig {
    /// <summary>
    /// Gets or Sets Method
    /// </summary>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [DataMember(Name="scopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopes")]
    public List<string> Scopes { get; set; }

    /// <summary>
    /// Gets or Sets ScopesEnforcementMode
    /// </summary>
    [DataMember(Name="scopes-enforcement-mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopes-enforcement-mode")]
    public ScopeEnforcementMode ScopesEnforcementMode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MethodConfig {\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("  ScopesEnforcementMode: ").Append(ScopesEnforcementMode).Append("\n");
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
