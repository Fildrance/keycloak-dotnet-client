using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ClientTemplateRepresentation {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public string Protocol { get; set; }

    /// <summary>
    /// Gets or Sets FullScopeAllowed
    /// </summary>
    [DataMember(Name="fullScopeAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullScopeAllowed")]
    public bool? FullScopeAllowed { get; set; }

    /// <summary>
    /// Gets or Sets BearerOnly
    /// </summary>
    [DataMember(Name="bearerOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bearerOnly")]
    public bool? BearerOnly { get; set; }

    /// <summary>
    /// Gets or Sets ConsentRequired
    /// </summary>
    [DataMember(Name="consentRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consentRequired")]
    public bool? ConsentRequired { get; set; }

    /// <summary>
    /// Gets or Sets StandardFlowEnabled
    /// </summary>
    [DataMember(Name="standardFlowEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standardFlowEnabled")]
    public bool? StandardFlowEnabled { get; set; }

    /// <summary>
    /// Gets or Sets ImplicitFlowEnabled
    /// </summary>
    [DataMember(Name="implicitFlowEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "implicitFlowEnabled")]
    public bool? ImplicitFlowEnabled { get; set; }

    /// <summary>
    /// Gets or Sets DirectAccessGrantsEnabled
    /// </summary>
    [DataMember(Name="directAccessGrantsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directAccessGrantsEnabled")]
    public bool? DirectAccessGrantsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets ServiceAccountsEnabled
    /// </summary>
    [DataMember(Name="serviceAccountsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceAccountsEnabled")]
    public bool? ServiceAccountsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets PublicClient
    /// </summary>
    [DataMember(Name="publicClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicClient")]
    public bool? PublicClient { get; set; }

    /// <summary>
    /// Gets or Sets FrontchannelLogout
    /// </summary>
    [DataMember(Name="frontchannelLogout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frontchannelLogout")]
    public bool? FrontchannelLogout { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public Dictionary<string, string> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets ProtocolMappers
    /// </summary>
    [DataMember(Name="protocolMappers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocolMappers")]
    public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientTemplateRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  FullScopeAllowed: ").Append(FullScopeAllowed).Append("\n");
      sb.Append("  BearerOnly: ").Append(BearerOnly).Append("\n");
      sb.Append("  ConsentRequired: ").Append(ConsentRequired).Append("\n");
      sb.Append("  StandardFlowEnabled: ").Append(StandardFlowEnabled).Append("\n");
      sb.Append("  ImplicitFlowEnabled: ").Append(ImplicitFlowEnabled).Append("\n");
      sb.Append("  DirectAccessGrantsEnabled: ").Append(DirectAccessGrantsEnabled).Append("\n");
      sb.Append("  ServiceAccountsEnabled: ").Append(ServiceAccountsEnabled).Append("\n");
      sb.Append("  PublicClient: ").Append(PublicClient).Append("\n");
      sb.Append("  FrontchannelLogout: ").Append(FrontchannelLogout).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  ProtocolMappers: ").Append(ProtocolMappers).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
