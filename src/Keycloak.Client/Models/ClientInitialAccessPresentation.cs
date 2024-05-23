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
    public partial class ClientInitialAccessPresentation 
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
        
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }
        
        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [JsonPropertyName("expiration")]
        public int? Expiration { get; set; }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [JsonPropertyName("count")]
        public int? Count { get; set; }
        
        /// <summary>
        /// Gets or Sets RemainingCount
        /// </summary>
        [JsonPropertyName("remainingCount")]
        public int? RemainingCount { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ClientInitialAccessPresentation {\n");
          sb.Append("  Id: ").Append(Id).Append("\n");
          sb.Append("  Token: ").Append(Token).Append("\n");
          sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
          sb.Append("  Expiration: ").Append(Expiration).Append("\n");
          sb.Append("  Count: ").Append(Count).Append("\n");
          sb.Append("  RemainingCount: ").Append(RemainingCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}