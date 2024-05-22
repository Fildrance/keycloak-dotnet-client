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
public partial class CertificateRepresentation 
{
    /// <summary>
    /// Gets or Sets PrivateKey
    /// </summary>
    [JsonPropertyName("privateKey")]
    public string PrivateKey { get; set; }
    
    /// <summary>
    /// Gets or Sets PublicKey
    /// </summary>
    [JsonPropertyName("publicKey")]
    public string PublicKey { get; set; }
    
    /// <summary>
    /// Gets or Sets Certificate
    /// </summary>
    [JsonPropertyName("certificate")]
    public string Certificate { get; set; }
    
    /// <summary>
    /// Gets or Sets Kid
    /// </summary>
    [JsonPropertyName("kid")]
    public string Kid { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class CertificateRepresentation {\n");
      sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  Certificate: ").Append(Certificate).Append("\n");
      sb.Append("  Kid: ").Append(Kid).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
