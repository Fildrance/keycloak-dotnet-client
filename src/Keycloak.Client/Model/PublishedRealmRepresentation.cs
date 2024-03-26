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
  public class PublishedRealmRepresentation {
    /// <summary>
    /// Gets or Sets Realm
    /// </summary>
    [DataMember(Name="realm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realm")]
    public string Realm { get; set; }

    /// <summary>
    /// Gets or Sets PublicKey
    /// </summary>
    [DataMember(Name="public_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_key")]
    public string PublicKey { get; set; }

    /// <summary>
    /// Gets or Sets TokenService
    /// </summary>
    [DataMember(Name="token-service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token-service")]
    public string TokenService { get; set; }

    /// <summary>
    /// Gets or Sets AccountService
    /// </summary>
    [DataMember(Name="account-service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account-service")]
    public string AccountService { get; set; }

    /// <summary>
    /// Gets or Sets TokensNotBefore
    /// </summary>
    [DataMember(Name="tokens-not-before", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokens-not-before")]
    public int? TokensNotBefore { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PublishedRealmRepresentation {\n");
      sb.Append("  Realm: ").Append(Realm).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  TokenService: ").Append(TokenService).Append("\n");
      sb.Append("  AccountService: ").Append(AccountService).Append("\n");
      sb.Append("  TokensNotBefore: ").Append(TokensNotBefore).Append("\n");
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
