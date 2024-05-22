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
public partial class UserRepresentation 
{
    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [JsonPropertyName("self")]
    public string Self { get; set; }
    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Origin
    /// </summary>
    [JsonPropertyName("origin")]
    public string Origin { get; set; }
    
    /// <summary>
    /// Gets or Sets CreatedTimestamp
    /// </summary>
    [JsonPropertyName("createdTimestamp")]
    public long? CreatedTimestamp { get; set; }
    
    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
    
    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
    
    /// <summary>
    /// Gets or Sets Totp
    /// </summary>
    [JsonPropertyName("totp")]
    public bool? Totp { get; set; }
    
    /// <summary>
    /// Gets or Sets EmailVerified
    /// </summary>
    [JsonPropertyName("emailVerified")]
    public bool? EmailVerified { get; set; }
    
    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }
    
    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }
    
    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }
    
    /// <summary>
    /// Gets or Sets FederationLink
    /// </summary>
    [JsonPropertyName("federationLink")]
    public string FederationLink { get; set; }
    
    /// <summary>
    /// Gets or Sets ServiceAccountClientId
    /// </summary>
    [JsonPropertyName("serviceAccountClientId")]
    public string ServiceAccountClientId { get; set; }
    
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public Dictionary<string, ArrayList> Attributes { get; set; }
    
    /// <summary>
    /// Gets or Sets Credentials
    /// </summary>
    [JsonPropertyName("credentials")]
    public List<CredentialRepresentation> Credentials { get; set; }
    
    /// <summary>
    /// Gets or Sets DisableableCredentialTypes
    /// </summary>
    [JsonPropertyName("disableableCredentialTypes")]
    public List<string> DisableableCredentialTypes { get; set; }
    
    /// <summary>
    /// Gets or Sets RequiredActions
    /// </summary>
    [JsonPropertyName("requiredActions")]
    public List<string> RequiredActions { get; set; }
    
    /// <summary>
    /// Gets or Sets FederatedIdentities
    /// </summary>
    [JsonPropertyName("federatedIdentities")]
    public List<FederatedIdentityRepresentation> FederatedIdentities { get; set; }
    
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
    /// Gets or Sets ClientConsents
    /// </summary>
    [JsonPropertyName("clientConsents")]
    public List<UserConsentRepresentation> ClientConsents { get; set; }
    
    /// <summary>
    /// Gets or Sets NotBefore
    /// </summary>
    [JsonPropertyName("notBefore")]
    public int? NotBefore { get; set; }
    
    /// <summary>
    /// Gets or Sets ApplicationRoles
    /// </summary>
    [JsonPropertyName("applicationRoles")]
    public Dictionary<string, ArrayList> ApplicationRoles { get; set; }
    
    /// <summary>
    /// Gets or Sets SocialLinks
    /// </summary>
    [JsonPropertyName("socialLinks")]
    public List<SocialLinkRepresentation> SocialLinks { get; set; }
    
    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [JsonPropertyName("groups")]
    public List<string> Groups { get; set; }
    
    /// <summary>
    /// Gets or Sets Access
    /// </summary>
    [JsonPropertyName("access")]
    public Dictionary<string, bool?> Access { get; set; }
    
    /// <summary>
    /// Gets or Sets UserProfileMetadata
    /// </summary>
    [JsonPropertyName("userProfileMetadata")]
    public UserProfileMetadata UserProfileMetadata { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class UserRepresentation {\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Totp: ").Append(Totp).Append("\n");
      sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FederationLink: ").Append(FederationLink).Append("\n");
      sb.Append("  ServiceAccountClientId: ").Append(ServiceAccountClientId).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  Credentials: ").Append(Credentials).Append("\n");
      sb.Append("  DisableableCredentialTypes: ").Append(DisableableCredentialTypes).Append("\n");
      sb.Append("  RequiredActions: ").Append(RequiredActions).Append("\n");
      sb.Append("  FederatedIdentities: ").Append(FederatedIdentities).Append("\n");
      sb.Append("  RealmRoles: ").Append(RealmRoles).Append("\n");
      sb.Append("  ClientRoles: ").Append(ClientRoles).Append("\n");
      sb.Append("  ClientConsents: ").Append(ClientConsents).Append("\n");
      sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
      sb.Append("  ApplicationRoles: ").Append(ApplicationRoles).Append("\n");
      sb.Append("  SocialLinks: ").Append(SocialLinks).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Access: ").Append(Access).Append("\n");
      sb.Append("  UserProfileMetadata: ").Append(UserProfileMetadata).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
