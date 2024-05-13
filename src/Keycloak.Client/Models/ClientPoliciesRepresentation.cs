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
public partial class ClientPoliciesRepresentation 
{
    /// <summary>
    /// Gets or Sets Policies
    /// </summary>
    [JsonPropertyName("policies")]
    public List<ClientPolicyRepresentation> Policies { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ClientPoliciesRepresentation {\n");
      sb.Append("  Policies: ").Append(Policies).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
