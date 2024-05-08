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
public partial class ClientPolicyConditionRepresentation 
{
    /// <summary>
    /// Gets or Sets Condition
    /// </summary>
    [JsonPropertyName("condition")]
    public string Condition { get; set; }
    
    /// <summary>
    /// Gets or Sets Configuration
    /// </summary>
    [JsonPropertyName("configuration")]
    public List<Object> Configuration { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ClientPolicyConditionRepresentation {\n");
      sb.Append("  Condition: ").Append(Condition).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
