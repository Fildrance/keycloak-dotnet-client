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
  public class PathCacheConfig {
    /// <summary>
    /// Gets or Sets MaxEntries
    /// </summary>
    [DataMember(Name="max-entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max-entries")]
    public int? MaxEntries { get; set; }

    /// <summary>
    /// Gets or Sets Lifespan
    /// </summary>
    [DataMember(Name="lifespan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lifespan")]
    public long? Lifespan { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PathCacheConfig {\n");
      sb.Append("  MaxEntries: ").Append(MaxEntries).Append("\n");
      sb.Append("  Lifespan: ").Append(Lifespan).Append("\n");
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
