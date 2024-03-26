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
  public class RolesRepresentation {
    /// <summary>
    /// Gets or Sets Realm
    /// </summary>
    [DataMember(Name="realm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realm")]
    public List<RoleRepresentation> Realm { get; set; }

    /// <summary>
    /// Gets or Sets _Client
    /// </summary>
    [DataMember(Name="client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client")]
    public Dictionary<string, ArrayList> _Client { get; set; }

    /// <summary>
    /// Gets or Sets Application
    /// </summary>
    [DataMember(Name="application", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "application")]
    public Dictionary<string, ArrayList> Application { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RolesRepresentation {\n");
      sb.Append("  Realm: ").Append(Realm).Append("\n");
      sb.Append("  _Client: ").Append(_Client).Append("\n");
      sb.Append("  Application: ").Append(Application).Append("\n");
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
