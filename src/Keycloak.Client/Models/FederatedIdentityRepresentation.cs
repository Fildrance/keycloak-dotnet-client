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
public partial class FederatedIdentityRepresentation 
{
    /// <summary>
    /// Gets or Sets IdentityProvider
    /// </summary>
    [JsonPropertyName("identityProvider")]
    public string IdentityProvider { get; set; }
    
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }
    
    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [JsonPropertyName("userName")]
    public string UserName { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class FederatedIdentityRepresentation {\n");
      sb.Append("  IdentityProvider: ").Append(IdentityProvider).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
