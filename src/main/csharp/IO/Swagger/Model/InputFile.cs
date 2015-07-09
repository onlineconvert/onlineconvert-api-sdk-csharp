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
  public class InputFile {
    
    /* Unique identifier for the file. */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /* How the file has been generated. */
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /* The source of the file to be used that can be either, an external url. An identifier for an uploaded file to the server or an identifier for another job. */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    /* Filename of the file. */
    [DataMember(Name="filename", EmitDefaultValue=false)]
    public string Filename { get; set; }

    
    /* Size of the file in bytes. */
    [DataMember(Name="size", EmitDefaultValue=false)]
    public int? Size { get; set; }

    
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
      sb.Append("class InputFile {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      
      sb.Append("  Size: ").Append(Size).Append("\n");
      
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
