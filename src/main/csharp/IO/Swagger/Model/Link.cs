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
  public class Link {
    
    
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    
    [DataMember(Name="uri", EmitDefaultValue=false)]
    public string Uri { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Link {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Uri: ").Append(Uri).Append("\n");
      
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
