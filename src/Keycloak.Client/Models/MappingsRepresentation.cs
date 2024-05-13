using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace PetShop.Models;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class MappingsRepresentation 
{
    /// <summary>
    /// Gets or Sets RealmMappings
    /// </summary>
    [JsonPropertyName("realmMappings")]
    public List<RoleRepresentation> RealmMappings { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientMappings
    /// </summary>
    [JsonPropertyName("clientMappings")]
    public Dictionary<string, ClientMappingsRepresentation> ClientMappings { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class MappingsRepresentation {\n");
      sb.Append("  RealmMappings: ").Append(RealmMappings).Append("\n");
      sb.Append("  ClientMappings: ").Append(ClientMappings).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
