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
  public class PolicyEnforcerConfig {
    /// <summary>
    /// Gets or Sets EnforcementMode
    /// </summary>
    [DataMember(Name="enforcement-mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enforcement-mode")]
    public EnforcementMode EnforcementMode { get; set; }

    /// <summary>
    /// Gets or Sets Paths
    /// </summary>
    [DataMember(Name="paths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paths")]
    public List<PathConfig> Paths { get; set; }

    /// <summary>
    /// Gets or Sets PathCache
    /// </summary>
    [DataMember(Name="path-cache", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path-cache")]
    public PathCacheConfig PathCache { get; set; }

    /// <summary>
    /// Gets or Sets LazyLoadPaths
    /// </summary>
    [DataMember(Name="lazy-load-paths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lazy-load-paths")]
    public bool? LazyLoadPaths { get; set; }

    /// <summary>
    /// Gets or Sets OnDenyRedirectTo
    /// </summary>
    [DataMember(Name="on-deny-redirect-to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on-deny-redirect-to")]
    public string OnDenyRedirectTo { get; set; }

    /// <summary>
    /// Gets or Sets UserManagedAccess
    /// </summary>
    [DataMember(Name="user-managed-access", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user-managed-access")]
    public Object UserManagedAccess { get; set; }

    /// <summary>
    /// Gets or Sets ClaimInformationPoint
    /// </summary>
    [DataMember(Name="claim-information-point", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claim-information-point")]
    public Dictionary<string, Dictionary<string, Object>> ClaimInformationPoint { get; set; }

    /// <summary>
    /// Gets or Sets HttpMethodAsScope
    /// </summary>
    [DataMember(Name="http-method-as-scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "http-method-as-scope")]
    public bool? HttpMethodAsScope { get; set; }

    /// <summary>
    /// Gets or Sets Realm
    /// </summary>
    [DataMember(Name="realm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realm")]
    public string Realm { get; set; }

    /// <summary>
    /// Gets or Sets AuthServerUrl
    /// </summary>
    [DataMember(Name="auth-server-url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auth-server-url")]
    public string AuthServerUrl { get; set; }

    /// <summary>
    /// Gets or Sets Credentials
    /// </summary>
    [DataMember(Name="credentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credentials")]
    public Dictionary<string, Object> Credentials { get; set; }

    /// <summary>
    /// Gets or Sets Resource
    /// </summary>
    [DataMember(Name="resource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resource")]
    public string Resource { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyEnforcerConfig {\n");
      sb.Append("  EnforcementMode: ").Append(EnforcementMode).Append("\n");
      sb.Append("  Paths: ").Append(Paths).Append("\n");
      sb.Append("  PathCache: ").Append(PathCache).Append("\n");
      sb.Append("  LazyLoadPaths: ").Append(LazyLoadPaths).Append("\n");
      sb.Append("  OnDenyRedirectTo: ").Append(OnDenyRedirectTo).Append("\n");
      sb.Append("  UserManagedAccess: ").Append(UserManagedAccess).Append("\n");
      sb.Append("  ClaimInformationPoint: ").Append(ClaimInformationPoint).Append("\n");
      sb.Append("  HttpMethodAsScope: ").Append(HttpMethodAsScope).Append("\n");
      sb.Append("  Realm: ").Append(Realm).Append("\n");
      sb.Append("  AuthServerUrl: ").Append(AuthServerUrl).Append("\n");
      sb.Append("  Credentials: ").Append(Credentials).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
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
