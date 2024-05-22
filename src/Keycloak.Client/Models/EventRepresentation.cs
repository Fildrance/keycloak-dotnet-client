using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace Keycloak.Client.Models;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class EventRepresentation 
{
    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [JsonPropertyName("time")]
    public long? Time { get; set; }
    
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    /// <summary>
    /// Gets or Sets RealmId
    /// </summary>
    [JsonPropertyName("realmId")]
    public string RealmId { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }
    
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }
    
    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }
    
    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }
    
    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public string Error { get; set; }
    
    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    [JsonPropertyName("details")]
    public Dictionary<string, string> Details { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class EventRepresentation {\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  RealmId: ").Append(RealmId).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
