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
public partial class PathCacheConfig 
{
    /// <summary>
    /// Gets or Sets MaxEntries
    /// </summary>
    [JsonPropertyName("max-entries")]
    public int? MaxEntries { get; set; }
    
    /// <summary>
    /// Gets or Sets Lifespan
    /// </summary>
    [JsonPropertyName("lifespan")]
    public long? Lifespan { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class PathCacheConfig {\n");
      sb.Append("  MaxEntries: ").Append(MaxEntries).Append("\n");
      sb.Append("  Lifespan: ").Append(Lifespan).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
