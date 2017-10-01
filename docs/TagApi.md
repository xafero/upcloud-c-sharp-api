# Upcloud.Api.TagApi

All URIs are relative to *https://api.upcloud.com/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignTag**](TagApi.md#assigntag) | **POST** /server/{serverId}/tag/{tagList} | Assign tag to a server
[**CreateTag**](TagApi.md#createtag) | **POST** /tag | Create a new tag
[**DeleteTag**](TagApi.md#deletetag) | **DELETE** /tag/{tagName} | Delete tag
[**ListTags**](TagApi.md#listtags) | **GET** /tag | List existing tags
[**ModifyTag**](TagApi.md#modifytag) | **PUT** /tag/{tagName} | Modify existing tag
[**Untag**](TagApi.md#untag) | **POST** /server/{serverId}/untag/{tagName} | Remove tag from server


<a name="assigntag"></a>
# **AssignTag**
> CreateServerResponse AssignTag (Guid? serverId, string tagList)

Assign tag to a server

Servers can be tagged with one or more tags. The tags used must exist

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class AssignTagExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var serverId = serverId_example;  // Guid? | Server id
            var tagList = tagList_example;  // string | List of tags

            try
            {
                // Assign tag to a server
                CreateServerResponse result = apiInstance.AssignTag(serverId, tagList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.AssignTag: " + e.Message );
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

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtag"></a>
# **CreateTag**
> CreateNewTagResponse CreateTag (Tag tag)

Create a new tag

Creates a new tag. Existing servers can be tagged in same request

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class CreateTagExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var tag = new Tag(); // Tag | 

            try
            {
                // Create a new tag
                CreateNewTagResponse result = apiInstance.CreateTag(tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.CreateTag: " + e.Message );
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

[**CreateNewTagResponse**](CreateNewTagResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetag"></a>
# **DeleteTag**
> void DeleteTag (string tagName)

Delete tag

Deleting existing tag untags all servers from specified tag and deletes tag definition

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class DeleteTagExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var tagName = tagName_example;  // string | Tag name

            try
            {
                // Delete tag
                apiInstance.DeleteTag(tagName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.DeleteTag: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtags"></a>
# **ListTags**
> TagListResponse ListTags ()

List existing tags

Returns all existing tags with their properties and servers tagged

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ListTagsExample
    {
        public void main()
        {
            var apiInstance = new TagApi();

            try
            {
                // List existing tags
                TagListResponse result = apiInstance.ListTags();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.ListTags: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TagListResponse**](TagListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifytag"></a>
# **ModifyTag**
> CreateNewTagResponse ModifyTag (string tagName, Tag1 tag)

Modify existing tag

Changes attributes of an existing tag

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ModifyTagExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var tagName = tagName_example;  // string | Tag name
            var tag = new Tag1(); // Tag1 | 

            try
            {
                // Modify existing tag
                CreateNewTagResponse result = apiInstance.ModifyTag(tagName, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.ModifyTag: " + e.Message );
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

[**CreateNewTagResponse**](CreateNewTagResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="untag"></a>
# **Untag**
> CreateServerResponse Untag (Guid? serverId, string tagName)

Remove tag from server

Untags tags from given server. The tag(s) must exist

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class UntagExample
    {
        public void main()
        {
            var apiInstance = new TagApi();
            var serverId = serverId_example;  // Guid? | Server id
            var tagName = tagName_example;  // string | Tag name

            try
            {
                // Remove tag from server
                CreateServerResponse result = apiInstance.Untag(serverId, tagName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.Untag: " + e.Message );
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

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

