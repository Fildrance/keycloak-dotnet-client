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
public partial class ConfigPropertyRepresentation 
{
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    [JsonPropertyName("label")]
    public string Label { get; set; }
    
    /// <summary>
    /// Gets or Sets HelpText
    /// </summary>
    [JsonPropertyName("helpText")]
    public string HelpText { get; set; }
    
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    /// <summary>
    /// Gets or Sets DefaultValue
    /// </summary>
    [JsonPropertyName("defaultValue")]
    public object DefaultValue { get; set; }
    
    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [JsonPropertyName("options")]
    public List<string> Options { get; set; }
    
    /// <summary>
    /// Gets or Sets Secret
    /// </summary>
    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }
    
    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }
    
    /// <summary>
    /// Gets or Sets _ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool? _ReadOnly { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ConfigPropertyRepresentation {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  HelpText: ").Append(HelpText).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
