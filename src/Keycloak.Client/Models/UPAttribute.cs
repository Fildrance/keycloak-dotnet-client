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
public partial class UPAttribute 
{
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }
    
    /// <summary>
    /// Gets or Sets Validations
    /// </summary>
    [JsonPropertyName("validations")]
    public Dictionary<string, Dictionary<string, Object>> Validations { get; set; }
    
    /// <summary>
    /// Gets or Sets Annotations
    /// </summary>
    [JsonPropertyName("annotations")]
    public Dictionary<string, Object> Annotations { get; set; }
    
    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    [JsonPropertyName("required")]
    public UPAttributeRequired Required { get; set; }
    
    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [JsonPropertyName("permissions")]
    public UPAttributePermissions Permissions { get; set; }
    
    /// <summary>
    /// Gets or Sets Selector
    /// </summary>
    [JsonPropertyName("selector")]
    public UPAttributeSelector Selector { get; set; }
    
    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class UPAttribute {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Validations: ").Append(Validations).Append("\n");
      sb.Append("  Annotations: ").Append(Annotations).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
