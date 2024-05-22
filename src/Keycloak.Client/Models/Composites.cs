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
public partial class Composites 
{
    /// <summary>
    /// Gets or Sets Realm
    /// </summary>
    [JsonPropertyName("realm")]
    public List<string> Realm { get; set; }
    
    /// <summary>
    /// Gets or Sets _Client
    /// </summary>
    [JsonPropertyName("client")]
    public Dictionary<string, ArrayList> _Client { get; set; }
    
    /// <summary>
    /// Gets or Sets Application
    /// </summary>
    [JsonPropertyName("application")]
    public Dictionary<string, ArrayList> Application { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class Composites {\n");
      sb.Append("  Realm: ").Append(Realm).Append("\n");
      sb.Append("  _Client: ").Append(_Client).Append("\n");
      sb.Append("  Application: ").Append(Application).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
