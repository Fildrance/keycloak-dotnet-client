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
  public class InstallationAdapterConfig {
    /// <summary>
    /// Gets or Sets Realm
    /// </summary>
    [DataMember(Name="realm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realm")]
    public string Realm { get; set; }

    /// <summary>
    /// Gets or Sets RealmPublicKey
    /// </summary>
    [DataMember(Name="realm-public-key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realm-public-key")]
    public string RealmPublicKey { get; set; }

    /// <summary>
    /// Gets or Sets AuthServerUrl
    /// </summary>
    [DataMember(Name="auth-server-url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auth-server-url")]
    public string AuthServerUrl { get; set; }

    /// <summary>
    /// Gets or Sets SslRequired
    /// </summary>
    [DataMember(Name="ssl-required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssl-required")]
    public string SslRequired { get; set; }

    /// <summary>
    /// Gets or Sets BearerOnly
    /// </summary>
    [DataMember(Name="bearer-only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bearer-only")]
    public bool? BearerOnly { get; set; }

    /// <summary>
    /// Gets or Sets Resource
    /// </summary>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }

    /// <summary>
    /// Gets or Sets PublicClient
    /// </summary>
    [DataMember(Name="public-client", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public-client")]
    public bool? PublicClient { get; set; }

    /// <summary>
    /// Gets or Sets VerifyTokenAudience
    /// </summary>
    [DataMember(Name="verify-token-audience", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verify-token-audience")]
    public bool? VerifyTokenAudience { get; set; }

    /// <summary>
    /// Gets or Sets Credentials
    /// </summary>
    [DataMember(Name="credentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credentials")]
    public Dictionary<string, Object> Credentials { get; set; }

    /// <summary>
    /// Gets or Sets UseResourceRoleMappings
    /// </summary>
    [DataMember(Name="use-resource-role-mappings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "use-resource-role-mappings")]
    public bool? UseResourceRoleMappings { get; set; }

    /// <summary>
    /// Gets or Sets ConfidentialPort
    /// </summary>
    [DataMember(Name="confidential-port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confidential-port")]
    public int? ConfidentialPort { get; set; }

    /// <summary>
    /// Gets or Sets PolicyEnforcer
    /// </summary>
    [DataMember(Name="policy-enforcer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policy-enforcer")]
    public PolicyEnforcerConfig PolicyEnforcer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InstallationAdapterConfig {\n");
      sb.Append("  Realm: ").Append(Realm).Append("\n");
      sb.Append("  RealmPublicKey: ").Append(RealmPublicKey).Append("\n");
      sb.Append("  AuthServerUrl: ").Append(AuthServerUrl).Append("\n");
      sb.Append("  SslRequired: ").Append(SslRequired).Append("\n");
      sb.Append("  BearerOnly: ").Append(BearerOnly).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
      sb.Append("  PublicClient: ").Append(PublicClient).Append("\n");
      sb.Append("  VerifyTokenAudience: ").Append(VerifyTokenAudience).Append("\n");
      sb.Append("  Credentials: ").Append(Credentials).Append("\n");
      sb.Append("  UseResourceRoleMappings: ").Append(UseResourceRoleMappings).Append("\n");
      sb.Append("  ConfidentialPort: ").Append(ConfidentialPort).Append("\n");
      sb.Append("  PolicyEnforcer: ").Append(PolicyEnforcer).Append("\n");
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
