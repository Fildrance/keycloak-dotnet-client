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
    public partial class UserFederationProviderRepresentation 
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        
        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [JsonPropertyName("providerName")]
        public string ProviderName { get; set; }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonPropertyName("config")]
        public Dictionary<string, string> Config { get; set; }
        
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }
        
        /// <summary>
        /// Gets or Sets FullSyncPeriod
        /// </summary>
        [JsonPropertyName("fullSyncPeriod")]
        public int? FullSyncPeriod { get; set; }
        
        /// <summary>
        /// Gets or Sets ChangedSyncPeriod
        /// </summary>
        [JsonPropertyName("changedSyncPeriod")]
        public int? ChangedSyncPeriod { get; set; }
        
        /// <summary>
        /// Gets or Sets LastSync
        /// </summary>
        [JsonPropertyName("lastSync")]
        public int? LastSync { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class UserFederationProviderRepresentation {\n");
          sb.Append("  Id: ").Append(Id).Append("\n");
          sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
          sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
          sb.Append("  Config: ").Append(Config).Append("\n");
          sb.Append("  Priority: ").Append(Priority).Append("\n");
          sb.Append("  FullSyncPeriod: ").Append(FullSyncPeriod).Append("\n");
          sb.Append("  ChangedSyncPeriod: ").Append(ChangedSyncPeriod).Append("\n");
          sb.Append("  LastSync: ").Append(LastSync).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}