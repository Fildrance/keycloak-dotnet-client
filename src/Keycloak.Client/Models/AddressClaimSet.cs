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
    public partial class AddressClaimSet 
    {
        /// <summary>
        /// Gets or Sets Formatted
        /// </summary>
        [JsonPropertyName("formatted")]
        public string Formatted { get; set; }
        
        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [JsonPropertyName("street_address")]
        public string StreetAddress { get; set; }
        
        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        [JsonPropertyName("locality")]
        public string Locality { get; set; }
        
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }
        
        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }
        
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AddressClaimSet {\n");
          sb.Append("  Formatted: ").Append(Formatted).Append("\n");
          sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
          sb.Append("  Locality: ").Append(Locality).Append("\n");
          sb.Append("  Region: ").Append(Region).Append("\n");
          sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
          sb.Append("  Country: ").Append(Country).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}