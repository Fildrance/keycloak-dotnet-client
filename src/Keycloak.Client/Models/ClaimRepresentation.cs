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
public partial class ClaimRepresentation 
{
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public bool? Name { get; set; }
    
    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [JsonPropertyName("username")]
    public bool? Username { get; set; }
    
    /// <summary>
    /// Gets or Sets Profile
    /// </summary>
    [JsonPropertyName("profile")]
    public bool? Profile { get; set; }
    
    /// <summary>
    /// Gets or Sets Picture
    /// </summary>
    [JsonPropertyName("picture")]
    public bool? Picture { get; set; }
    
    /// <summary>
    /// Gets or Sets Website
    /// </summary>
    [JsonPropertyName("website")]
    public bool? Website { get; set; }
    
    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [JsonPropertyName("email")]
    public bool? Email { get; set; }
    
    /// <summary>
    /// Gets or Sets Gender
    /// </summary>
    [JsonPropertyName("gender")]
    public bool? Gender { get; set; }
    
    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [JsonPropertyName("locale")]
    public bool? Locale { get; set; }
    
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [JsonPropertyName("address")]
    public bool? Address { get; set; }
    
    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [JsonPropertyName("phone")]
    public bool? Phone { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ClaimRepresentation {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      sb.Append("  Picture: ").Append(Picture).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
