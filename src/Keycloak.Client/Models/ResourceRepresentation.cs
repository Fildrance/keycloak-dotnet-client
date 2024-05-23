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
    public partial class ResourceRepresentation 
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
        /// Gets or Sets Uris
        /// </summary>
        [JsonPropertyName("uris")]
        public List<string> Uris { get; set; }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        
        /// <summary>
        /// Gets or Sets Scopes
        /// </summary>
        [JsonPropertyName("scopes")]
        public List<ScopeRepresentation> Scopes { get; set; }
        
        /// <summary>
        /// Gets or Sets IconUri
        /// </summary>
        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
        
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [JsonPropertyName("owner")]
        public ResourceRepresentationOwner Owner { get; set; }
        
        /// <summary>
        /// Gets or Sets OwnerManagedAccess
        /// </summary>
        [JsonPropertyName("ownerManagedAccess")]
        public bool? OwnerManagedAccess { get; set; }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public Dictionary<string, ArrayList> Attributes { get; set; }
        
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        
        /// <summary>
        /// Gets or Sets ScopesUma
        /// </summary>
        [JsonPropertyName("scopesUma")]
        public List<ScopeRepresentation> ScopesUma { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ResourceRepresentation {\n");
          sb.Append("  Id: ").Append(Id).Append("\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  Uris: ").Append(Uris).Append("\n");
          sb.Append("  Type: ").Append(Type).Append("\n");
          sb.Append("  Scopes: ").Append(Scopes).Append("\n");
          sb.Append("  IconUri: ").Append(IconUri).Append("\n");
          sb.Append("  Owner: ").Append(Owner).Append("\n");
          sb.Append("  OwnerManagedAccess: ").Append(OwnerManagedAccess).Append("\n");
          sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
          sb.Append("  Attributes: ").Append(Attributes).Append("\n");
          sb.Append("  Uri: ").Append(Uri).Append("\n");
          sb.Append("  ScopesUma: ").Append(ScopesUma).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}