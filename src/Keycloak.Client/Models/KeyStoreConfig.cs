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
public partial class KeyStoreConfig 
{
    /// <summary>
    /// Gets or Sets RealmCertificate
    /// </summary>
    [JsonPropertyName("realmCertificate")]
    public bool? RealmCertificate { get; set; }
    
    /// <summary>
    /// Gets or Sets StorePassword
    /// </summary>
    [JsonPropertyName("storePassword")]
    public string StorePassword { get; set; }
    
    /// <summary>
    /// Gets or Sets KeyPassword
    /// </summary>
    [JsonPropertyName("keyPassword")]
    public string KeyPassword { get; set; }
    
    /// <summary>
    /// Gets or Sets KeyAlias
    /// </summary>
    [JsonPropertyName("keyAlias")]
    public string KeyAlias { get; set; }
    
    /// <summary>
    /// Gets or Sets RealmAlias
    /// </summary>
    [JsonPropertyName("realmAlias")]
    public string RealmAlias { get; set; }
    
    /// <summary>
    /// Gets or Sets Format
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class KeyStoreConfig {\n");
      sb.Append("  RealmCertificate: ").Append(RealmCertificate).Append("\n");
      sb.Append("  StorePassword: ").Append(StorePassword).Append("\n");
      sb.Append("  KeyPassword: ").Append(KeyPassword).Append("\n");
      sb.Append("  KeyAlias: ").Append(KeyAlias).Append("\n");
      sb.Append("  RealmAlias: ").Append(RealmAlias).Append("\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
