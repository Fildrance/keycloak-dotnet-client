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
public partial class GroupRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
    
    /// <summary>
    /// Gets or Sets ParentId
    /// </summary>
    [JsonPropertyName("parentId")]
    public string ParentId { get; set; }
    
    /// <summary>
    /// Gets or Sets SubGroupCount
    /// </summary>
    [JsonPropertyName("subGroupCount")]
    public long? SubGroupCount { get; set; }
    
    /// <summary>
    /// Gets or Sets SubGroups
    /// </summary>
    [JsonPropertyName("subGroups")]
    public List<GroupRepresentation> SubGroups { get; set; }
    
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public Dictionary<string, ArrayList> Attributes { get; set; }
    
    /// <summary>
    /// Gets or Sets RealmRoles
    /// </summary>
    [JsonPropertyName("realmRoles")]
    public List<string> RealmRoles { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientRoles
    /// </summary>
    [JsonPropertyName("clientRoles")]
    public Dictionary<string, ArrayList> ClientRoles { get; set; }
    
    /// <summary>
    /// Gets or Sets Access
    /// </summary>
    [JsonPropertyName("access")]
    public Dictionary<string, bool?> Access { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class GroupRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  SubGroupCount: ").Append(SubGroupCount).Append("\n");
      sb.Append("  SubGroups: ").Append(SubGroups).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  RealmRoles: ").Append(RealmRoles).Append("\n");
      sb.Append("  ClientRoles: ").Append(ClientRoles).Append("\n");
      sb.Append("  Access: ").Append(Access).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
