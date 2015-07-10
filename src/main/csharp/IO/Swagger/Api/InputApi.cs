using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IInputApi {
    
    /// <summary>
    /// Get list of binary source files for the conversion.hhh Description of the get for the inputs of a specific job.
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<InputFile></returns>
    List<InputFile> JobsJobIdInputGet (string Token, string Key, string JobId);

    /// <summary>
    /// Get list of binary source files for the conversion.hhh Description of the get for the inputs of a specific job.
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<InputFile></returns>
    Task<List<InputFile>> JobsJobIdInputGetAsync (string Token, string Key, string JobId);
    
    /// <summary>
    /// Cretes a new input for the current job. 
    /// </summary>
    /// <param name="Body"></param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>InputFile</returns>
    InputFile JobsJobIdInputPost (InputFile Body, string Token, string Key, string JobId);

    /// <summary>
    /// Cretes a new input for the current job. 
    /// </summary>
    /// <param name="Body"></param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>InputFile</returns>
    Task<InputFile> JobsJobIdInputPostAsync (InputFile Body, string Token, string Key, string JobId);
    
    /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>InputFile</returns>
    InputFile JobsJobIdInputFileIdGet (string Token, string Key, string JobId, string FileId);

    /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>InputFile</returns>
    Task<InputFile> JobsJobIdInputFileIdGetAsync (string Token, string Key, string JobId, string FileId);
    
    /// <summary>
    /// Removes the input for a job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>InputFile</returns>
    InputFile JobsJobIdInputFileIdDelete (string Token, string Key, string JobId, string FileId);

    /// <summary>
    /// Removes the input for a job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>InputFile</returns>
    Task<InputFile> JobsJobIdInputFileIdDeleteAsync (string Token, string Key, string JobId, string FileId);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class InputApi : IInputApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="InputApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public InputApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InputApi"/> class.
    /// </summary>
    /// <returns></returns>
    public InputApi(String basePath)
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
    /// Get list of binary source files for the conversion.hhh Description of the get for the inputs of a specific job.
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<InputFile></returns>
    public List<InputFile> JobsJobIdInputGet (string Token, string Key, string JobId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdInputGet");
      

      var path = "/jobs/{job_id}/input";
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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdInputGet: " + response.Content, response.Content);
      }
      return (List<InputFile>) apiClient.Deserialize(response.Content, typeof(List<InputFile>));
    }
	
	 /// <summary>
    /// Get list of binary source files for the conversion.hhh Description of the get for the inputs of a specific job.
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<InputFile></returns>
    public async Task<List<InputFile>> JobsJobIdInputGetAsync (string Token, string Key, string JobId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdInputGet");
      

      var path = "/jobs/{job_id}/input";
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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdInputGet: " + response.Content, response.Content);
      }
      return (List<InputFile>) apiClient.Deserialize(response.Content, typeof(List<InputFile>));
    }
    
    /// <summary>
    /// Cretes a new input for the current job. 
    /// </summary>
    /// <param name="Body"></param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>InputFile</returns>
    public InputFile JobsJobIdInputPost (InputFile Body, string Token, string Key, string JobId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdInputPost");
      

      var path = "/jobs/{job_id}/input";
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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdInputPost: " + response.Content, response.Content);
      }
      return (InputFile) apiClient.Deserialize(response.Content, typeof(InputFile));
    }
	
	 /// <summary>
    /// Cretes a new input for the current job. 
    /// </summary>
    /// <param name="Body"></param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>InputFile</returns>
    public async Task<InputFile> JobsJobIdInputPostAsync (InputFile Body, string Token, string Key, string JobId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdInputPost");
      

      var path = "/jobs/{job_id}/input";
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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdInputPost: " + response.Content, response.Content);
      }
      return (InputFile) apiClient.Deserialize(response.Content, typeof(InputFile));
    }
    
    /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>InputFile</returns>
    public InputFile JobsJobIdInputFileIdGet (string Token, string Key, string JobId, string FileId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdInputFileIdGet");
      
      // verify the required parameter 'FileId' is set
      if (FileId == null) throw new ApiException(400, "Missing required parameter 'FileId' when calling JobsJobIdInputFileIdGet");
      

      var path = "/jobs/{job_id}/input/{file_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "file_id" + "}", apiClient.ParameterToString(FileId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdInputFileIdGet: " + response.Content, response.Content);
      }
      return (InputFile) apiClient.Deserialize(response.Content, typeof(InputFile));
    }
	
	 /// <summary>
    /// Get list of conversions defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>InputFile</returns>
    public async Task<InputFile> JobsJobIdInputFileIdGetAsync (string Token, string Key, string JobId, string FileId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdInputFileIdGet");
      
          // verify the required parameter 'FileId' is set
          if (FileId == null) throw new ApiException(400, "Missing required parameter 'FileId' when calling JobsJobIdInputFileIdGet");
      

      var path = "/jobs/{job_id}/input/{file_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "file_id" + "}", apiClient.ParameterToString(FileId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdInputFileIdGet: " + response.Content, response.Content);
      }
      return (InputFile) apiClient.Deserialize(response.Content, typeof(InputFile));
    }
    
    /// <summary>
    /// Removes the input for a job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>InputFile</returns>
    public InputFile JobsJobIdInputFileIdDelete (string Token, string Key, string JobId, string FileId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdInputFileIdDelete");
      
      // verify the required parameter 'FileId' is set
      if (FileId == null) throw new ApiException(400, "Missing required parameter 'FileId' when calling JobsJobIdInputFileIdDelete");
      

      var path = "/jobs/{job_id}/input/{file_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "file_id" + "}", apiClient.ParameterToString(FileId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdInputFileIdDelete: " + response.Content, response.Content);
      }
      return (InputFile) apiClient.Deserialize(response.Content, typeof(InputFile));
    }
	
	 /// <summary>
    /// Removes the input for a job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>InputFile</returns>
    public async Task<InputFile> JobsJobIdInputFileIdDeleteAsync (string Token, string Key, string JobId, string FileId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdInputFileIdDelete");
      
          // verify the required parameter 'FileId' is set
          if (FileId == null) throw new ApiException(400, "Missing required parameter 'FileId' when calling JobsJobIdInputFileIdDelete");
      

      var path = "/jobs/{job_id}/input/{file_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "file_id" + "}", apiClient.ParameterToString(FileId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdInputFileIdDelete: " + response.Content, response.Content);
      }
      return (InputFile) apiClient.Deserialize(response.Content, typeof(InputFile));
    }
    
  }  
  
}
