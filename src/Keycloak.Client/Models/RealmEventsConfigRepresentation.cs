using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Swagger.Model;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class RealmEventsConfigRepresentation 
{
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class RealmEventsConfigRepresentation {\n");
      sb.Append("  EventsEnabled: ").Append(EventsEnabled).Append("\n");
      sb.Append("  EventsExpiration: ").Append(EventsExpiration).Append("\n");
      sb.Append("  EventsListeners: ").Append(EventsListeners).Append("\n");
      sb.Append("  EnabledEventTypes: ").Append(EnabledEventTypes).Append("\n");
      sb.Append("  AdminEventsEnabled: ").Append(AdminEventsEnabled).Append("\n");
      sb.Append("  AdminEventsDetailsEnabled: ").Append(AdminEventsDetailsEnabled).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
