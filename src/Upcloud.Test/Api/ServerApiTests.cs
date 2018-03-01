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
  ///  Class for testing ServerApi
  /// </summary>
  [TestFixture]
  public class ServerApiTests
  {
    private ServerApi instance;
    private Server testServer;
    private StorageDevice testStorageDevice;
    private List<Server> createdServers = new List<Server>();

    /// <summary>
    /// Setup before each unit test
    /// </summary>
    [SetUp]
    public void Init()
    {
      instance = new ServerApi();

      testStorageDevice = new StorageDevice
      {
        action = "clone",
        storage = "01000000-0000-4000-8000-000020030100",
        title = "Debian from a template",
        size = (50),
        tier = "maxiops"
      };

      testServer = new Server
      {
        zone = "fi-hel1",
        title = "Test server",
        hostname = "debian.example.com",
        plan = "1xCPU-2GB",
        storageDevices = new ServerStorageDevices(new List<StorageDevice> { testStorageDevice }),
      };
    }

    /// <summary>
    /// Clean up after each unit test
    /// </summary>
    [TearDown]
    public void Cleanup()
    {
      Utils.deleteAllServers();
    }

    /// <summary>
    /// Test an instance of ServerApi
    /// </summary>
    [Test]
    public void InstanceTest()
    {
      //Assert.IsInstanceOfType(typeof(ServerApi), instance, "instance is a ServerApi");
    }

    /// <summary>
    /// Test CreateServer
    /// </summary>
    [Test]
    public void CreateServerTest()
    {
      var response = instance.CreateServer(new CreateServerRequest { server = (testServer) });
      var createdServer = response.server;
      createdServers.Add(createdServer);
      Assert.AreEqual(createdServer.title, testServer.title);
      Assert.AreEqual(createdServer.zone, testServer.zone);
      Assert.AreEqual(createdServer.hostname, testServer.hostname);
      Assert.AreEqual(createdServer.plan, testServer.plan);
    }

    /// <summary>
    /// Test ListServers
    /// </summary>
    [Test]
    public void ListServersTest()
    {
      var servers = instance.ListServers().servers.server;
      int prevSize = servers.Count;
      Server createdServer = instance.CreateServer(new CreateServerRequest { server = (testServer) }).server;
      createdServers.Add(createdServer);
      servers = instance.ListServers().servers.server;
      Assert.AreEqual(prevSize + 1, servers.Count);
    }

  }

}
