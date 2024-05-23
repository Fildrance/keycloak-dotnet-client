using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace Keycloak.Client.Models
{
    /// <summary>
    /// 
    /// </summary>
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class RealmRepresentation 
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Gets or Sets Realm
        /// </summary>
        [JsonPropertyName("realm")]
        public string Realm { get; set; }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        
        /// <summary>
        /// Gets or Sets DisplayNameHtml
        /// </summary>
        [JsonPropertyName("displayNameHtml")]
        public string DisplayNameHtml { get; set; }
        
        /// <summary>
        /// Gets or Sets NotBefore
        /// </summary>
        [JsonPropertyName("notBefore")]
        public int? NotBefore { get; set; }
        
        /// <summary>
        /// Gets or Sets DefaultSignatureAlgorithm
        /// </summary>
        [JsonPropertyName("defaultSignatureAlgorithm")]
        public string DefaultSignatureAlgorithm { get; set; }
        
        /// <summary>
        /// Gets or Sets RevokeRefreshToken
        /// </summary>
        [JsonPropertyName("revokeRefreshToken")]
        public bool? RevokeRefreshToken { get; set; }
        
        /// <summary>
        /// Gets or Sets RefreshTokenMaxReuse
        /// </summary>
        [JsonPropertyName("refreshTokenMaxReuse")]
        public int? RefreshTokenMaxReuse { get; set; }
        
        /// <summary>
        /// Gets or Sets AccessTokenLifespan
        /// </summary>
        [JsonPropertyName("accessTokenLifespan")]
        public int? AccessTokenLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets AccessTokenLifespanForImplicitFlow
        /// </summary>
        [JsonPropertyName("accessTokenLifespanForImplicitFlow")]
        public int? AccessTokenLifespanForImplicitFlow { get; set; }
        
        /// <summary>
        /// Gets or Sets SsoSessionIdleTimeout
        /// </summary>
        [JsonPropertyName("ssoSessionIdleTimeout")]
        public int? SsoSessionIdleTimeout { get; set; }
        
        /// <summary>
        /// Gets or Sets SsoSessionMaxLifespan
        /// </summary>
        [JsonPropertyName("ssoSessionMaxLifespan")]
        public int? SsoSessionMaxLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets SsoSessionIdleTimeoutRememberMe
        /// </summary>
        [JsonPropertyName("ssoSessionIdleTimeoutRememberMe")]
        public int? SsoSessionIdleTimeoutRememberMe { get; set; }
        
        /// <summary>
        /// Gets or Sets SsoSessionMaxLifespanRememberMe
        /// </summary>
        [JsonPropertyName("ssoSessionMaxLifespanRememberMe")]
        public int? SsoSessionMaxLifespanRememberMe { get; set; }
        
        /// <summary>
        /// Gets or Sets OfflineSessionIdleTimeout
        /// </summary>
        [JsonPropertyName("offlineSessionIdleTimeout")]
        public int? OfflineSessionIdleTimeout { get; set; }
        
        /// <summary>
        /// Gets or Sets OfflineSessionMaxLifespanEnabled
        /// </summary>
        [JsonPropertyName("offlineSessionMaxLifespanEnabled")]
        public bool? OfflineSessionMaxLifespanEnabled { get; set; }
        
        /// <summary>
        /// Gets or Sets OfflineSessionMaxLifespan
        /// </summary>
        [JsonPropertyName("offlineSessionMaxLifespan")]
        public int? OfflineSessionMaxLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientSessionIdleTimeout
        /// </summary>
        [JsonPropertyName("clientSessionIdleTimeout")]
        public int? ClientSessionIdleTimeout { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientSessionMaxLifespan
        /// </summary>
        [JsonPropertyName("clientSessionMaxLifespan")]
        public int? ClientSessionMaxLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientOfflineSessionIdleTimeout
        /// </summary>
        [JsonPropertyName("clientOfflineSessionIdleTimeout")]
        public int? ClientOfflineSessionIdleTimeout { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientOfflineSessionMaxLifespan
        /// </summary>
        [JsonPropertyName("clientOfflineSessionMaxLifespan")]
        public int? ClientOfflineSessionMaxLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets AccessCodeLifespan
        /// </summary>
        [JsonPropertyName("accessCodeLifespan")]
        public int? AccessCodeLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets AccessCodeLifespanUserAction
        /// </summary>
        [JsonPropertyName("accessCodeLifespanUserAction")]
        public int? AccessCodeLifespanUserAction { get; set; }
        
        /// <summary>
        /// Gets or Sets AccessCodeLifespanLogin
        /// </summary>
        [JsonPropertyName("accessCodeLifespanLogin")]
        public int? AccessCodeLifespanLogin { get; set; }
        
        /// <summary>
        /// Gets or Sets ActionTokenGeneratedByAdminLifespan
        /// </summary>
        [JsonPropertyName("actionTokenGeneratedByAdminLifespan")]
        public int? ActionTokenGeneratedByAdminLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets ActionTokenGeneratedByUserLifespan
        /// </summary>
        [JsonPropertyName("actionTokenGeneratedByUserLifespan")]
        public int? ActionTokenGeneratedByUserLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets Oauth2DeviceCodeLifespan
        /// </summary>
        [JsonPropertyName("oauth2DeviceCodeLifespan")]
        public int? Oauth2DeviceCodeLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets Oauth2DevicePollingInterval
        /// </summary>
        [JsonPropertyName("oauth2DevicePollingInterval")]
        public int? Oauth2DevicePollingInterval { get; set; }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
        /// <summary>
        /// Gets or Sets SslRequired
        /// </summary>
        [JsonPropertyName("sslRequired")]
        public string SslRequired { get; set; }
        
        /// <summary>
        /// Gets or Sets PasswordCredentialGrantAllowed
        /// </summary>
        [JsonPropertyName("passwordCredentialGrantAllowed")]
        public bool? PasswordCredentialGrantAllowed { get; set; }
        
        /// <summary>
        /// Gets or Sets RegistrationAllowed
        /// </summary>
        [JsonPropertyName("registrationAllowed")]
        public bool? RegistrationAllowed { get; set; }
        
        /// <summary>
        /// Gets or Sets RegistrationEmailAsUsername
        /// </summary>
        [JsonPropertyName("registrationEmailAsUsername")]
        public bool? RegistrationEmailAsUsername { get; set; }
        
        /// <summary>
        /// Gets or Sets RememberMe
        /// </summary>
        [JsonPropertyName("rememberMe")]
        public bool? RememberMe { get; set; }
        
        /// <summary>
        /// Gets or Sets VerifyEmail
        /// </summary>
        [JsonPropertyName("verifyEmail")]
        public bool? VerifyEmail { get; set; }
        
        /// <summary>
        /// Gets or Sets LoginWithEmailAllowed
        /// </summary>
        [JsonPropertyName("loginWithEmailAllowed")]
        public bool? LoginWithEmailAllowed { get; set; }
        
        /// <summary>
        /// Gets or Sets DuplicateEmailsAllowed
        /// </summary>
        [JsonPropertyName("duplicateEmailsAllowed")]
        public bool? DuplicateEmailsAllowed { get; set; }
        
        /// <summary>
        /// Gets or Sets ResetPasswordAllowed
        /// </summary>
        [JsonPropertyName("resetPasswordAllowed")]
        public bool? ResetPasswordAllowed { get; set; }
        
        /// <summary>
        /// Gets or Sets EditUsernameAllowed
        /// </summary>
        [JsonPropertyName("editUsernameAllowed")]
        public bool? EditUsernameAllowed { get; set; }
        
        /// <summary>
        /// Gets or Sets UserCacheEnabled
        /// </summary>
        [JsonPropertyName("userCacheEnabled")]
        public bool? UserCacheEnabled { get; set; }
        
        /// <summary>
        /// Gets or Sets RealmCacheEnabled
        /// </summary>
        [JsonPropertyName("realmCacheEnabled")]
        public bool? RealmCacheEnabled { get; set; }
        
        /// <summary>
        /// Gets or Sets BruteForceProtected
        /// </summary>
        [JsonPropertyName("bruteForceProtected")]
        public bool? BruteForceProtected { get; set; }
        
        /// <summary>
        /// Gets or Sets PermanentLockout
        /// </summary>
        [JsonPropertyName("permanentLockout")]
        public bool? PermanentLockout { get; set; }
        
        /// <summary>
        /// Gets or Sets MaxFailureWaitSeconds
        /// </summary>
        [JsonPropertyName("maxFailureWaitSeconds")]
        public int? MaxFailureWaitSeconds { get; set; }
        
        /// <summary>
        /// Gets or Sets MinimumQuickLoginWaitSeconds
        /// </summary>
        [JsonPropertyName("minimumQuickLoginWaitSeconds")]
        public int? MinimumQuickLoginWaitSeconds { get; set; }
        
        /// <summary>
        /// Gets or Sets WaitIncrementSeconds
        /// </summary>
        [JsonPropertyName("waitIncrementSeconds")]
        public int? WaitIncrementSeconds { get; set; }
        
        /// <summary>
        /// Gets or Sets QuickLoginCheckMilliSeconds
        /// </summary>
        [JsonPropertyName("quickLoginCheckMilliSeconds")]
        public long? QuickLoginCheckMilliSeconds { get; set; }
        
        /// <summary>
        /// Gets or Sets MaxDeltaTimeSeconds
        /// </summary>
        [JsonPropertyName("maxDeltaTimeSeconds")]
        public int? MaxDeltaTimeSeconds { get; set; }
        
        /// <summary>
        /// Gets or Sets FailureFactor
        /// </summary>
        [JsonPropertyName("failureFactor")]
        public int? FailureFactor { get; set; }
        
        /// <summary>
        /// Gets or Sets PrivateKey
        /// </summary>
        [JsonPropertyName("privateKey")]
        public string PrivateKey { get; set; }
        
        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [JsonPropertyName("publicKey")]
        public string PublicKey { get; set; }
        
        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [JsonPropertyName("certificate")]
        public string Certificate { get; set; }
        
        /// <summary>
        /// Gets or Sets CodeSecret
        /// </summary>
        [JsonPropertyName("codeSecret")]
        public string CodeSecret { get; set; }
        
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [JsonPropertyName("roles")]
        public RolesRepresentation Roles { get; set; }
        
        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [JsonPropertyName("groups")]
        public List<GroupRepresentation> Groups { get; set; }
        
        /// <summary>
        /// Gets or Sets DefaultRoles
        /// </summary>
        [JsonPropertyName("defaultRoles")]
        public List<string> DefaultRoles { get; set; }
        
        /// <summary>
        /// Gets or Sets DefaultRole
        /// </summary>
        [JsonPropertyName("defaultRole")]
        public RoleRepresentation DefaultRole { get; set; }
        
        /// <summary>
        /// Gets or Sets DefaultGroups
        /// </summary>
        [JsonPropertyName("defaultGroups")]
        public List<string> DefaultGroups { get; set; }
        
        /// <summary>
        /// Gets or Sets RequiredCredentials
        /// </summary>
        [JsonPropertyName("requiredCredentials")]
        public List<string> RequiredCredentials { get; set; }
        
        /// <summary>
        /// Gets or Sets PasswordPolicy
        /// </summary>
        [JsonPropertyName("passwordPolicy")]
        public string PasswordPolicy { get; set; }
        
        /// <summary>
        /// Gets or Sets OtpPolicyType
        /// </summary>
        [JsonPropertyName("otpPolicyType")]
        public string OtpPolicyType { get; set; }
        
        /// <summary>
        /// Gets or Sets OtpPolicyAlgorithm
        /// </summary>
        [JsonPropertyName("otpPolicyAlgorithm")]
        public string OtpPolicyAlgorithm { get; set; }
        
        /// <summary>
        /// Gets or Sets OtpPolicyInitialCounter
        /// </summary>
        [JsonPropertyName("otpPolicyInitialCounter")]
        public int? OtpPolicyInitialCounter { get; set; }
        
        /// <summary>
        /// Gets or Sets OtpPolicyDigits
        /// </summary>
        [JsonPropertyName("otpPolicyDigits")]
        public int? OtpPolicyDigits { get; set; }
        
        /// <summary>
        /// Gets or Sets OtpPolicyLookAheadWindow
        /// </summary>
        [JsonPropertyName("otpPolicyLookAheadWindow")]
        public int? OtpPolicyLookAheadWindow { get; set; }
        
        /// <summary>
        /// Gets or Sets OtpPolicyPeriod
        /// </summary>
        [JsonPropertyName("otpPolicyPeriod")]
        public int? OtpPolicyPeriod { get; set; }
        
        /// <summary>
        /// Gets or Sets OtpPolicyCodeReusable
        /// </summary>
        [JsonPropertyName("otpPolicyCodeReusable")]
        public bool? OtpPolicyCodeReusable { get; set; }
        
        /// <summary>
        /// Gets or Sets OtpSupportedApplications
        /// </summary>
        [JsonPropertyName("otpSupportedApplications")]
        public List<string> OtpSupportedApplications { get; set; }
        
        /// <summary>
        /// Gets or Sets LocalizationTexts
        /// </summary>
        [JsonPropertyName("localizationTexts")]
        public Dictionary<string, Dictionary<string, Object>> LocalizationTexts { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyRpEntityName
        /// </summary>
        [JsonPropertyName("webAuthnPolicyRpEntityName")]
        public string WebAuthnPolicyRpEntityName { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicySignatureAlgorithms
        /// </summary>
        [JsonPropertyName("webAuthnPolicySignatureAlgorithms")]
        public List<string> WebAuthnPolicySignatureAlgorithms { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyRpId
        /// </summary>
        [JsonPropertyName("webAuthnPolicyRpId")]
        public string WebAuthnPolicyRpId { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyAttestationConveyancePreference
        /// </summary>
        [JsonPropertyName("webAuthnPolicyAttestationConveyancePreference")]
        public string WebAuthnPolicyAttestationConveyancePreference { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyAuthenticatorAttachment
        /// </summary>
        [JsonPropertyName("webAuthnPolicyAuthenticatorAttachment")]
        public string WebAuthnPolicyAuthenticatorAttachment { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyRequireResidentKey
        /// </summary>
        [JsonPropertyName("webAuthnPolicyRequireResidentKey")]
        public string WebAuthnPolicyRequireResidentKey { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyUserVerificationRequirement
        /// </summary>
        [JsonPropertyName("webAuthnPolicyUserVerificationRequirement")]
        public string WebAuthnPolicyUserVerificationRequirement { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyCreateTimeout
        /// </summary>
        [JsonPropertyName("webAuthnPolicyCreateTimeout")]
        public int? WebAuthnPolicyCreateTimeout { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyAvoidSameAuthenticatorRegister
        /// </summary>
        [JsonPropertyName("webAuthnPolicyAvoidSameAuthenticatorRegister")]
        public bool? WebAuthnPolicyAvoidSameAuthenticatorRegister { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyAcceptableAaguids
        /// </summary>
        [JsonPropertyName("webAuthnPolicyAcceptableAaguids")]
        public List<string> WebAuthnPolicyAcceptableAaguids { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyExtraOrigins
        /// </summary>
        [JsonPropertyName("webAuthnPolicyExtraOrigins")]
        public List<string> WebAuthnPolicyExtraOrigins { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessRpEntityName
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessRpEntityName")]
        public string WebAuthnPolicyPasswordlessRpEntityName { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessSignatureAlgorithms
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessSignatureAlgorithms")]
        public List<string> WebAuthnPolicyPasswordlessSignatureAlgorithms { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessRpId
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessRpId")]
        public string WebAuthnPolicyPasswordlessRpId { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessAttestationConveyancePreference
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessAttestationConveyancePreference")]
        public string WebAuthnPolicyPasswordlessAttestationConveyancePreference { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessAuthenticatorAttachment
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessAuthenticatorAttachment")]
        public string WebAuthnPolicyPasswordlessAuthenticatorAttachment { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessRequireResidentKey
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessRequireResidentKey")]
        public string WebAuthnPolicyPasswordlessRequireResidentKey { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessUserVerificationRequirement
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessUserVerificationRequirement")]
        public string WebAuthnPolicyPasswordlessUserVerificationRequirement { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessCreateTimeout
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessCreateTimeout")]
        public int? WebAuthnPolicyPasswordlessCreateTimeout { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister")]
        public bool? WebAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessAcceptableAaguids
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessAcceptableAaguids")]
        public List<string> WebAuthnPolicyPasswordlessAcceptableAaguids { get; set; }
        
        /// <summary>
        /// Gets or Sets WebAuthnPolicyPasswordlessExtraOrigins
        /// </summary>
        [JsonPropertyName("webAuthnPolicyPasswordlessExtraOrigins")]
        public List<string> WebAuthnPolicyPasswordlessExtraOrigins { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientProfiles
        /// </summary>
        [JsonPropertyName("clientProfiles")]
        public ClientProfilesRepresentation ClientProfiles { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientPolicies
        /// </summary>
        [JsonPropertyName("clientPolicies")]
        public ClientPoliciesRepresentation ClientPolicies { get; set; }
        
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [JsonPropertyName("users")]
        public List<UserRepresentation> Users { get; set; }
        
        /// <summary>
        /// Gets or Sets FederatedUsers
        /// </summary>
        [JsonPropertyName("federatedUsers")]
        public List<UserRepresentation> FederatedUsers { get; set; }
        
        /// <summary>
        /// Gets or Sets ScopeMappings
        /// </summary>
        [JsonPropertyName("scopeMappings")]
        public List<ScopeMappingRepresentation> ScopeMappings { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientScopeMappings
        /// </summary>
        [JsonPropertyName("clientScopeMappings")]
        public Dictionary<string, ArrayList> ClientScopeMappings { get; set; }
        
        /// <summary>
        /// Gets or Sets Clients
        /// </summary>
        [JsonPropertyName("clients")]
        public List<ClientRepresentation> Clients { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientScopes
        /// </summary>
        [JsonPropertyName("clientScopes")]
        public List<ClientScopeRepresentation> ClientScopes { get; set; }
        
        /// <summary>
        /// Gets or Sets DefaultDefaultClientScopes
        /// </summary>
        [JsonPropertyName("defaultDefaultClientScopes")]
        public List<string> DefaultDefaultClientScopes { get; set; }
        
        /// <summary>
        /// Gets or Sets DefaultOptionalClientScopes
        /// </summary>
        [JsonPropertyName("defaultOptionalClientScopes")]
        public List<string> DefaultOptionalClientScopes { get; set; }
        
        /// <summary>
        /// Gets or Sets BrowserSecurityHeaders
        /// </summary>
        [JsonPropertyName("browserSecurityHeaders")]
        public Dictionary<string, string> BrowserSecurityHeaders { get; set; }
        
        /// <summary>
        /// Gets or Sets SmtpServer
        /// </summary>
        [JsonPropertyName("smtpServer")]
        public Dictionary<string, string> SmtpServer { get; set; }
        
        /// <summary>
        /// Gets or Sets UserFederationProviders
        /// </summary>
        [JsonPropertyName("userFederationProviders")]
        public List<UserFederationProviderRepresentation> UserFederationProviders { get; set; }
        
        /// <summary>
        /// Gets or Sets UserFederationMappers
        /// </summary>
        [JsonPropertyName("userFederationMappers")]
        public List<UserFederationMapperRepresentation> UserFederationMappers { get; set; }
        
        /// <summary>
        /// Gets or Sets LoginTheme
        /// </summary>
        [JsonPropertyName("loginTheme")]
        public string LoginTheme { get; set; }
        
        /// <summary>
        /// Gets or Sets AccountTheme
        /// </summary>
        [JsonPropertyName("accountTheme")]
        public string AccountTheme { get; set; }
        
        /// <summary>
        /// Gets or Sets AdminTheme
        /// </summary>
        [JsonPropertyName("adminTheme")]
        public string AdminTheme { get; set; }
        
        /// <summary>
        /// Gets or Sets EmailTheme
        /// </summary>
        [JsonPropertyName("emailTheme")]
        public string EmailTheme { get; set; }
        
        /// <summary>
        /// Gets or Sets EventsEnabled
        /// </summary>
        [JsonPropertyName("eventsEnabled")]
        public bool? EventsEnabled { get; set; }
        
        /// <summary>
        /// Gets or Sets EventsExpiration
        /// </summary>
        [JsonPropertyName("eventsExpiration")]
        public long? EventsExpiration { get; set; }
        
        /// <summary>
        /// Gets or Sets EventsListeners
        /// </summary>
        [JsonPropertyName("eventsListeners")]
        public List<string> EventsListeners { get; set; }
        
        /// <summary>
        /// Gets or Sets EnabledEventTypes
        /// </summary>
        [JsonPropertyName("enabledEventTypes")]
        public List<string> EnabledEventTypes { get; set; }
        
        /// <summary>
        /// Gets or Sets AdminEventsEnabled
        /// </summary>
        [JsonPropertyName("adminEventsEnabled")]
        public bool? AdminEventsEnabled { get; set; }
        
        /// <summary>
        /// Gets or Sets AdminEventsDetailsEnabled
        /// </summary>
        [JsonPropertyName("adminEventsDetailsEnabled")]
        public bool? AdminEventsDetailsEnabled { get; set; }
        
        /// <summary>
        /// Gets or Sets IdentityProviders
        /// </summary>
        [JsonPropertyName("identityProviders")]
        public List<IdentityProviderRepresentation> IdentityProviders { get; set; }
        
        /// <summary>
        /// Gets or Sets IdentityProviderMappers
        /// </summary>
        [JsonPropertyName("identityProviderMappers")]
        public List<IdentityProviderMapperRepresentation> IdentityProviderMappers { get; set; }
        
        /// <summary>
        /// Gets or Sets ProtocolMappers
        /// </summary>
        [JsonPropertyName("protocolMappers")]
        public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }
        
        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [JsonPropertyName("components")]
        public Dictionary<string, ArrayList> Components { get; set; }
        
        /// <summary>
        /// Gets or Sets InternationalizationEnabled
        /// </summary>
        [JsonPropertyName("internationalizationEnabled")]
        public bool? InternationalizationEnabled { get; set; }
        
        /// <summary>
        /// Gets or Sets SupportedLocales
        /// </summary>
        [JsonPropertyName("supportedLocales")]
        public List<string> SupportedLocales { get; set; }
        
        /// <summary>
        /// Gets or Sets DefaultLocale
        /// </summary>
        [JsonPropertyName("defaultLocale")]
        public string DefaultLocale { get; set; }
        
        /// <summary>
        /// Gets or Sets AuthenticationFlows
        /// </summary>
        [JsonPropertyName("authenticationFlows")]
        public List<AuthenticationFlowRepresentation> AuthenticationFlows { get; set; }
        
        /// <summary>
        /// Gets or Sets AuthenticatorConfig
        /// </summary>
        [JsonPropertyName("authenticatorConfig")]
        public List<AuthenticatorConfigRepresentation> AuthenticatorConfig { get; set; }
        
        /// <summary>
        /// Gets or Sets RequiredActions
        /// </summary>
        [JsonPropertyName("requiredActions")]
        public List<RequiredActionProviderRepresentation> RequiredActions { get; set; }
        
        /// <summary>
        /// Gets or Sets BrowserFlow
        /// </summary>
        [JsonPropertyName("browserFlow")]
        public string BrowserFlow { get; set; }
        
        /// <summary>
        /// Gets or Sets RegistrationFlow
        /// </summary>
        [JsonPropertyName("registrationFlow")]
        public string RegistrationFlow { get; set; }
        
        /// <summary>
        /// Gets or Sets DirectGrantFlow
        /// </summary>
        [JsonPropertyName("directGrantFlow")]
        public string DirectGrantFlow { get; set; }
        
        /// <summary>
        /// Gets or Sets ResetCredentialsFlow
        /// </summary>
        [JsonPropertyName("resetCredentialsFlow")]
        public string ResetCredentialsFlow { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientAuthenticationFlow
        /// </summary>
        [JsonPropertyName("clientAuthenticationFlow")]
        public string ClientAuthenticationFlow { get; set; }
        
        /// <summary>
        /// Gets or Sets DockerAuthenticationFlow
        /// </summary>
        [JsonPropertyName("dockerAuthenticationFlow")]
        public string DockerAuthenticationFlow { get; set; }
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public Dictionary<string, string> Attributes { get; set; }
        
        /// <summary>
        /// Gets or Sets KeycloakVersion
        /// </summary>
        [JsonPropertyName("keycloakVersion")]
        public string KeycloakVersion { get; set; }
        
        /// <summary>
        /// Gets or Sets UserManagedAccessAllowed
        /// </summary>
        [JsonPropertyName("userManagedAccessAllowed")]
        public bool? UserManagedAccessAllowed { get; set; }
        
        /// <summary>
        /// Gets or Sets Social
        /// </summary>
        [JsonPropertyName("social")]
        public bool? Social { get; set; }
        
        /// <summary>
        /// Gets or Sets UpdateProfileOnInitialSocialLogin
        /// </summary>
        [JsonPropertyName("updateProfileOnInitialSocialLogin")]
        public bool? UpdateProfileOnInitialSocialLogin { get; set; }
        
        /// <summary>
        /// Gets or Sets SocialProviders
        /// </summary>
        [JsonPropertyName("socialProviders")]
        public Dictionary<string, string> SocialProviders { get; set; }
        
        /// <summary>
        /// Gets or Sets ApplicationScopeMappings
        /// </summary>
        [JsonPropertyName("applicationScopeMappings")]
        public Dictionary<string, ArrayList> ApplicationScopeMappings { get; set; }
        
        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [JsonPropertyName("applications")]
        public List<ApplicationRepresentation> Applications { get; set; }
        
        /// <summary>
        /// Gets or Sets OauthClients
        /// </summary>
        [JsonPropertyName("oauthClients")]
        public List<OAuthClientRepresentation> OauthClients { get; set; }
        
        /// <summary>
        /// Gets or Sets ClientTemplates
        /// </summary>
        [JsonPropertyName("clientTemplates")]
        public List<ClientTemplateRepresentation> ClientTemplates { get; set; }
        
        /// <summary>
        /// Gets or Sets OAuth2DeviceCodeLifespan
        /// </summary>
        [JsonPropertyName("oAuth2DeviceCodeLifespan")]
        public int? OAuth2DeviceCodeLifespan { get; set; }
        
        /// <summary>
        /// Gets or Sets OAuth2DevicePollingInterval
        /// </summary>
        [JsonPropertyName("oAuth2DevicePollingInterval")]
        public int? OAuth2DevicePollingInterval { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RealmRepresentation {\n");
          sb.Append("  Id: ").Append(Id).Append("\n");
          sb.Append("  Realm: ").Append(Realm).Append("\n");
          sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
          sb.Append("  DisplayNameHtml: ").Append(DisplayNameHtml).Append("\n");
          sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
          sb.Append("  DefaultSignatureAlgorithm: ").Append(DefaultSignatureAlgorithm).Append("\n");
          sb.Append("  RevokeRefreshToken: ").Append(RevokeRefreshToken).Append("\n");
          sb.Append("  RefreshTokenMaxReuse: ").Append(RefreshTokenMaxReuse).Append("\n");
          sb.Append("  AccessTokenLifespan: ").Append(AccessTokenLifespan).Append("\n");
          sb.Append("  AccessTokenLifespanForImplicitFlow: ").Append(AccessTokenLifespanForImplicitFlow).Append("\n");
          sb.Append("  SsoSessionIdleTimeout: ").Append(SsoSessionIdleTimeout).Append("\n");
          sb.Append("  SsoSessionMaxLifespan: ").Append(SsoSessionMaxLifespan).Append("\n");
          sb.Append("  SsoSessionIdleTimeoutRememberMe: ").Append(SsoSessionIdleTimeoutRememberMe).Append("\n");
          sb.Append("  SsoSessionMaxLifespanRememberMe: ").Append(SsoSessionMaxLifespanRememberMe).Append("\n");
          sb.Append("  OfflineSessionIdleTimeout: ").Append(OfflineSessionIdleTimeout).Append("\n");
          sb.Append("  OfflineSessionMaxLifespanEnabled: ").Append(OfflineSessionMaxLifespanEnabled).Append("\n");
          sb.Append("  OfflineSessionMaxLifespan: ").Append(OfflineSessionMaxLifespan).Append("\n");
          sb.Append("  ClientSessionIdleTimeout: ").Append(ClientSessionIdleTimeout).Append("\n");
          sb.Append("  ClientSessionMaxLifespan: ").Append(ClientSessionMaxLifespan).Append("\n");
          sb.Append("  ClientOfflineSessionIdleTimeout: ").Append(ClientOfflineSessionIdleTimeout).Append("\n");
          sb.Append("  ClientOfflineSessionMaxLifespan: ").Append(ClientOfflineSessionMaxLifespan).Append("\n");
          sb.Append("  AccessCodeLifespan: ").Append(AccessCodeLifespan).Append("\n");
          sb.Append("  AccessCodeLifespanUserAction: ").Append(AccessCodeLifespanUserAction).Append("\n");
          sb.Append("  AccessCodeLifespanLogin: ").Append(AccessCodeLifespanLogin).Append("\n");
          sb.Append("  ActionTokenGeneratedByAdminLifespan: ").Append(ActionTokenGeneratedByAdminLifespan).Append("\n");
          sb.Append("  ActionTokenGeneratedByUserLifespan: ").Append(ActionTokenGeneratedByUserLifespan).Append("\n");
          sb.Append("  Oauth2DeviceCodeLifespan: ").Append(Oauth2DeviceCodeLifespan).Append("\n");
          sb.Append("  Oauth2DevicePollingInterval: ").Append(Oauth2DevicePollingInterval).Append("\n");
          sb.Append("  Enabled: ").Append(Enabled).Append("\n");
          sb.Append("  SslRequired: ").Append(SslRequired).Append("\n");
          sb.Append("  PasswordCredentialGrantAllowed: ").Append(PasswordCredentialGrantAllowed).Append("\n");
          sb.Append("  RegistrationAllowed: ").Append(RegistrationAllowed).Append("\n");
          sb.Append("  RegistrationEmailAsUsername: ").Append(RegistrationEmailAsUsername).Append("\n");
          sb.Append("  RememberMe: ").Append(RememberMe).Append("\n");
          sb.Append("  VerifyEmail: ").Append(VerifyEmail).Append("\n");
          sb.Append("  LoginWithEmailAllowed: ").Append(LoginWithEmailAllowed).Append("\n");
          sb.Append("  DuplicateEmailsAllowed: ").Append(DuplicateEmailsAllowed).Append("\n");
          sb.Append("  ResetPasswordAllowed: ").Append(ResetPasswordAllowed).Append("\n");
          sb.Append("  EditUsernameAllowed: ").Append(EditUsernameAllowed).Append("\n");
          sb.Append("  UserCacheEnabled: ").Append(UserCacheEnabled).Append("\n");
          sb.Append("  RealmCacheEnabled: ").Append(RealmCacheEnabled).Append("\n");
          sb.Append("  BruteForceProtected: ").Append(BruteForceProtected).Append("\n");
          sb.Append("  PermanentLockout: ").Append(PermanentLockout).Append("\n");
          sb.Append("  MaxFailureWaitSeconds: ").Append(MaxFailureWaitSeconds).Append("\n");
          sb.Append("  MinimumQuickLoginWaitSeconds: ").Append(MinimumQuickLoginWaitSeconds).Append("\n");
          sb.Append("  WaitIncrementSeconds: ").Append(WaitIncrementSeconds).Append("\n");
          sb.Append("  QuickLoginCheckMilliSeconds: ").Append(QuickLoginCheckMilliSeconds).Append("\n");
          sb.Append("  MaxDeltaTimeSeconds: ").Append(MaxDeltaTimeSeconds).Append("\n");
          sb.Append("  FailureFactor: ").Append(FailureFactor).Append("\n");
          sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
          sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
          sb.Append("  Certificate: ").Append(Certificate).Append("\n");
          sb.Append("  CodeSecret: ").Append(CodeSecret).Append("\n");
          sb.Append("  Roles: ").Append(Roles).Append("\n");
          sb.Append("  Groups: ").Append(Groups).Append("\n");
          sb.Append("  DefaultRoles: ").Append(DefaultRoles).Append("\n");
          sb.Append("  DefaultRole: ").Append(DefaultRole).Append("\n");
          sb.Append("  DefaultGroups: ").Append(DefaultGroups).Append("\n");
          sb.Append("  RequiredCredentials: ").Append(RequiredCredentials).Append("\n");
          sb.Append("  PasswordPolicy: ").Append(PasswordPolicy).Append("\n");
          sb.Append("  OtpPolicyType: ").Append(OtpPolicyType).Append("\n");
          sb.Append("  OtpPolicyAlgorithm: ").Append(OtpPolicyAlgorithm).Append("\n");
          sb.Append("  OtpPolicyInitialCounter: ").Append(OtpPolicyInitialCounter).Append("\n");
          sb.Append("  OtpPolicyDigits: ").Append(OtpPolicyDigits).Append("\n");
          sb.Append("  OtpPolicyLookAheadWindow: ").Append(OtpPolicyLookAheadWindow).Append("\n");
          sb.Append("  OtpPolicyPeriod: ").Append(OtpPolicyPeriod).Append("\n");
          sb.Append("  OtpPolicyCodeReusable: ").Append(OtpPolicyCodeReusable).Append("\n");
          sb.Append("  OtpSupportedApplications: ").Append(OtpSupportedApplications).Append("\n");
          sb.Append("  LocalizationTexts: ").Append(LocalizationTexts).Append("\n");
          sb.Append("  WebAuthnPolicyRpEntityName: ").Append(WebAuthnPolicyRpEntityName).Append("\n");
          sb.Append("  WebAuthnPolicySignatureAlgorithms: ").Append(WebAuthnPolicySignatureAlgorithms).Append("\n");
          sb.Append("  WebAuthnPolicyRpId: ").Append(WebAuthnPolicyRpId).Append("\n");
          sb.Append("  WebAuthnPolicyAttestationConveyancePreference: ").Append(WebAuthnPolicyAttestationConveyancePreference).Append("\n");
          sb.Append("  WebAuthnPolicyAuthenticatorAttachment: ").Append(WebAuthnPolicyAuthenticatorAttachment).Append("\n");
          sb.Append("  WebAuthnPolicyRequireResidentKey: ").Append(WebAuthnPolicyRequireResidentKey).Append("\n");
          sb.Append("  WebAuthnPolicyUserVerificationRequirement: ").Append(WebAuthnPolicyUserVerificationRequirement).Append("\n");
          sb.Append("  WebAuthnPolicyCreateTimeout: ").Append(WebAuthnPolicyCreateTimeout).Append("\n");
          sb.Append("  WebAuthnPolicyAvoidSameAuthenticatorRegister: ").Append(WebAuthnPolicyAvoidSameAuthenticatorRegister).Append("\n");
          sb.Append("  WebAuthnPolicyAcceptableAaguids: ").Append(WebAuthnPolicyAcceptableAaguids).Append("\n");
          sb.Append("  WebAuthnPolicyExtraOrigins: ").Append(WebAuthnPolicyExtraOrigins).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessRpEntityName: ").Append(WebAuthnPolicyPasswordlessRpEntityName).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessSignatureAlgorithms: ").Append(WebAuthnPolicyPasswordlessSignatureAlgorithms).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessRpId: ").Append(WebAuthnPolicyPasswordlessRpId).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessAttestationConveyancePreference: ").Append(WebAuthnPolicyPasswordlessAttestationConveyancePreference).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessAuthenticatorAttachment: ").Append(WebAuthnPolicyPasswordlessAuthenticatorAttachment).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessRequireResidentKey: ").Append(WebAuthnPolicyPasswordlessRequireResidentKey).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessUserVerificationRequirement: ").Append(WebAuthnPolicyPasswordlessUserVerificationRequirement).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessCreateTimeout: ").Append(WebAuthnPolicyPasswordlessCreateTimeout).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister: ").Append(WebAuthnPolicyPasswordlessAvoidSameAuthenticatorRegister).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessAcceptableAaguids: ").Append(WebAuthnPolicyPasswordlessAcceptableAaguids).Append("\n");
          sb.Append("  WebAuthnPolicyPasswordlessExtraOrigins: ").Append(WebAuthnPolicyPasswordlessExtraOrigins).Append("\n");
          sb.Append("  ClientProfiles: ").Append(ClientProfiles).Append("\n");
          sb.Append("  ClientPolicies: ").Append(ClientPolicies).Append("\n");
          sb.Append("  Users: ").Append(Users).Append("\n");
          sb.Append("  FederatedUsers: ").Append(FederatedUsers).Append("\n");
          sb.Append("  ScopeMappings: ").Append(ScopeMappings).Append("\n");
          sb.Append("  ClientScopeMappings: ").Append(ClientScopeMappings).Append("\n");
          sb.Append("  Clients: ").Append(Clients).Append("\n");
          sb.Append("  ClientScopes: ").Append(ClientScopes).Append("\n");
          sb.Append("  DefaultDefaultClientScopes: ").Append(DefaultDefaultClientScopes).Append("\n");
          sb.Append("  DefaultOptionalClientScopes: ").Append(DefaultOptionalClientScopes).Append("\n");
          sb.Append("  BrowserSecurityHeaders: ").Append(BrowserSecurityHeaders).Append("\n");
          sb.Append("  SmtpServer: ").Append(SmtpServer).Append("\n");
          sb.Append("  UserFederationProviders: ").Append(UserFederationProviders).Append("\n");
          sb.Append("  UserFederationMappers: ").Append(UserFederationMappers).Append("\n");
          sb.Append("  LoginTheme: ").Append(LoginTheme).Append("\n");
          sb.Append("  AccountTheme: ").Append(AccountTheme).Append("\n");
          sb.Append("  AdminTheme: ").Append(AdminTheme).Append("\n");
          sb.Append("  EmailTheme: ").Append(EmailTheme).Append("\n");
          sb.Append("  EventsEnabled: ").Append(EventsEnabled).Append("\n");
          sb.Append("  EventsExpiration: ").Append(EventsExpiration).Append("\n");
          sb.Append("  EventsListeners: ").Append(EventsListeners).Append("\n");
          sb.Append("  EnabledEventTypes: ").Append(EnabledEventTypes).Append("\n");
          sb.Append("  AdminEventsEnabled: ").Append(AdminEventsEnabled).Append("\n");
          sb.Append("  AdminEventsDetailsEnabled: ").Append(AdminEventsDetailsEnabled).Append("\n");
          sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
          sb.Append("  IdentityProviderMappers: ").Append(IdentityProviderMappers).Append("\n");
          sb.Append("  ProtocolMappers: ").Append(ProtocolMappers).Append("\n");
          sb.Append("  Components: ").Append(Components).Append("\n");
          sb.Append("  InternationalizationEnabled: ").Append(InternationalizationEnabled).Append("\n");
          sb.Append("  SupportedLocales: ").Append(SupportedLocales).Append("\n");
          sb.Append("  DefaultLocale: ").Append(DefaultLocale).Append("\n");
          sb.Append("  AuthenticationFlows: ").Append(AuthenticationFlows).Append("\n");
          sb.Append("  AuthenticatorConfig: ").Append(AuthenticatorConfig).Append("\n");
          sb.Append("  RequiredActions: ").Append(RequiredActions).Append("\n");
          sb.Append("  BrowserFlow: ").Append(BrowserFlow).Append("\n");
          sb.Append("  RegistrationFlow: ").Append(RegistrationFlow).Append("\n");
          sb.Append("  DirectGrantFlow: ").Append(DirectGrantFlow).Append("\n");
          sb.Append("  ResetCredentialsFlow: ").Append(ResetCredentialsFlow).Append("\n");
          sb.Append("  ClientAuthenticationFlow: ").Append(ClientAuthenticationFlow).Append("\n");
          sb.Append("  DockerAuthenticationFlow: ").Append(DockerAuthenticationFlow).Append("\n");
          sb.Append("  Attributes: ").Append(Attributes).Append("\n");
          sb.Append("  KeycloakVersion: ").Append(KeycloakVersion).Append("\n");
          sb.Append("  UserManagedAccessAllowed: ").Append(UserManagedAccessAllowed).Append("\n");
          sb.Append("  Social: ").Append(Social).Append("\n");
          sb.Append("  UpdateProfileOnInitialSocialLogin: ").Append(UpdateProfileOnInitialSocialLogin).Append("\n");
          sb.Append("  SocialProviders: ").Append(SocialProviders).Append("\n");
          sb.Append("  ApplicationScopeMappings: ").Append(ApplicationScopeMappings).Append("\n");
          sb.Append("  Applications: ").Append(Applications).Append("\n");
          sb.Append("  OauthClients: ").Append(OauthClients).Append("\n");
          sb.Append("  ClientTemplates: ").Append(ClientTemplates).Append("\n");
          sb.Append("  OAuth2DeviceCodeLifespan: ").Append(OAuth2DeviceCodeLifespan).Append("\n");
          sb.Append("  OAuth2DevicePollingInterval: ").Append(OAuth2DevicePollingInterval).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}