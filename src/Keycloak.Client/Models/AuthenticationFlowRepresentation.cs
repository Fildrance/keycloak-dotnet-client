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
public partial class AuthenticationFlowRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Alias
    /// </summary>
    [JsonPropertyName("alias")]
    public string Alias { get; set; }
    
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    /// <summary>
    /// Gets or Sets ProviderId
    /// </summary>
    [JsonPropertyName("providerId")]
    public string ProviderId { get; set; }
    
    /// <summary>
    /// Gets or Sets TopLevel
    /// </summary>
    [JsonPropertyName("topLevel")]
    public bool? TopLevel { get; set; }
    
    /// <summary>
    /// Gets or Sets BuiltIn
    /// </summary>
    [JsonPropertyName("builtIn")]
    public bool? BuiltIn { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthenticationExecutions
    /// </summary>
    [JsonPropertyName("authenticationExecutions")]
    public List<AuthenticationExecutionExportRepresentation> AuthenticationExecutions { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationFlowRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  TopLevel: ").Append(TopLevel).Append("\n");
      sb.Append("  BuiltIn: ").Append(BuiltIn).Append("\n");
      sb.Append("  AuthenticationExecutions: ").Append(AuthenticationExecutions).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
