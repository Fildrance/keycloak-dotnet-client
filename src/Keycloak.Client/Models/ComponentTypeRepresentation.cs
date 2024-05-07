using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Swagger.Model;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class ComponentTypeRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets HelpText
    /// </summary>
    [JsonPropertyName("helpText")]
    public string HelpText { get; set; }
    
    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [JsonPropertyName("properties")]
    public List<ConfigPropertyRepresentation> Properties { get; set; }
    
    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, Object> Metadata { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ComponentTypeRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  HelpText: ").Append(HelpText).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
