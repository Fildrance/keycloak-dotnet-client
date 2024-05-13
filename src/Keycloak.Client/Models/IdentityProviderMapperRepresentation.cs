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
public partial class IdentityProviderMapperRepresentation 
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
    /// Gets or Sets IdentityProviderAlias
    /// </summary>
    [JsonPropertyName("identityProviderAlias")]
    public string IdentityProviderAlias { get; set; }
    
    /// <summary>
    /// Gets or Sets IdentityProviderMapper
    /// </summary>
    [JsonPropertyName("identityProviderMapper")]
    public string IdentityProviderMapper { get; set; }
    
    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [JsonPropertyName("config")]
    public Dictionary<string, string> Config { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderMapperRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  IdentityProviderAlias: ").Append(IdentityProviderAlias).Append("\n");
      sb.Append("  IdentityProviderMapper: ").Append(IdentityProviderMapper).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
