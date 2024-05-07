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
public partial class OAuthClientRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }
    
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    /// <summary>
    /// Gets or Sets RootUrl
    /// </summary>
    [JsonPropertyName("rootUrl")]
    public string RootUrl { get; set; }
    
    /// <summary>
    /// Gets or Sets AdminUrl
    /// </summary>
    [JsonPropertyName("adminUrl")]
    public string AdminUrl { get; set; }
    
    /// <summary>
    /// Gets or Sets BaseUrl
    /// </summary>
    [JsonPropertyName("baseUrl")]
    public string BaseUrl { get; set; }
    
    /// <summary>
    /// Gets or Sets SurrogateAuthRequired
    /// </summary>
    [JsonPropertyName("surrogateAuthRequired")]
    public bool? SurrogateAuthRequired { get; set; }
    
    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
    
    /// <summary>
    /// Gets or Sets AlwaysDisplayInConsole
    /// </summary>
    [JsonPropertyName("alwaysDisplayInConsole")]
    public bool? AlwaysDisplayInConsole { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientAuthenticatorType
    /// </summary>
    [JsonPropertyName("clientAuthenticatorType")]
    public string ClientAuthenticatorType { get; set; }
    
    /// <summary>
    /// Gets or Sets Secret
    /// </summary>
    [JsonPropertyName("secret")]
    public string Secret { get; set; }
    
    /// <summary>
    /// Gets or Sets RegistrationAccessToken
    /// </summary>
    [JsonPropertyName("registrationAccessToken")]
    public string RegistrationAccessToken { get; set; }
    
    /// <summary>
    /// Gets or Sets DefaultRoles
    /// </summary>
    [JsonPropertyName("defaultRoles")]
    public List<string> DefaultRoles { get; set; }
    
    /// <summary>
    /// Gets or Sets RedirectUris
    /// </summary>
    [JsonPropertyName("redirectUris")]
    public List<string> RedirectUris { get; set; }
    
    /// <summary>
    /// Gets or Sets WebOrigins
    /// </summary>
    [JsonPropertyName("webOrigins")]
    public List<string> WebOrigins { get; set; }
    
    /// <summary>
    /// Gets or Sets NotBefore
    /// </summary>
    [JsonPropertyName("notBefore")]
    public int? NotBefore { get; set; }
    
    /// <summary>
    /// Gets or Sets BearerOnly
    /// </summary>
    [JsonPropertyName("bearerOnly")]
    public bool? BearerOnly { get; set; }
    
    /// <summary>
    /// Gets or Sets ConsentRequired
    /// </summary>
    [JsonPropertyName("consentRequired")]
    public bool? ConsentRequired { get; set; }
    
    /// <summary>
    /// Gets or Sets StandardFlowEnabled
    /// </summary>
    [JsonPropertyName("standardFlowEnabled")]
    public bool? StandardFlowEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets ImplicitFlowEnabled
    /// </summary>
    [JsonPropertyName("implicitFlowEnabled")]
    public bool? ImplicitFlowEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets DirectAccessGrantsEnabled
    /// </summary>
    [JsonPropertyName("directAccessGrantsEnabled")]
    public bool? DirectAccessGrantsEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets ServiceAccountsEnabled
    /// </summary>
    [JsonPropertyName("serviceAccountsEnabled")]
    public bool? ServiceAccountsEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets Oauth2DeviceAuthorizationGrantEnabled
    /// </summary>
    [JsonPropertyName("oauth2DeviceAuthorizationGrantEnabled")]
    public bool? Oauth2DeviceAuthorizationGrantEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthorizationServicesEnabled
    /// </summary>
    [JsonPropertyName("authorizationServicesEnabled")]
    public bool? AuthorizationServicesEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets DirectGrantsOnly
    /// </summary>
    [JsonPropertyName("directGrantsOnly")]
    public bool? DirectGrantsOnly { get; set; }
    
    /// <summary>
    /// Gets or Sets PublicClient
    /// </summary>
    [JsonPropertyName("publicClient")]
    public bool? PublicClient { get; set; }
    
    /// <summary>
    /// Gets or Sets FrontchannelLogout
    /// </summary>
    [JsonPropertyName("frontchannelLogout")]
    public bool? FrontchannelLogout { get; set; }
    
    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
    
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthenticationFlowBindingOverrides
    /// </summary>
    [JsonPropertyName("authenticationFlowBindingOverrides")]
    public Dictionary<string, string> AuthenticationFlowBindingOverrides { get; set; }
    
    /// <summary>
    /// Gets or Sets FullScopeAllowed
    /// </summary>
    [JsonPropertyName("fullScopeAllowed")]
    public bool? FullScopeAllowed { get; set; }
    
    /// <summary>
    /// Gets or Sets NodeReRegistrationTimeout
    /// </summary>
    [JsonPropertyName("nodeReRegistrationTimeout")]
    public int? NodeReRegistrationTimeout { get; set; }
    
    /// <summary>
    /// Gets or Sets RegisteredNodes
    /// </summary>
    [JsonPropertyName("registeredNodes")]
    public Dictionary<string, int?> RegisteredNodes { get; set; }
    
    /// <summary>
    /// Gets or Sets ProtocolMappers
    /// </summary>
    [JsonPropertyName("protocolMappers")]
    public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientTemplate
    /// </summary>
    [JsonPropertyName("clientTemplate")]
    public string ClientTemplate { get; set; }
    
    /// <summary>
    /// Gets or Sets UseTemplateConfig
    /// </summary>
    [JsonPropertyName("useTemplateConfig")]
    public bool? UseTemplateConfig { get; set; }
    
    /// <summary>
    /// Gets or Sets UseTemplateScope
    /// </summary>
    [JsonPropertyName("useTemplateScope")]
    public bool? UseTemplateScope { get; set; }
    
    /// <summary>
    /// Gets or Sets UseTemplateMappers
    /// </summary>
    [JsonPropertyName("useTemplateMappers")]
    public bool? UseTemplateMappers { get; set; }
    
    /// <summary>
    /// Gets or Sets DefaultClientScopes
    /// </summary>
    [JsonPropertyName("defaultClientScopes")]
    public List<string> DefaultClientScopes { get; set; }
    
    /// <summary>
    /// Gets or Sets OptionalClientScopes
    /// </summary>
    [JsonPropertyName("optionalClientScopes")]
    public List<string> OptionalClientScopes { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthorizationSettings
    /// </summary>
    [JsonPropertyName("authorizationSettings")]
    public ResourceServerRepresentation AuthorizationSettings { get; set; }
    
    /// <summary>
    /// Gets or Sets Access
    /// </summary>
    [JsonPropertyName("access")]
    public Dictionary<string, bool?> Access { get; set; }
    
    /// <summary>
    /// Gets or Sets Origin
    /// </summary>
    [JsonPropertyName("origin")]
    public string Origin { get; set; }
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets Claims
    /// </summary>
    [JsonPropertyName("claims")]
    public ApplicationRepresentationClaims Claims { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class OAuthClientRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  RootUrl: ").Append(RootUrl).Append("\n");
      sb.Append("  AdminUrl: ").Append(AdminUrl).Append("\n");
      sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
      sb.Append("  SurrogateAuthRequired: ").Append(SurrogateAuthRequired).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  AlwaysDisplayInConsole: ").Append(AlwaysDisplayInConsole).Append("\n");
      sb.Append("  ClientAuthenticatorType: ").Append(ClientAuthenticatorType).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  RegistrationAccessToken: ").Append(RegistrationAccessToken).Append("\n");
      sb.Append("  DefaultRoles: ").Append(DefaultRoles).Append("\n");
      sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
      sb.Append("  WebOrigins: ").Append(WebOrigins).Append("\n");
      sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
      sb.Append("  BearerOnly: ").Append(BearerOnly).Append("\n");
      sb.Append("  ConsentRequired: ").Append(ConsentRequired).Append("\n");
      sb.Append("  StandardFlowEnabled: ").Append(StandardFlowEnabled).Append("\n");
      sb.Append("  ImplicitFlowEnabled: ").Append(ImplicitFlowEnabled).Append("\n");
      sb.Append("  DirectAccessGrantsEnabled: ").Append(DirectAccessGrantsEnabled).Append("\n");
      sb.Append("  ServiceAccountsEnabled: ").Append(ServiceAccountsEnabled).Append("\n");
      sb.Append("  Oauth2DeviceAuthorizationGrantEnabled: ").Append(Oauth2DeviceAuthorizationGrantEnabled).Append("\n");
      sb.Append("  AuthorizationServicesEnabled: ").Append(AuthorizationServicesEnabled).Append("\n");
      sb.Append("  DirectGrantsOnly: ").Append(DirectGrantsOnly).Append("\n");
      sb.Append("  PublicClient: ").Append(PublicClient).Append("\n");
      sb.Append("  FrontchannelLogout: ").Append(FrontchannelLogout).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  AuthenticationFlowBindingOverrides: ").Append(AuthenticationFlowBindingOverrides).Append("\n");
      sb.Append("  FullScopeAllowed: ").Append(FullScopeAllowed).Append("\n");
      sb.Append("  NodeReRegistrationTimeout: ").Append(NodeReRegistrationTimeout).Append("\n");
      sb.Append("  RegisteredNodes: ").Append(RegisteredNodes).Append("\n");
      sb.Append("  ProtocolMappers: ").Append(ProtocolMappers).Append("\n");
      sb.Append("  ClientTemplate: ").Append(ClientTemplate).Append("\n");
      sb.Append("  UseTemplateConfig: ").Append(UseTemplateConfig).Append("\n");
      sb.Append("  UseTemplateScope: ").Append(UseTemplateScope).Append("\n");
      sb.Append("  UseTemplateMappers: ").Append(UseTemplateMappers).Append("\n");
      sb.Append("  DefaultClientScopes: ").Append(DefaultClientScopes).Append("\n");
      sb.Append("  OptionalClientScopes: ").Append(OptionalClientScopes).Append("\n");
      sb.Append("  AuthorizationSettings: ").Append(AuthorizationSettings).Append("\n");
      sb.Append("  Access: ").Append(Access).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Claims: ").Append(Claims).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
