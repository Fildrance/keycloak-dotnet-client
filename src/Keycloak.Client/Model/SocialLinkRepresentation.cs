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
  public class SocialLinkRepresentation {
    /// <summary>
    /// Gets or Sets SocialProvider
    /// </summary>
    [DataMember(Name="socialProvider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socialProvider")]
    public string SocialProvider { get; set; }

    /// <summary>
    /// Gets or Sets SocialUserId
    /// </summary>
    [DataMember(Name="socialUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socialUserId")]
    public string SocialUserId { get; set; }

    /// <summary>
    /// Gets or Sets SocialUsername
    /// </summary>
    [DataMember(Name="socialUsername", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socialUsername")]
    public string SocialUsername { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SocialLinkRepresentation {\n");
      sb.Append("  SocialProvider: ").Append(SocialProvider).Append("\n");
      sb.Append("  SocialUserId: ").Append(SocialUserId).Append("\n");
      sb.Append("  SocialUsername: ").Append(SocialUsername).Append("\n");
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
