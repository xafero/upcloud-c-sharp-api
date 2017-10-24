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
    private Server testServer;

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
      //Assert.IsInstanceOfType(typeof(TagApi), instance, "instance is a TagApi");
    }


    /// <summary>
    /// Test AssignTag
    /// </summary>
    [Test]
    public void AssignTagTest()
    {
      var serverId = testServer.uuid;
      var tagList = "DEV";
      var response = instance.AssignTag(serverId, tagList);
      var server = response.server;
      Assert.AreEqual(1, server.tags.tag.Count);
      tagList = "TAG2";
      response = instance.AssignTag(serverId, tagList);
      server = response.server;
      Assert.AreEqual(2, server.tags.tag.Count);
      Assert.True(server.tags.tag.All(tag => tag.Equals("DEV") || tag.Equals("TAG2")));
    }

    /// <summary>
    /// Test CreateTag
    /// </summary>
    [Test]
    public void CreateTagTest()
    {
      var tag = instance.CreateTag(new TagCreateRequest
      {
        tag =
          new Tag
          {
            name = ("TESTTAG"),
            description = ("Test tag")
          }
      }).tag;
      Assert.AreEqual(tag.name, "TESTTAG");
      Assert.AreEqual(tag.description, "Test tag");
      Assert.NotNull(tag.servers);
      instance.DeleteTag("TESTTAG");
    }

    /// <summary>
    /// Test DeleteTag
    /// </summary>
    [Test]
    public void DeleteTagTest()
    {
      var tagList = instance.ListTags().tags.tag;
      Assert.AreEqual(2, tagList.Count);
      instance.DeleteTag("DEV");
      tagList = instance.ListTags().tags.tag;
      Assert.AreEqual(1, tagList.Count);
      Assert.True(!tagList.Any(tag => tag.Equals("DEV")));

    }

    /// <summary>
    /// Test ListTags
    /// </summary>
    [Test]
    public void ListTagsTest()
    {
      var response = instance.ListTags();
      var tagList = response.tags.tag;
      Assert.AreEqual(2, tagList.Count);
      Assert.True(tagList.All(tag => tag.name.Equals("DEV") || tag.name.Equals("TAG2")));
    }

    /// <summary>
    /// Test ModifyTag
    /// </summary>
    [Test]
    public void ModifyTagTest()
    {
      var response = instance.ModifyTag("DEV", new ModifyTagRequest
      {
        tag =
          new Tag
          {
            name = ("PROD"),
            description = ("Production tag")
          }
      });
      var modifiedTag = response.tag;
      Assert.AreEqual("PROD", modifiedTag.name);
      Assert.AreEqual("Production tag", modifiedTag.description);
    }

    /// <summary>
    /// Test Untag
    /// </summary>
    [Test]
    public void UntagTest()
    {
      var serverId = testServer.uuid;
      var tagName = "DEV";
      var server = instance.AssignTag(serverId, tagName).server;

      Assert.True(server.tags.tag.Any(tag => tag.Equals("DEV")));

      server = instance.Untag(serverId, tagName).server;

      Assert.True(!server.tags.tag.Any(tag => tag.Equals("DEV")));
    }

  }

}
