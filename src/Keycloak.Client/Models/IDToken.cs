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
public partial class IDToken 
{
    /// <summary>
    /// Gets or Sets Jti
    /// </summary>
    [JsonPropertyName("jti")]
    public string Jti { get; set; }
    
    /// <summary>
    /// Gets or Sets Exp
    /// </summary>
    [JsonPropertyName("exp")]
    public long? Exp { get; set; }
    
    /// <summary>
    /// Gets or Sets Nbf
    /// </summary>
    [JsonPropertyName("nbf")]
    public long? Nbf { get; set; }
    
    /// <summary>
    /// Gets or Sets Iat
    /// </summary>
    [JsonPropertyName("iat")]
    public long? Iat { get; set; }
    
    /// <summary>
    /// Gets or Sets Iss
    /// </summary>
    [JsonPropertyName("iss")]
    public string Iss { get; set; }
    
    /// <summary>
    /// Gets or Sets Sub
    /// </summary>
    [JsonPropertyName("sub")]
    public string Sub { get; set; }
    
    /// <summary>
    /// Gets or Sets Typ
    /// </summary>
    [JsonPropertyName("typ")]
    public string Typ { get; set; }
    
    /// <summary>
    /// Gets or Sets Azp
    /// </summary>
    [JsonPropertyName("azp")]
    public string Azp { get; set; }
    
    /// <summary>
    /// Gets or Sets OtherClaims
    /// </summary>
    [JsonPropertyName("otherClaims")]
    public Dictionary<string, Object> OtherClaims { get; set; }
    
    /// <summary>
    /// Gets or Sets Nonce
    /// </summary>
    [JsonPropertyName("nonce")]
    public string Nonce { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthTime
    /// </summary>
    [JsonPropertyName("auth_time")]
    public long? AuthTimeLong { get; set; }
    
    /// <summary>
    /// Gets or Sets SessionState
    /// </summary>
    [JsonPropertyName("session_state")]
    public string SessionState { get; set; }
    
    /// <summary>
    /// Gets or Sets AtHash
    /// </summary>
    [JsonPropertyName("at_hash")]
    public string AtHash { get; set; }
    
    /// <summary>
    /// Gets or Sets CHash
    /// </summary>
    [JsonPropertyName("c_hash")]
    public string CHash { get; set; }
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets GivenName
    /// </summary>
    [JsonPropertyName("given_name")]
    public string GivenName { get; set; }
    
    /// <summary>
    /// Gets or Sets FamilyName
    /// </summary>
    [JsonPropertyName("family_name")]
    public string FamilyName { get; set; }
    
    /// <summary>
    /// Gets or Sets MiddleName
    /// </summary>
    [JsonPropertyName("middle_name")]
    public string MiddleName { get; set; }
    
    /// <summary>
    /// Gets or Sets Nickname
    /// </summary>
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; }
    
    /// <summary>
    /// Gets or Sets PreferredUsername
    /// </summary>
    [JsonPropertyName("preferred_username")]
    public string PreferredUsername { get; set; }
    
    /// <summary>
    /// Gets or Sets Profile
    /// </summary>
    [JsonPropertyName("profile")]
    public string Profile { get; set; }
    
    /// <summary>
    /// Gets or Sets Picture
    /// </summary>
    [JsonPropertyName("picture")]
    public string Picture { get; set; }
    
    /// <summary>
    /// Gets or Sets Website
    /// </summary>
    [JsonPropertyName("website")]
    public string Website { get; set; }
    
    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }
    
    /// <summary>
    /// Gets or Sets EmailVerified
    /// </summary>
    [JsonPropertyName("email_verified")]
    public bool? EmailVerified { get; set; }
    
    /// <summary>
    /// Gets or Sets Gender
    /// </summary>
    [JsonPropertyName("gender")]
    public string Gender { get; set; }
    
    /// <summary>
    /// Gets or Sets Birthdate
    /// </summary>
    [JsonPropertyName("birthdate")]
    public string Birthdate { get; set; }
    
    /// <summary>
    /// Gets or Sets Zoneinfo
    /// </summary>
    [JsonPropertyName("zoneinfo")]
    public string Zoneinfo { get; set; }
    
    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [JsonPropertyName("locale")]
    public string Locale { get; set; }
    
    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Gets or Sets PhoneNumberVerified
    /// </summary>
    [JsonPropertyName("phone_number_verified")]
    public bool? PhoneNumberVerified { get; set; }
    
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [JsonPropertyName("address")]
    public AddressClaimSet Address { get; set; }
    
    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [JsonPropertyName("updated_at")]
    public long? UpdatedAt { get; set; }
    
    /// <summary>
    /// Gets or Sets ClaimsLocales
    /// </summary>
    [JsonPropertyName("claims_locales")]
    public string ClaimsLocales { get; set; }
    
    /// <summary>
    /// Gets or Sets Acr
    /// </summary>
    [JsonPropertyName("acr")]
    public string Acr { get; set; }
    
    /// <summary>
    /// Gets or Sets SHash
    /// </summary>
    [JsonPropertyName("s_hash")]
    public string SHash { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthTime
    /// </summary>
    [JsonPropertyName("authTime")]
    public int? AuthTime { get; set; }
    
    /// <summary>
    /// Gets or Sets Sid
    /// </summary>
    [JsonPropertyName("sid")]
    public string Sid { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class IDToken {\n");
      sb.Append("  Jti: ").Append(Jti).Append("\n");
      sb.Append("  Exp: ").Append(Exp).Append("\n");
      sb.Append("  Nbf: ").Append(Nbf).Append("\n");
      sb.Append("  Iat: ").Append(Iat).Append("\n");
      sb.Append("  Iss: ").Append(Iss).Append("\n");
      sb.Append("  Sub: ").Append(Sub).Append("\n");
      sb.Append("  Typ: ").Append(Typ).Append("\n");
      sb.Append("  Azp: ").Append(Azp).Append("\n");
      sb.Append("  OtherClaims: ").Append(OtherClaims).Append("\n");
      sb.Append("  Nonce: ").Append(Nonce).Append("\n");
      sb.Append("  AuthTime: ").Append(AuthTime).Append("\n");
      sb.Append("  SessionState: ").Append(SessionState).Append("\n");
      sb.Append("  AtHash: ").Append(AtHash).Append("\n");
      sb.Append("  CHash: ").Append(CHash).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  GivenName: ").Append(GivenName).Append("\n");
      sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
      sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
      sb.Append("  Nickname: ").Append(Nickname).Append("\n");
      sb.Append("  PreferredUsername: ").Append(PreferredUsername).Append("\n");
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      sb.Append("  Picture: ").Append(Picture).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Birthdate: ").Append(Birthdate).Append("\n");
      sb.Append("  Zoneinfo: ").Append(Zoneinfo).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  PhoneNumberVerified: ").Append(PhoneNumberVerified).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ClaimsLocales: ").Append(ClaimsLocales).Append("\n");
      sb.Append("  Acr: ").Append(Acr).Append("\n");
      sb.Append("  SHash: ").Append(SHash).Append("\n");
      sb.Append("  AuthTimeLong: ").Append(AuthTimeLong).Append("\n");
      sb.Append("  Sid: ").Append(Sid).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
