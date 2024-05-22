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
public partial class ClientScopeRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
    
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }
    
    /// <summary>
    /// Gets or Sets ProtocolMappers
    /// </summary>
    [JsonPropertyName("protocolMappers")]
    public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ClientScopeRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  ProtocolMappers: ").Append(ProtocolMappers).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
