# IO.Swagger.Api.TagApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerServerIdTagTagListPost**](TagApi.md#serverserveridtagtaglistpost) | **POST** /server/{serverId}/tag/{tagList} | Assign tag to a server
[**ServerServerIdUntagTagNamePost**](TagApi.md#serverserveriduntagtagnamepost) | **POST** /server/{serverId}/untag/{tagName} | Remove tag from server
[**TagGet**](TagApi.md#tagget) | **GET** /tag | List existing tags
[**TagPost**](TagApi.md#tagpost) | **POST** /tag | Create a new tag
[**TagTagNameDelete**](TagApi.md#tagtagnamedelete) | **DELETE** /tag/{tagName} | Delete tag
[**TagTagNamePut**](TagApi.md#tagtagnameput) | **PUT** /tag/{tagName} | Modify existing tag


<a name="serverserveridtagtaglistpost"></a>
# **ServerServerIdTagTagListPost**
> ServerListResponse ServerServerIdTagTagListPost (Guid? serverId, string tagList)

Assign tag to a server

Servers can be tagged with one or more tags. The tags used must exist

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdTagTagListPostExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var serverId = serverId_example;  // Guid? | Server id
            var tagList = tagList_example;  // string | List of tags

            try
            {
                // Assign tag to a server
                ServerListResponse result = apiInstance.ServerServerIdTagTagListPost(serverId, tagList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.ServerServerIdTagTagListPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **tagList** | **string**| List of tags | 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveriduntagtagnamepost"></a>
# **ServerServerIdUntagTagNamePost**
> ServerListResponse ServerServerIdUntagTagNamePost (Guid? serverId, string tagName)

Remove tag from server

Untags tags from given server. The tag(s) must exist

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdUntagTagNamePostExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var serverId = serverId_example;  // Guid? | Server id
            var tagName = tagName_example;  // string | Tag name

            try
            {
                // Remove tag from server
                ServerListResponse result = apiInstance.ServerServerIdUntagTagNamePost(serverId, tagName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.ServerServerIdUntagTagNamePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **tagName** | **string**| Tag name | 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagget"></a>
# **TagGet**
> InlineResponse2009 TagGet ()

List existing tags

Returns all existing tags with their properties and servers tagged

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagGetExample
    {
        public void main()
        {
            var apiInstance = new TagApi();

            try
            {
                // List existing tags
                InlineResponse2009 result = apiInstance.TagGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagpost"></a>
# **TagPost**
> InlineResponse20010 TagPost (Tag tag)

Create a new tag

Creates a new tag. Existing servers can be tagged in same request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagPostExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var tag = new Tag(); // Tag | 

            try
            {
                // Create a new tag
                InlineResponse20010 result = apiInstance.TagPost(tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | [**Tag**](Tag.md)|  | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagtagnamedelete"></a>
# **TagTagNameDelete**
> void TagTagNameDelete (string tagName)

Delete tag

Deleting existing tag untags all servers from specified tag and deletes tag definition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagTagNameDeleteExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var tagName = tagName_example;  // string | Tag name

            try
            {
                // Delete tag
                apiInstance.TagTagNameDelete(tagName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagTagNameDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagName** | **string**| Tag name | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagtagnameput"></a>
# **TagTagNamePut**
> InlineResponse20010 TagTagNamePut (string tagName, Tag1 tag)

Modify existing tag

Changes attributes of an existing tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagTagNamePutExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var tagName = tagName_example;  // string | Tag name
            var tag = new Tag1(); // Tag1 | 

            try
            {
                // Modify existing tag
                InlineResponse20010 result = apiInstance.TagTagNamePut(tagName, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagTagNamePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagName** | **string**| Tag name | 
 **tag** | [**Tag1**](Tag1.md)|  | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

