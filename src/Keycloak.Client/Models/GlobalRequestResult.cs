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
public partial class GlobalRequestResult 
{
    /// <summary>
    /// Gets or Sets SuccessRequests
    /// </summary>
    [JsonPropertyName("successRequests")]
    public List<string> SuccessRequests { get; set; }
    
    /// <summary>
    /// Gets or Sets FailedRequests
    /// </summary>
    [JsonPropertyName("failedRequests")]
    public List<string> FailedRequests { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class GlobalRequestResult {\n");
      sb.Append("  SuccessRequests: ").Append(SuccessRequests).Append("\n");
      sb.Append("  FailedRequests: ").Append(FailedRequests).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
