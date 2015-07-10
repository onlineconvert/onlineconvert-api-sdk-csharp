using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IConversionApi {
    
    /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<Conversion></returns>
    List<Conversion> JobsJobIdConversionsGet (string Token, string Key, string JobId);

    /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<Conversion></returns>
    Task<List<Conversion>> JobsJobIdConversionsGetAsync (string Token, string Key, string JobId);
    
    /// <summary>
    /// Adds a new conversion to the given job. 
    /// </summary>
    /// <param name="Body">information for the conversion.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Conversion</returns>
    Conversion JobsJobIdConversionsPost (Conversion Body, string Token, string Key, string JobId);

    /// <summary>
    /// Adds a new conversion to the given job. 
    /// </summary>
    /// <param name="Body">information for the conversion.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Conversion</returns>
    Task<Conversion> JobsJobIdConversionsPostAsync (Conversion Body, string Token, string Key, string JobId);
    
    /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="ConversionId">Identifier for the job conversion.</param>
    /// <returns>Conversion</returns>
    Conversion JobsJobIdConversionsConversionIdGet (string Token, string Key, string JobId, string ConversionId);

    /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="ConversionId">Identifier for the job conversion.</param>
    /// <returns>Conversion</returns>
    Task<Conversion> JobsJobIdConversionsConversionIdGetAsync (string Token, string Key, string JobId, string ConversionId);
    
    /// <summary>
    /// Removes the conversion for a job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="ConversionId">Identifier for the job conversion.</param>
    /// <returns>Conversion</returns>
    Conversion JobsJobIdConversionsConversionIdDelete (string Token, string Key, string JobId, string ConversionId);

    /// <summary>
    /// Removes the conversion for a job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="ConversionId">Identifier for the job conversion.</param>
    /// <returns>Conversion</returns>
    Task<Conversion> JobsJobIdConversionsConversionIdDeleteAsync (string Token, string Key, string JobId, string ConversionId);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class ConversionApi : IConversionApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversionApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public ConversionApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversionApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ConversionApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<Conversion></returns>
    public List<Conversion> JobsJobIdConversionsGet (string Token, string Key, string JobId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdConversionsGet");
      

      var path = "/jobs/{job_id}/conversions";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdConversionsGet: " + response.Content, response.Content);
      }
      return (List<Conversion>) apiClient.Deserialize(response.Content, typeof(List<Conversion>));
    }
	
	 /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<Conversion></returns>
    public async Task<List<Conversion>> JobsJobIdConversionsGetAsync (string Token, string Key, string JobId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdConversionsGet");
      

      var path = "/jobs/{job_id}/conversions";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdConversionsGet: " + response.Content, response.Content);
      }
      return (List<Conversion>) apiClient.Deserialize(response.Content, typeof(List<Conversion>));
    }
    
    /// <summary>
    /// Adds a new conversion to the given job. 
    /// </summary>
    /// <param name="Body">information for the conversion.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Conversion</returns>
    public Conversion JobsJobIdConversionsPost (Conversion Body, string Token, string Key, string JobId) {

      
      // verify the required parameter 'Body' is set
      if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling JobsJobIdConversionsPost");
      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdConversionsPost");
      

      var path = "/jobs/{job_id}/conversions";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdConversionsPost: " + response.Content, response.Content);
      }
      return (Conversion) apiClient.Deserialize(response.Content, typeof(Conversion));
    }
	
	 /// <summary>
    /// Adds a new conversion to the given job. 
    /// </summary>
    /// <param name="Body">information for the conversion.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Conversion</returns>
    public async Task<Conversion> JobsJobIdConversionsPostAsync (Conversion Body, string Token, string Key, string JobId) {

      
          // verify the required parameter 'Body' is set
          if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling JobsJobIdConversionsPost");
      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdConversionsPost");
      

      var path = "/jobs/{job_id}/conversions";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdConversionsPost: " + response.Content, response.Content);
      }
      return (Conversion) apiClient.Deserialize(response.Content, typeof(Conversion));
    }
    
    /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="ConversionId">Identifier for the job conversion.</param>
    /// <returns>Conversion</returns>
    public Conversion JobsJobIdConversionsConversionIdGet (string Token, string Key, string JobId, string ConversionId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdConversionsConversionIdGet");
      
      // verify the required parameter 'ConversionId' is set
      if (ConversionId == null) throw new ApiException(400, "Missing required parameter 'ConversionId' when calling JobsJobIdConversionsConversionIdGet");
      

      var path = "/jobs/{job_id}/conversions/{conversion_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "conversion_id" + "}", apiClient.ParameterToString(ConversionId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdConversionsConversionIdGet: " + response.Content, response.Content);
      }
      return (Conversion) apiClient.Deserialize(response.Content, typeof(Conversion));
    }
	
	 /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="ConversionId">Identifier for the job conversion.</param>
    /// <returns>Conversion</returns>
    public async Task<Conversion> JobsJobIdConversionsConversionIdGetAsync (string Token, string Key, string JobId, string ConversionId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdConversionsConversionIdGet");
      
          // verify the required parameter 'ConversionId' is set
          if (ConversionId == null) throw new ApiException(400, "Missing required parameter 'ConversionId' when calling JobsJobIdConversionsConversionIdGet");
      

      var path = "/jobs/{job_id}/conversions/{conversion_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "conversion_id" + "}", apiClient.ParameterToString(ConversionId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdConversionsConversionIdGet: " + response.Content, response.Content);
      }
      return (Conversion) apiClient.Deserialize(response.Content, typeof(Conversion));
    }
    
    /// <summary>
    /// Removes the conversion for a job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="ConversionId">Identifier for the job conversion.</param>
    /// <returns>Conversion</returns>
    public Conversion JobsJobIdConversionsConversionIdDelete (string Token, string Key, string JobId, string ConversionId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdConversionsConversionIdDelete");
      
      // verify the required parameter 'ConversionId' is set
      if (ConversionId == null) throw new ApiException(400, "Missing required parameter 'ConversionId' when calling JobsJobIdConversionsConversionIdDelete");
      

      var path = "/jobs/{job_id}/conversions/{conversion_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "conversion_id" + "}", apiClient.ParameterToString(ConversionId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdConversionsConversionIdDelete: " + response.Content, response.Content);
      }
      return (Conversion) apiClient.Deserialize(response.Content, typeof(Conversion));
    }
	
	 /// <summary>
    /// Removes the conversion for a job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="ConversionId">Identifier for the job conversion.</param>
    /// <returns>Conversion</returns>
    public async Task<Conversion> JobsJobIdConversionsConversionIdDeleteAsync (string Token, string Key, string JobId, string ConversionId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdConversionsConversionIdDelete");
      
          // verify the required parameter 'ConversionId' is set
          if (ConversionId == null) throw new ApiException(400, "Missing required parameter 'ConversionId' when calling JobsJobIdConversionsConversionIdDelete");
      

      var path = "/jobs/{job_id}/conversions/{conversion_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "conversion_id" + "}", apiClient.ParameterToString(ConversionId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdConversionsConversionIdDelete: " + response.Content, response.Content);
      }
      return (Conversion) apiClient.Deserialize(response.Content, typeof(Conversion));
    }
    
  }  
  
}
