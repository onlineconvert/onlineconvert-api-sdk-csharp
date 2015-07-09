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
  public class Thread {
    
    /* Unique identifier of the thread. */
    [DataMember(Name="hash", EmitDefaultValue=false)]
    public string Hash { get; set; }

    
    /* Status of the thread. */
    [DataMember(Name="status", EmitDefaultValue=false)]
    public int? Status { get; set; }

    
    /* Extra information. */
    [DataMember(Name="info", EmitDefaultValue=false)]
    public string Info { get; set; }

    
    /* Date and time when the job was created. */
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    public DateTime? CreatedAt { get; set; }

    
    /* Date and time when the job was last modified. */
    [DataMember(Name="modified_at", EmitDefaultValue=false)]
    public DateTime? ModifiedAt { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Thread {\n");
      
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  Info: ").Append(Info).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
      
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
