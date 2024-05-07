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
public partial class ClientProfilesRepresentation 
{
    /// <summary>
    /// Gets or Sets Profiles
    /// </summary>
    [JsonPropertyName("profiles")]
    public List<ClientProfileRepresentation> Profiles { get; set; }
    
    /// <summary>
    /// Gets or Sets GlobalProfiles
    /// </summary>
    [JsonPropertyName("globalProfiles")]
    public List<ClientProfileRepresentation> GlobalProfiles { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ClientProfilesRepresentation {\n");
      sb.Append("  Profiles: ").Append(Profiles).Append("\n");
      sb.Append("  GlobalProfiles: ").Append(GlobalProfiles).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
