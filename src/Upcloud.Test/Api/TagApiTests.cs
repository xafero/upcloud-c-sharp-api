/* 
 * Upcloud api
 *
 * The UpCloud API consists of operations used to control resources on UpCloud. The API is a web service interface. HTTPS is used to connect to the API. The API follows the principles of a RESTful web service wherever possible. The base URL for all API operations is  https://api.upcloud.com/. All API operations require authentication.
 *
 * OpenAPI spec version: 1.2.0
 * 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Upcloud.Client;
using Upcloud.Api;
using Upcloud.Model;

namespace Upcloud.Test
{
    /// <summary>
    ///  Class for testing TagApi
    /// </summary>
    [TestFixture]
    public class TagApiTests
    {
        private TagApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TagApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TagApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TagApi
            //Assert.IsInstanceOfType(typeof(TagApi), instance, "instance is a TagApi");
        }

        
        /// <summary>
        /// Test AssignTag
        /// </summary>
        [Test]
        public void AssignTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //string tagList = null;
            //var response = instance.AssignTag(serverId, tagList);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
        /// <summary>
        /// Test CreateTag
        /// </summary>
        [Test]
        public void CreateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Tag tag = null;
            //var response = instance.CreateTag(tag);
            //Assert.IsInstanceOf<CreateNewTagResponse> (response, "response is CreateNewTagResponse");
        }
        
        /// <summary>
        /// Test DeleteTag
        /// </summary>
        [Test]
        public void DeleteTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagName = null;
            //instance.DeleteTag(tagName);
            
        }
        
        /// <summary>
        /// Test ListTags
        /// </summary>
        [Test]
        public void ListTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListTags();
            //Assert.IsInstanceOf<TagListResponse> (response, "response is TagListResponse");
        }
        
        /// <summary>
        /// Test ModifyTag
        /// </summary>
        [Test]
        public void ModifyTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagName = null;
            //Tag1 tag = null;
            //var response = instance.ModifyTag(tagName, tag);
            //Assert.IsInstanceOf<CreateNewTagResponse> (response, "response is CreateNewTagResponse");
        }
        
        /// <summary>
        /// Test Untag
        /// </summary>
        [Test]
        public void UntagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //string tagName = null;
            //var response = instance.Untag(serverId, tagName);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
    }

}
