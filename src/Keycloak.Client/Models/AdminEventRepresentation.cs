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
public partial class AdminEventRepresentation 
{
    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [JsonPropertyName("time")]
    public long? Time { get; set; }
    
    /// <summary>
    /// Gets or Sets RealmId
    /// </summary>
    [JsonPropertyName("realmId")]
    public string RealmId { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthDetails
    /// </summary>
    [JsonPropertyName("authDetails")]
    public AuthDetailsRepresentation AuthDetails { get; set; }
    
    /// <summary>
    /// Gets or Sets OperationType
    /// </summary>
    [JsonPropertyName("operationType")]
    public string OperationType { get; set; }
    
    /// <summary>
    /// Gets or Sets ResourceType
    /// </summary>
    [JsonPropertyName("resourceType")]
    public string ResourceType { get; set; }
    
    /// <summary>
    /// Gets or Sets ResourcePath
    /// </summary>
    [JsonPropertyName("resourcePath")]
    public string ResourcePath { get; set; }
    
    /// <summary>
    /// Gets or Sets Representation
    /// </summary>
    [JsonPropertyName("representation")]
    public string Representation { get; set; }
    
    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public string Error { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class AdminEventRepresentation {\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  RealmId: ").Append(RealmId).Append("\n");
      sb.Append("  AuthDetails: ").Append(AuthDetails).Append("\n");
      sb.Append("  OperationType: ").Append(OperationType).Append("\n");
      sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
      sb.Append("  ResourcePath: ").Append(ResourcePath).Append("\n");
      sb.Append("  Representation: ").Append(Representation).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
