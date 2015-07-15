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
  public class Job {
    
    /* Unique identifier for the job. */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /* Token to identify client allowed to run the job. */
    [DataMember(Name="token", EmitDefaultValue=false)]
    public string Token { get; set; }

    
    /* Type of the job created. */
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /* Current status for the job */
    [DataMember(Name="status", EmitDefaultValue=false)]
    public Status Status { get; set; }

    
    /* Determine if the job must be processed as soon as it is ready. */
    [DataMember(Name="process", EmitDefaultValue=false)]
    public bool? Process { get; set; }

    
    /* Type of conversion or conversions to be carried out. */
    [DataMember(Name="conversion", EmitDefaultValue=false)]
    public List<Conversion> Conversion { get; set; }

    
    /* Source or sources of the files to be converted. */
    [DataMember(Name="input", EmitDefaultValue=false)]
    public List<InputFile> Input { get; set; }

    
    /* Callback url to the the status updates */
    [DataMember(Name="callback", EmitDefaultValue=false)]
    public string Callback { get; set; }

    
    /* Server assigned for file uploads and downloads */
    [DataMember(Name="server", EmitDefaultValue=false)]
    public string Server { get; set; }

    
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
      sb.Append("class Job {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Token: ").Append(Token).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  Process: ").Append(Process).Append("\n");
      
      sb.Append("  Conversion: ").Append(Conversion).Append("\n");
      
      sb.Append("  Input: ").Append(Input).Append("\n");
      
      sb.Append("  Callback: ").Append(Callback).Append("\n");
      
      sb.Append("  Server: ").Append(Server).Append("\n");
      
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
