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
  public class Conversion {
    
    /* Identifier for the job conversion. */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /* Identifier for the job conversion type. */
    [DataMember(Name="target", EmitDefaultValue=false)]
    public string Target { get; set; }

    
    /* Category for the conveted file. */
    [DataMember(Name="category", EmitDefaultValue=false)]
    public string Category { get; set; }

    
    /* Type of conversion to perform with the file. */
    [DataMember(Name="options", EmitDefaultValue=false)]
    public Object Options { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Conversion {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  Category: ").Append(Category).Append("\n");
      
      sb.Append("  Options: ").Append(Options).Append("\n");
      
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
