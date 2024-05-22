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
public partial class CredentialRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    /// <summary>
    /// Gets or Sets UserLabel
    /// </summary>
    [JsonPropertyName("userLabel")]
    public string UserLabel { get; set; }
    
    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [JsonPropertyName("createdDate")]
    public long? CreatedDate { get; set; }
    
    /// <summary>
    /// Gets or Sets SecretData
    /// </summary>
    [JsonPropertyName("secretData")]
    public string SecretData { get; set; }
    
    /// <summary>
    /// Gets or Sets CredentialData
    /// </summary>
    [JsonPropertyName("credentialData")]
    public string CredentialData { get; set; }
    
    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }
    
    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
    
    /// <summary>
    /// Gets or Sets Temporary
    /// </summary>
    [JsonPropertyName("temporary")]
    public bool? Temporary { get; set; }
    
    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    [JsonPropertyName("device")]
    public string Device { get; set; }
    
    /// <summary>
    /// Gets or Sets HashedSaltedValue
    /// </summary>
    [JsonPropertyName("hashedSaltedValue")]
    public string HashedSaltedValue { get; set; }
    
    /// <summary>
    /// Gets or Sets Salt
    /// </summary>
    [JsonPropertyName("salt")]
    public string Salt { get; set; }
    
    /// <summary>
    /// Gets or Sets HashIterations
    /// </summary>
    [JsonPropertyName("hashIterations")]
    public int? HashIterations { get; set; }
    
    /// <summary>
    /// Gets or Sets Counter
    /// </summary>
    [JsonPropertyName("counter")]
    public int? Counter { get; set; }
    
    /// <summary>
    /// Gets or Sets Algorithm
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string Algorithm { get; set; }
    
    /// <summary>
    /// Gets or Sets Digits
    /// </summary>
    [JsonPropertyName("digits")]
    public int? Digits { get; set; }
    
    /// <summary>
    /// Gets or Sets Period
    /// </summary>
    [JsonPropertyName("period")]
    public int? Period { get; set; }
    
    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [JsonPropertyName("config")]
    public Dictionary<string, Object> Config { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class CredentialRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UserLabel: ").Append(UserLabel).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  SecretData: ").Append(SecretData).Append("\n");
      sb.Append("  CredentialData: ").Append(CredentialData).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Temporary: ").Append(Temporary).Append("\n");
      sb.Append("  Device: ").Append(Device).Append("\n");
      sb.Append("  HashedSaltedValue: ").Append(HashedSaltedValue).Append("\n");
      sb.Append("  Salt: ").Append(Salt).Append("\n");
      sb.Append("  HashIterations: ").Append(HashIterations).Append("\n");
      sb.Append("  Counter: ").Append(Counter).Append("\n");
      sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
      sb.Append("  Digits: ").Append(Digits).Append("\n");
      sb.Append("  Period: ").Append(Period).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
