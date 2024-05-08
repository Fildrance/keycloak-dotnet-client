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
public partial class MethodConfig 
{
    /// <summary>
    /// Gets or Sets Method
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; set; }
    
    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [JsonPropertyName("scopes")]
    public List<string> Scopes { get; set; }
    
    /// <summary>
    /// Gets or Sets ScopesEnforcementMode
    /// </summary>
    [JsonPropertyName("scopes-enforcement-mode")]
    public ScopeEnforcementMode ScopesEnforcementMode { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class MethodConfig {\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("  ScopesEnforcementMode: ").Append(ScopesEnforcementMode).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
