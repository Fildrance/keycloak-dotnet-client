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
public partial class ProtocolMapperEvaluationRepresentation 
{
    /// <summary>
    /// Gets or Sets MapperId
    /// </summary>
    [JsonPropertyName("mapperId")]
    public string MapperId { get; set; }
    
    /// <summary>
    /// Gets or Sets MapperName
    /// </summary>
    [JsonPropertyName("mapperName")]
    public string MapperName { get; set; }
    
    /// <summary>
    /// Gets or Sets ContainerId
    /// </summary>
    [JsonPropertyName("containerId")]
    public string ContainerId { get; set; }
    
    /// <summary>
    /// Gets or Sets ContainerName
    /// </summary>
    [JsonPropertyName("containerName")]
    public string ContainerName { get; set; }
    
    /// <summary>
    /// Gets or Sets ContainerType
    /// </summary>
    [JsonPropertyName("containerType")]
    public string ContainerType { get; set; }
    
    /// <summary>
    /// Gets or Sets ProtocolMapper
    /// </summary>
    [JsonPropertyName("protocolMapper")]
    public string ProtocolMapper { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ProtocolMapperEvaluationRepresentation {\n");
      sb.Append("  MapperId: ").Append(MapperId).Append("\n");
      sb.Append("  MapperName: ").Append(MapperName).Append("\n");
      sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
      sb.Append("  ContainerName: ").Append(ContainerName).Append("\n");
      sb.Append("  ContainerType: ").Append(ContainerType).Append("\n");
      sb.Append("  ProtocolMapper: ").Append(ProtocolMapper).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
