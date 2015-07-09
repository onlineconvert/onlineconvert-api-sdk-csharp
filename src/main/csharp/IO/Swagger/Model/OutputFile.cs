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
  public class OutputFile {
    
    /* Unique identifier for the file. */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /* Sources for the files including the input files and conversion used. */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public Object Source { get; set; }

    
    /* Url for downloading the file. */
    [DataMember(Name="uri", EmitDefaultValue=false)]
    public string Uri { get; set; }

    
    /* Filename of the file. */
    [DataMember(Name="filename", EmitDefaultValue=false)]
    public string Filename { get; set; }

    
    /* Size of the file in bytes. */
    [DataMember(Name="size", EmitDefaultValue=false)]
    public int? Size { get; set; }

    
    /* Date and time when the job was created. */
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    public DateTime? CreatedAt { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OutputFile {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Uri: ").Append(Uri).Append("\n");
      
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      
      sb.Append("  Size: ").Append(Size).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
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
