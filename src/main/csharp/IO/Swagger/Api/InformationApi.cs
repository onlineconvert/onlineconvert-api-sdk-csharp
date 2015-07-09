using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api {
  

  public interface IInformationApi {
    
    /// <summary>
    /// Get a list of the valid conversions. Gets a list of the valid conversions that can be made with the API. For each conversion is also shown the available options for that specific type of conversion.\n\nThis conversions can be added to a Job through the specific endpoint or in the information given to create the new Job.\n
    /// </summary>
    /// <param name="Category">Category for the conversion.</param>/// <param name="Target">Target for for the conversion.</param>/// <param name="Page">Pagination for list of elements.</param>
    /// <returns>List<Conversion></returns>
    List<Conversion> ConversionsGet (string Category, string Target, double? Page);

    /// <summary>
    /// Get a list of the valid conversions. Gets a list of the valid conversions that can be made with the API. For each conversion is also shown the available options for that specific type of conversion.\n\nThis conversions can be added to a Job through the specific endpoint or in the information given to create the new Job.\n
    /// </summary>
    /// <param name="Category">Category for the conversion.</param>/// <param name="Target">Target for for the conversion.</param>/// <param name="Page">Pagination for list of elements.</param>
    /// <returns>List<Conversion></returns>
    Task<List<Conversion>> ConversionsGetAsync (string Category, string Target, double? Page);
    
    /// <summary>
    /// Get a list of the valid statuses. The endpoint provide a list of all available status that the Job may have during the process as a description of the status.
    /// </summary>
    
    /// <returns>List<Status></returns>
    List<Status> StatusesGet ();

    /// <summary>
    /// Get a list of the valid statuses. The endpoint provide a list of all available status that the Job may have during the process as a description of the status.
    /// </summary>
    
    /// <returns>List<Status></returns>
    Task<List<Status>> StatusesGetAsync ();
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class InformationApi : IInformationApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="InformationApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public InformationApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InformationApi"/> class.
    /// </summary>
    /// <returns></returns>
    public InformationApi(String basePath)
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
    /// Get a list of the valid conversions. Gets a list of the valid conversions that can be made with the API. For each conversion is also shown the available options for that specific type of conversion.\n\nThis conversions can be added to a Job through the specific endpoint or in the information given to create the new Job.\n
    /// </summary>
    /// <param name="Category">Category for the conversion.</param>/// <param name="Target">Target for for the conversion.</param>/// <param name="Page">Pagination for list of elements.</param>
    /// <returns>List<Conversion></returns>
    public List<Conversion> ConversionsGet (string Category, string Target, double? Page) {

      

      var path = "/conversions";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Category != null) queryParams.Add("category", apiClient.ParameterToString(Category)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Page != null) queryParams.Add("page", apiClient.ParameterToString(Page)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConversionsGet: " + response.Content, response.Content);
      }
      return (List<Conversion>) apiClient.Deserialize(response.Content, typeof(List<Conversion>));
    }
	
	 /// <summary>
    /// Get a list of the valid conversions. Gets a list of the valid conversions that can be made with the API. For each conversion is also shown the available options for that specific type of conversion.\n\nThis conversions can be added to a Job through the specific endpoint or in the information given to create the new Job.\n
    /// </summary>
    /// <param name="Category">Category for the conversion.</param>/// <param name="Target">Target for for the conversion.</param>/// <param name="Page">Pagination for list of elements.</param>
    /// <returns>List<Conversion></returns>
    public async Task<List<Conversion>> ConversionsGetAsync (string Category, string Target, double? Page) {

      

      var path = "/conversions";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Category != null) queryParams.Add("category", apiClient.ParameterToString(Category)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Page != null) queryParams.Add("page", apiClient.ParameterToString(Page)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ConversionsGet: " + response.Content, response.Content);
      }
      return (List<Conversion>) apiClient.Deserialize(response.Content, typeof(List<Conversion>));
    }
    
    /// <summary>
    /// Get a list of the valid statuses. The endpoint provide a list of all available status that the Job may have during the process as a description of the status.
    /// </summary>
    
    /// <returns>List<Status></returns>
    public List<Status> StatusesGet () {

      

      var path = "/statuses";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling StatusesGet: " + response.Content, response.Content);
      }
      return (List<Status>) apiClient.Deserialize(response.Content, typeof(List<Status>));
    }
	
	 /// <summary>
    /// Get a list of the valid statuses. The endpoint provide a list of all available status that the Job may have during the process as a description of the status.
    /// </summary>
    
    /// <returns>List<Status></returns>
    public async Task<List<Status>> StatusesGetAsync () {

      

      var path = "/statuses";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] {  };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling StatusesGet: " + response.Content, response.Content);
      }
      return (List<Status>) apiClient.Deserialize(response.Content, typeof(List<Status>));
    }
    
  }  
  
}
