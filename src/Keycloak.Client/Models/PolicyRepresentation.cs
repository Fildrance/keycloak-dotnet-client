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
    public partial class PolicyRepresentation 
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
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        
        /// <summary>
        /// Gets or Sets Policies
        /// </summary>
        [JsonPropertyName("policies")]
        public List<string> Policies { get; set; }
        
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [JsonPropertyName("resources")]
        public List<string> Resources { get; set; }
        
        /// <summary>
        /// Gets or Sets Scopes
        /// </summary>
        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; set; }
        
        /// <summary>
        /// Gets or Sets Logic
        /// </summary>
        [JsonPropertyName("logic")]
        public Logic Logic { get; set; }
        
        /// <summary>
        /// Gets or Sets DecisionStrategy
        /// </summary>
        [JsonPropertyName("decisionStrategy")]
        public DecisionStrategy DecisionStrategy { get; set; }
        
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; }
        
        /// <summary>
        /// Gets or Sets ResourcesData
        /// </summary>
        [JsonPropertyName("resourcesData")]
        public List<ResourceRepresentation> ResourcesData { get; set; }
        
        /// <summary>
        /// Gets or Sets ScopesData
        /// </summary>
        [JsonPropertyName("scopesData")]
        public List<ScopeRepresentation> ScopesData { get; set; }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonPropertyName("config")]
        public Dictionary<string, string> Config { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PolicyRepresentation {\n");
          sb.Append("  Id: ").Append(Id).Append("\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  Description: ").Append(Description).Append("\n");
          sb.Append("  Type: ").Append(Type).Append("\n");
          sb.Append("  Policies: ").Append(Policies).Append("\n");
          sb.Append("  Resources: ").Append(Resources).Append("\n");
          sb.Append("  Scopes: ").Append(Scopes).Append("\n");
          sb.Append("  Logic: ").Append(Logic).Append("\n");
          sb.Append("  DecisionStrategy: ").Append(DecisionStrategy).Append("\n");
          sb.Append("  Owner: ").Append(Owner).Append("\n");
          sb.Append("  ResourcesData: ").Append(ResourcesData).Append("\n");
          sb.Append("  ScopesData: ").Append(ScopesData).Append("\n");
          sb.Append("  Config: ").Append(Config).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}