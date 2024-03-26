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
  public class ClaimRepresentation {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public bool? Name { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public bool? Username { get; set; }

    /// <summary>
    /// Gets or Sets Profile
    /// </summary>
    [DataMember(Name="profile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile")]
    public bool? Profile { get; set; }

    /// <summary>
    /// Gets or Sets Picture
    /// </summary>
    [DataMember(Name="picture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "picture")]
    public bool? Picture { get; set; }

    /// <summary>
    /// Gets or Sets Website
    /// </summary>
    [DataMember(Name="website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "website")]
    public bool? Website { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public bool? Email { get; set; }

    /// <summary>
    /// Gets or Sets Gender
    /// </summary>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public bool? Gender { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public bool? Locale { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public bool? Address { get; set; }

    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public bool? Phone { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClaimRepresentation {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      sb.Append("  Picture: ").Append(Picture).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
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
