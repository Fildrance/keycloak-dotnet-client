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
public partial class ProtocolMapperRepresentation 
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
    /// Gets or Sets Protocol
    /// </summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
    
    /// <summary>
    /// Gets or Sets ProtocolMapper
    /// </summary>
    [JsonPropertyName("protocolMapper")]
    public string ProtocolMapper { get; set; }
    
    /// <summary>
    /// Gets or Sets ConsentRequired
    /// </summary>
    [JsonPropertyName("consentRequired")]
    public bool? ConsentRequired { get; set; }
    
    /// <summary>
    /// Gets or Sets ConsentText
    /// </summary>
    [JsonPropertyName("consentText")]
    public string ConsentText { get; set; }
    
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
      sb.Append("class ProtocolMapperRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  ProtocolMapper: ").Append(ProtocolMapper).Append("\n");
      sb.Append("  ConsentRequired: ").Append(ConsentRequired).Append("\n");
      sb.Append("  ConsentText: ").Append(ConsentText).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
