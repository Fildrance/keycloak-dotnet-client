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
public partial class PathSegment 
{
    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
    
    /// <summary>
    /// Gets or Sets MatrixParameters
    /// </summary>
    [JsonPropertyName("matrixParameters")]
    public Dictionary<string, ArrayList> MatrixParameters { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class PathSegment {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  MatrixParameters: ").Append(MatrixParameters).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
