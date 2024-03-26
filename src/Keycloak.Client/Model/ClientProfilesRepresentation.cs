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
  public class ClientProfilesRepresentation {
    /// <summary>
    /// Gets or Sets Profiles
    /// </summary>
    [DataMember(Name="profiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profiles")]
    public List<ClientProfileRepresentation> Profiles { get; set; }

    /// <summary>
    /// Gets or Sets GlobalProfiles
    /// </summary>
    [DataMember(Name="globalProfiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "globalProfiles")]
    public List<ClientProfileRepresentation> GlobalProfiles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientProfilesRepresentation {\n");
      sb.Append("  Profiles: ").Append(Profiles).Append("\n");
      sb.Append("  GlobalProfiles: ").Append(GlobalProfiles).Append("\n");
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
