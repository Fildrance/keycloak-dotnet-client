using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Swagger.Model;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class PolicyEnforcerConfig 
{
    /// <summary>
    /// Gets or Sets EnforcementMode
    /// </summary>
    [JsonPropertyName("enforcement-mode")]
    public EnforcementMode EnforcementMode { get; set; }
    
    /// <summary>
    /// Gets or Sets Paths
    /// </summary>
    [JsonPropertyName("paths")]
    public List<PathConfig> Paths { get; set; }
    
    /// <summary>
    /// Gets or Sets PathCache
    /// </summary>
    [JsonPropertyName("path-cache")]
    public PathCacheConfig PathCache { get; set; }
    
    /// <summary>
    /// Gets or Sets LazyLoadPaths
    /// </summary>
    [JsonPropertyName("lazy-load-paths")]
    public bool? LazyLoadPaths { get; set; }
    
    /// <summary>
    /// Gets or Sets OnDenyRedirectTo
    /// </summary>
    [JsonPropertyName("on-deny-redirect-to")]
    public string OnDenyRedirectTo { get; set; }
    
    /// <summary>
    /// Gets or Sets UserManagedAccess
    /// </summary>
    [JsonPropertyName("user-managed-access")]
    public Object UserManagedAccess { get; set; }
    
    /// <summary>
    /// Gets or Sets ClaimInformationPoint
    /// </summary>
    [JsonPropertyName("claim-information-point")]
    public Dictionary<string, Dictionary<string, Object>> ClaimInformationPoint { get; set; }
    
    /// <summary>
    /// Gets or Sets HttpMethodAsScope
    /// </summary>
    [JsonPropertyName("http-method-as-scope")]
    public bool? HttpMethodAsScope { get; set; }
    
    /// <summary>
    /// Gets or Sets Realm
    /// </summary>
    [JsonPropertyName("realm")]
    public string Realm { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthServerUrl
    /// </summary>
    [JsonPropertyName("auth-server-url")]
    public string AuthServerUrl { get; set; }
    
    /// <summary>
    /// Gets or Sets Credentials
    /// </summary>
    [JsonPropertyName("credentials")]
    public Dictionary<string, Object> Credentials { get; set; }
    
    /// <summary>
    /// Gets or Sets Resource
    /// </summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
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
    
}
