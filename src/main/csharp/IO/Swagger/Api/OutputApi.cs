using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IOutputApi {
    
    /// <summary>
    /// Get list of converted. 
    /// </summary>
    /// <param name="ConversionId"></param>/// <param name="InputId"></param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<OutputFile></returns>
    List<OutputFile> JobsJobIdOutputGet (string ConversionId, string InputId, string Token, string Key, string JobId);

    /// <summary>
    /// Get list of converted. 
    /// </summary>
    /// <param name="ConversionId"></param>/// <param name="InputId"></param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<OutputFile></returns>
    Task<List<OutputFile>> JobsJobIdOutputGetAsync (string ConversionId, string InputId, string Token, string Key, string JobId);
    
    /// <summary>
    /// Get information about an output file source. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>List<OutputFile></returns>
    List<OutputFile> JobsJobIdOutputFileIdGet (string Token, string Key, string JobId, string FileId);

    /// <summary>
    /// Get information about an output file source. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>List<OutputFile></returns>
    Task<List<OutputFile>> JobsJobIdOutputFileIdGetAsync (string Token, string Key, string JobId, string FileId);
    
    /// <summary>
    /// Deletes a file from the output. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>List<OutputFile></returns>
    List<OutputFile> JobsJobIdOutputFileIdDelete (string Token, string Key, string JobId, string FileId);

    /// <summary>
    /// Deletes a file from the output. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>List<OutputFile></returns>
    Task<List<OutputFile>> JobsJobIdOutputFileIdDeleteAsync (string Token, string Key, string JobId, string FileId);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class OutputApi : IOutputApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="OutputApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public OutputApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OutputApi"/> class.
    /// </summary>
    /// <returns></returns>
    public OutputApi(String basePath)
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
    /// Get list of converted. 
    /// </summary>
    /// <param name="ConversionId"></param>/// <param name="InputId"></param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<OutputFile></returns>
    public List<OutputFile> JobsJobIdOutputGet (string ConversionId, string InputId, string Token, string Key, string JobId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdOutputGet");
      

      var path = "/jobs/{job_id}/output";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (ConversionId != null) queryParams.Add("conversion_id", apiClient.ParameterToString(ConversionId)); // query parameter
       if (InputId != null) queryParams.Add("input_id", apiClient.ParameterToString(InputId)); // query parameter
       if (Key != null) queryParams.Add("key", apiClient.ParameterToString(Key)); // query parameter
      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdOutputGet: " + response.Content, response.Content);
      }
      return (List<OutputFile>) apiClient.Deserialize(response.Content, typeof(List<OutputFile>));
    }
	
	 /// <summary>
    /// Get list of converted. 
    /// </summary>
    /// <param name="ConversionId"></param>/// <param name="InputId"></param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<OutputFile></returns>
    public async Task<List<OutputFile>> JobsJobIdOutputGetAsync (string ConversionId, string InputId, string Token, string Key, string JobId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdOutputGet");
      

      var path = "/jobs/{job_id}/output";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (ConversionId != null) queryParams.Add("conversion_id", apiClient.ParameterToString(ConversionId)); // query parameter
       if (InputId != null) queryParams.Add("input_id", apiClient.ParameterToString(InputId)); // query parameter
       if (Key != null) queryParams.Add("key", apiClient.ParameterToString(Key)); // query parameter
      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdOutputGet: " + response.Content, response.Content);
      }
      return (List<OutputFile>) apiClient.Deserialize(response.Content, typeof(List<OutputFile>));
    }
    
    /// <summary>
    /// Get information about an output file source. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>List<OutputFile></returns>
    public List<OutputFile> JobsJobIdOutputFileIdGet (string Token, string Key, string JobId, string FileId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdOutputFileIdGet");
      
      // verify the required parameter 'FileId' is set
      if (FileId == null) throw new ApiException(400, "Missing required parameter 'FileId' when calling JobsJobIdOutputFileIdGet");
      

      var path = "/jobs/{job_id}/output/{file_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "file_id" + "}", apiClient.ParameterToString(FileId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Key != null) queryParams.Add("key", apiClient.ParameterToString(Key)); // query parameter
      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdOutputFileIdGet: " + response.Content, response.Content);
      }
      return (List<OutputFile>) apiClient.Deserialize(response.Content, typeof(List<OutputFile>));
    }
	
	 /// <summary>
    /// Get information about an output file source. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>List<OutputFile></returns>
    public async Task<List<OutputFile>> JobsJobIdOutputFileIdGetAsync (string Token, string Key, string JobId, string FileId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdOutputFileIdGet");
      
          // verify the required parameter 'FileId' is set
          if (FileId == null) throw new ApiException(400, "Missing required parameter 'FileId' when calling JobsJobIdOutputFileIdGet");
      

      var path = "/jobs/{job_id}/output/{file_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "file_id" + "}", apiClient.ParameterToString(FileId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Key != null) queryParams.Add("key", apiClient.ParameterToString(Key)); // query parameter
      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdOutputFileIdGet: " + response.Content, response.Content);
      }
      return (List<OutputFile>) apiClient.Deserialize(response.Content, typeof(List<OutputFile>));
    }
    
    /// <summary>
    /// Deletes a file from the output. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>List<OutputFile></returns>
    public List<OutputFile> JobsJobIdOutputFileIdDelete (string Token, string Key, string JobId, string FileId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdOutputFileIdDelete");
      
      // verify the required parameter 'FileId' is set
      if (FileId == null) throw new ApiException(400, "Missing required parameter 'FileId' when calling JobsJobIdOutputFileIdDelete");
      

      var path = "/jobs/{job_id}/output/{file_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "file_id" + "}", apiClient.ParameterToString(FileId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Key != null) queryParams.Add("key", apiClient.ParameterToString(Key)); // query parameter
      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdOutputFileIdDelete: " + response.Content, response.Content);
      }
      return (List<OutputFile>) apiClient.Deserialize(response.Content, typeof(List<OutputFile>));
    }
	
	 /// <summary>
    /// Deletes a file from the output. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>/// <param name="FileId">Id of the file to download</param>
    /// <returns>List<OutputFile></returns>
    public async Task<List<OutputFile>> JobsJobIdOutputFileIdDeleteAsync (string Token, string Key, string JobId, string FileId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdOutputFileIdDelete");
      
          // verify the required parameter 'FileId' is set
          if (FileId == null) throw new ApiException(400, "Missing required parameter 'FileId' when calling JobsJobIdOutputFileIdDelete");
      

      var path = "/jobs/{job_id}/output/{file_id}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "job_id" + "}", apiClient.ParameterToString(JobId));
      path = path.Replace("{" + "file_id" + "}", apiClient.ParameterToString(FileId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Key != null) queryParams.Add("key", apiClient.ParameterToString(Key)); // query parameter
      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdOutputFileIdDelete: " + response.Content, response.Content);
      }
      return (List<OutputFile>) apiClient.Deserialize(response.Content, typeof(List<OutputFile>));
    }
    
  }  
  
}
