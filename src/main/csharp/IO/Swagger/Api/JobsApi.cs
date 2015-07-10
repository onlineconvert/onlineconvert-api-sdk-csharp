using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IJobsApi {
    
    /// <summary>
    /// List of jobs active for the current user identified by the key. It will return the list of jobs for the given user. In order to get the jobs a key or token must be provided:\n  - If the user key is provided all jobs for the current will be return.\n  - If one token is provided it will return the job assigned to that token if any.\n  \nThe request is paginated with an amount of 50 elements per page in any case.\n
    /// </summary>
    /// <param name="Status">Filter the status of the job.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="Page">Pagination for list of elements.</param>
    /// <returns>List<Job></returns>
    List<Job> JobsGet (string Status, string Token, string Key, double? Page);

    /// <summary>
    /// List of jobs active for the current user identified by the key. It will return the list of jobs for the given user. In order to get the jobs a key or token must be provided:\n  - If the user key is provided all jobs for the current will be return.\n  - If one token is provided it will return the job assigned to that token if any.\n  \nThe request is paginated with an amount of 50 elements per page in any case.\n
    /// </summary>
    /// <param name="Status">Filter the status of the job.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="Page">Pagination for list of elements.</param>
    /// <returns>List<Job></returns>
    Task<List<Job>> JobsGetAsync (string Status, string Token, string Key, double? Page);
    
    /// <summary>
    /// Creates a new Job with the user key. 
    /// </summary>
    /// <param name="Key">Api key for the user to filter.</param>/// <param name="Body">Content of the job.</param>
    /// <returns>Job</returns>
    Job JobsPost (string Key, Job Body);

    /// <summary>
    /// Creates a new Job with the user key. 
    /// </summary>
    /// <param name="Key">Api key for the user to filter.</param>/// <param name="Body">Content of the job.</param>
    /// <returns>Job</returns>
    Task<Job> JobsPostAsync (string Key, Job Body);
    
    /// <summary>
    /// Get information about a Job 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    Job JobsJobIdGet (string Token, string Key, string JobId);

    /// <summary>
    /// Get information about a Job 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    Task<Job> JobsJobIdGetAsync (string Token, string Key, string JobId);
    
    /// <summary>
    /// Cancels a job created that haven&#39;t been started. (Allow to cancel jobs in process.) 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    Job JobsJobIdDelete (string Token, string Key, string JobId);

    /// <summary>
    /// Cancels a job created that haven&#39;t been started. (Allow to cancel jobs in process.) 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    Task<Job> JobsJobIdDeleteAsync (string Token, string Key, string JobId);
    
    /// <summary>
    /// Modifies the job identified by the id, allows to start a created job. 
    /// </summary>
    /// <param name="Body">Content of the job.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    Job JobsJobIdPatch (Job Body, string Token, string Key, string JobId);

    /// <summary>
    /// Modifies the job identified by the id, allows to start a created job. 
    /// </summary>
    /// <param name="Body">Content of the job.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    Task<Job> JobsJobIdPatchAsync (Job Body, string Token, string Key, string JobId);
    
    /// <summary>
    /// Get list of threads defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<Thread></returns>
    List<Thread> JobsJobIdThreadsGet (string Token, string Key, string JobId);

    /// <summary>
    /// Get list of threads defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<Thread></returns>
    Task<List<Thread>> JobsJobIdThreadsGetAsync (string Token, string Key, string JobId);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class JobsApi : IJobsApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="JobsApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public JobsApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JobsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public JobsApi(String basePath)
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
    /// List of jobs active for the current user identified by the key. It will return the list of jobs for the given user. In order to get the jobs a key or token must be provided:\n  - If the user key is provided all jobs for the current will be return.\n  - If one token is provided it will return the job assigned to that token if any.\n  \nThe request is paginated with an amount of 50 elements per page in any case.\n
    /// </summary>
    /// <param name="Status">Filter the status of the job.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="Page">Pagination for list of elements.</param>
    /// <returns>List<Job></returns>
    public List<Job> JobsGet (string Status, string Token, string Key, double? Page) {

      

      var path = "/jobs";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Status != null) queryParams.Add("status", apiClient.ParameterToString(Status)); // query parameter
       if (Page != null) queryParams.Add("page", apiClient.ParameterToString(Page)); // query parameter
      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsGet: " + response.Content, response.Content);
      }
      return (List<Job>) apiClient.Deserialize(response.Content, typeof(List<Job>));
    }
	
	 /// <summary>
    /// List of jobs active for the current user identified by the key. It will return the list of jobs for the given user. In order to get the jobs a key or token must be provided:\n  - If the user key is provided all jobs for the current will be return.\n  - If one token is provided it will return the job assigned to that token if any.\n  \nThe request is paginated with an amount of 50 elements per page in any case.\n
    /// </summary>
    /// <param name="Status">Filter the status of the job.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="Page">Pagination for list of elements.</param>
    /// <returns>List<Job></returns>
    public async Task<List<Job>> JobsGetAsync (string Status, string Token, string Key, double? Page) {

      

      var path = "/jobs";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Status != null) queryParams.Add("status", apiClient.ParameterToString(Status)); // query parameter
       if (Page != null) queryParams.Add("page", apiClient.ParameterToString(Page)); // query parameter
      
       if (Token != null) headerParams.Add("token", apiClient.ParameterToString(Token)); // header parameter
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsGet: " + response.Content, response.Content);
      }
      return (List<Job>) apiClient.Deserialize(response.Content, typeof(List<Job>));
    }
    
    /// <summary>
    /// Creates a new Job with the user key. 
    /// </summary>
    /// <param name="Key">Api key for the user to filter.</param>/// <param name="Body">Content of the job.</param>
    /// <returns>Job</returns>
    public Job JobsPost (string Key, Job Body) {

      
      // verify the required parameter 'Key' is set
      if (Key == null) throw new ApiException(400, "Missing required parameter 'Key' when calling JobsPost");
      
      // verify the required parameter 'Body' is set
      if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling JobsPost");
      

      var path = "/jobs";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsPost: " + response.Content, response.Content);
      }
      return (Job) apiClient.Deserialize(response.Content, typeof(Job));
    }
	
	 /// <summary>
    /// Creates a new Job with the user key. 
    /// </summary>
    /// <param name="Key">Api key for the user to filter.</param>/// <param name="Body">Content of the job.</param>
    /// <returns>Job</returns>
    public async Task<Job> JobsPostAsync (string Key, Job Body) {

      
          // verify the required parameter 'Key' is set
          if (Key == null) throw new ApiException(400, "Missing required parameter 'Key' when calling JobsPost");
      
          // verify the required parameter 'Body' is set
          if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling JobsPost");
      

      var path = "/jobs";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
       if (Key != null) headerParams.Add("key", apiClient.ParameterToString(Key)); // header parameter
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsPost: " + response.Content, response.Content);
      }
      return (Job) apiClient.Deserialize(response.Content, typeof(Job));
    }
    
    /// <summary>
    /// Get information about a Job 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    public Job JobsJobIdGet (string Token, string Key, string JobId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdGet");
      

      var path = "/jobs/{job_id}";
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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdGet: " + response.Content, response.Content);
      }
      return (Job) apiClient.Deserialize(response.Content, typeof(Job));
    }
	
	 /// <summary>
    /// Get information about a Job 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    public async Task<Job> JobsJobIdGetAsync (string Token, string Key, string JobId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdGet");
      

      var path = "/jobs/{job_id}";
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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdGet: " + response.Content, response.Content);
      }
      return (Job) apiClient.Deserialize(response.Content, typeof(Job));
    }
    
    /// <summary>
    /// Cancels a job created that haven&#39;t been started. (Allow to cancel jobs in process.) 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    public Job JobsJobIdDelete (string Token, string Key, string JobId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdDelete");
      

      var path = "/jobs/{job_id}";
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
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdDelete: " + response.Content, response.Content);
      }
      return (Job) apiClient.Deserialize(response.Content, typeof(Job));
    }
	
	 /// <summary>
    /// Cancels a job created that haven&#39;t been started. (Allow to cancel jobs in process.) 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    public async Task<Job> JobsJobIdDeleteAsync (string Token, string Key, string JobId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdDelete");
      

      var path = "/jobs/{job_id}";
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
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdDelete: " + response.Content, response.Content);
      }
      return (Job) apiClient.Deserialize(response.Content, typeof(Job));
    }
    
    /// <summary>
    /// Modifies the job identified by the id, allows to start a created job. 
    /// </summary>
    /// <param name="Body">Content of the job.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    public Job JobsJobIdPatch (Job Body, string Token, string Key, string JobId) {

      
      // verify the required parameter 'Body' is set
      if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling JobsJobIdPatch");
      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdPatch");
      

      var path = "/jobs/{job_id}";
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
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdPatch: " + response.Content, response.Content);
      }
      return (Job) apiClient.Deserialize(response.Content, typeof(Job));
    }
	
	 /// <summary>
    /// Modifies the job identified by the id, allows to start a created job. 
    /// </summary>
    /// <param name="Body">Content of the job.</param>/// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>Job</returns>
    public async Task<Job> JobsJobIdPatchAsync (Job Body, string Token, string Key, string JobId) {

      
          // verify the required parameter 'Body' is set
          if (Body == null) throw new ApiException(400, "Missing required parameter 'Body' when calling JobsJobIdPatch");
      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdPatch");
      

      var path = "/jobs/{job_id}";
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
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdPatch: " + response.Content, response.Content);
      }
      return (Job) apiClient.Deserialize(response.Content, typeof(Job));
    }
    
    /// <summary>
    /// Get list of threads defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<Thread></returns>
    public List<Thread> JobsJobIdThreadsGet (string Token, string Key, string JobId) {

      
      // verify the required parameter 'JobId' is set
      if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdThreadsGet");
      

      var path = "/jobs/{job_id}/threads";
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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdThreadsGet: " + response.Content, response.Content);
      }
      return (List<Thread>) apiClient.Deserialize(response.Content, typeof(List<Thread>));
    }
	
	 /// <summary>
    /// Get list of threads defined for the current job. 
    /// </summary>
    /// <param name="Token">Token for authentication.</param>/// <param name="Key">Api key for the user to filter.</param>/// <param name="JobId">ID of job that needs to be fetched</param>
    /// <returns>List<Thread></returns>
    public async Task<List<Thread>> JobsJobIdThreadsGetAsync (string Token, string Key, string JobId) {

      
          // verify the required parameter 'JobId' is set
          if (JobId == null) throw new ApiException(400, "Missing required parameter 'JobId' when calling JobsJobIdThreadsGet");
      

      var path = "/jobs/{job_id}/threads";
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
        throw new ApiException ((int)response.StatusCode, "Error calling JobsJobIdThreadsGet: " + response.Content, response.Content);
      }
      return (List<Thread>) apiClient.Deserialize(response.Content, typeof(List<Thread>));
    }
    
  }  
  
}
