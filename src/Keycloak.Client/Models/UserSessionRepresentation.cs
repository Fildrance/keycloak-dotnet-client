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
public partial class UserSessionRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
    
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }
    
    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }
    
    /// <summary>
    /// Gets or Sets Start
    /// </summary>
    [JsonPropertyName("start")]
    public long? Start { get; set; }
    
    /// <summary>
    /// Gets or Sets LastAccess
    /// </summary>
    [JsonPropertyName("lastAccess")]
    public long? LastAccess { get; set; }
    
    /// <summary>
    /// Gets or Sets RememberMe
    /// </summary>
    [JsonPropertyName("rememberMe")]
    public bool? RememberMe { get; set; }
    
    /// <summary>
    /// Gets or Sets Clients
    /// </summary>
    [JsonPropertyName("clients")]
    public Dictionary<string, string> Clients { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class UserSessionRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  Start: ").Append(Start).Append("\n");
      sb.Append("  LastAccess: ").Append(LastAccess).Append("\n");
      sb.Append("  RememberMe: ").Append(RememberMe).Append("\n");
      sb.Append("  Clients: ").Append(Clients).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
