# agent.Api.AgentApi

All URIs are relative to *https://agent.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AgentCreateAgent**](AgentApi.md#agentcreateagent) | **POST** /v1/{tenantId}/agent/create |  |
| [**AgentGetAgent**](AgentApi.md#agentgetagent) | **GET** /v1/{tenantId}/agent/{id} |  |
| [**AgentListAgents**](AgentApi.md#agentlistagents) | **POST** /v1/{tenantId}/agent/list/page-size/{pageSize} |  |
| [**AgentUpdateAgent**](AgentApi.md#agentupdateagent) | **PUT** /v1/{tenantId}/agent/{id} |  |

<a id="agentcreateagent"></a>
# **AgentCreateAgent**
> AgentAgentEntity AgentCreateAgent (string tenantId, AgentCreateAgentRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using agent.Api;
using agent.Client;
using agent.Model;

namespace Example
{
    public class AgentCreateAgentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://agent.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AgentApi(config);
            var tenantId = "tenantId_example";  // string | 
            var body = new AgentCreateAgentRequest(); // AgentCreateAgentRequest | 

            try
            {
                AgentAgentEntity result = apiInstance.AgentCreateAgent(tenantId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentApi.AgentCreateAgent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgentCreateAgentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgentAgentEntity> response = apiInstance.AgentCreateAgentWithHttpInfo(tenantId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentApi.AgentCreateAgentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **body** | [**AgentCreateAgentRequest**](AgentCreateAgentRequest.md) |  |  |

### Return type

[**AgentAgentEntity**](AgentAgentEntity.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentgetagent"></a>
# **AgentGetAgent**
> AgentAgentEntity AgentGetAgent (string tenantId, string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using agent.Api;
using agent.Client;
using agent.Model;

namespace Example
{
    public class AgentGetAgentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://agent.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AgentApi(config);
            var tenantId = "tenantId_example";  // string | 
            var id = "id_example";  // string | 

            try
            {
                AgentAgentEntity result = apiInstance.AgentGetAgent(tenantId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentApi.AgentGetAgent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgentGetAgentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgentAgentEntity> response = apiInstance.AgentGetAgentWithHttpInfo(tenantId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentApi.AgentGetAgentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **id** | **string** |  |  |

### Return type

[**AgentAgentEntity**](AgentAgentEntity.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentlistagents"></a>
# **AgentListAgents**
> AgentListResponse AgentListAgents (string tenantId, long pageSize, AgentListAgentsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using agent.Api;
using agent.Client;
using agent.Model;

namespace Example
{
    public class AgentListAgentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://agent.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AgentApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 789L;  // long | 
            var body = new AgentListAgentsRequest(); // AgentListAgentsRequest | 

            try
            {
                AgentListResponse result = apiInstance.AgentListAgents(tenantId, pageSize, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentApi.AgentListAgents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgentListAgentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgentListResponse> response = apiInstance.AgentListAgentsWithHttpInfo(tenantId, pageSize, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentApi.AgentListAgentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageSize** | **long** |  |  |
| **body** | [**AgentListAgentsRequest**](AgentListAgentsRequest.md) |  |  |

### Return type

[**AgentListResponse**](AgentListResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentupdateagent"></a>
# **AgentUpdateAgent**
> AgentAgentEntity AgentUpdateAgent (string tenantId, string id, AgentUpdateAgentRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using agent.Api;
using agent.Client;
using agent.Model;

namespace Example
{
    public class AgentUpdateAgentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://agent.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AgentApi(config);
            var tenantId = "tenantId_example";  // string | 
            var id = "id_example";  // string | 
            var body = new AgentUpdateAgentRequest(); // AgentUpdateAgentRequest | 

            try
            {
                AgentAgentEntity result = apiInstance.AgentUpdateAgent(tenantId, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentApi.AgentUpdateAgent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgentUpdateAgentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgentAgentEntity> response = apiInstance.AgentUpdateAgentWithHttpInfo(tenantId, id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentApi.AgentUpdateAgentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **id** | **string** |  |  |
| **body** | [**AgentUpdateAgentRequest**](AgentUpdateAgentRequest.md) |  |  |

### Return type

[**AgentAgentEntity**](AgentAgentEntity.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

