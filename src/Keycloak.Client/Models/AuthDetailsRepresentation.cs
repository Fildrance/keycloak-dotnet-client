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
public partial class AuthDetailsRepresentation 
{
    /// <summary>
    /// Gets or Sets RealmId
    /// </summary>
    [JsonPropertyName("realmId")]
    public string RealmId { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }
    
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }
    
    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class AuthDetailsRepresentation {\n");
      sb.Append("  RealmId: ").Append(RealmId).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
