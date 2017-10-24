/* 
 * Upcloud api
 *
 * The UpCloud API consists of operations used to control resources on UpCloud. The API is a web service interface. HTTPS is used to connect to the API. The API follows the principles of a RESTful web service wherever possible. The base URL for all API operations is  https://api.upcloud.com/. All API operations require authentication.
 *
 * OpenAPI spec version: 1.2.0
 * 
 */

using System;
using System.Threading;
using System.Diagnostics;
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
  public static class Utils
  {
    private static StorageDevice defaultStorageDevice = new StorageDevice
    {
      action = "clone",
      title = "Debian from a template",
      storage = "01000000-0000-4000-8000-000020030100",
      size = 50,
      tier = "maxiops"
    };
    private static Server defaultServer = new Server
    {
      zone = "fi-hel1",
      title = "Test server",
      hostname = "debian.example.com",
      plan = "2xCPU-2GB",
      storageDevices = new ServerStorageDevices { storageDevice = new List<StorageDevice> { defaultStorageDevice } }
    };

    private static ServerApi serverApi = new ServerApi
    {
      Configuration = new Configuration
      {
        Username = Environment.GetEnvironmentVariable("UPCLOUD_API_TEST_USER"),
        Password = Environment.GetEnvironmentVariable("UPCLOUD_API_TEST_PASSWORD")
      }
    };

    public static Server createReadyServer(Server server = null)
    {
      Console.WriteLine("Creating server...");
      try
      {
        if (server == null)
        {
          server = defaultServer;
        }
        if (server == null || server.uuid == null)
        {
          Server createdServer = serverApi.CreateServer(new CreateServerRequest
          {
            server = server
          }).server;
          return createReadyServer(createdServer);
        }
        else
        {
          var resp = serverApi.ServerDetails(server.uuid);
          server = resp.server;
          if (server.state == ServerState.Maintenance)
          {
            Thread.Sleep(15000);
            return createReadyServer(server);
          }
          else
          {
            return server;
          }
        }
      }
      catch (ApiException e)
      {
        Console.WriteLine("Can't create server: {0}", e);
      }
      return null;
    }
    public static void stopServer(Server server, int tryings)
    {
      Console.WriteLine("Trying #{0}", tryings);
      if (server != null)
      {
        if (server.state != ServerState.Stopped)
        {
          Console.WriteLine("Stopping server...");
          try
          {
            server = serverApi.StopServer(server.uuid, new StopServer
            {
              _stopServer = new StopServerRequest
              {
                stopType = StopServerRequest.StopTypeEnum.Soft,
                timeout = 60
              }
            }).server;

            Thread.Sleep(15000);
            stopServer(server, tryings + 1);
          }
          catch (ApiException e)
          {
            Console.WriteLine("Stopping error: " + e);
          }
        }
      }
    }

    public static void stopAllServers()
    {

    }

    public static void deleteStorage(Storage storage = null) { }

    public static void deleteServer(Server server, int tryings)
    {
      try
      {
        Console.WriteLine("Trying to delete server: " + server.uuid);
        Console.WriteLine("Trying #" + tryings);
        if (server != null)
        {
          if (server.state != ServerState.Stopped)
          {
            Console.WriteLine("Stopping server...");
            try
            {
              server = serverApi.StopServer(server.uuid, new StopServer
              {
                _stopServer = new StopServerRequest
                {
                  stopType = StopServerRequest.StopTypeEnum.Soft,
                  timeout = 60
                }
              }).server;
            }
            catch (ApiException e)
            {
              Console.WriteLine("Stopping error: " + e);
            }
          }
          serverApi.DeleteServer(server.uuid);
        }
      }
      catch (ApiException e)
      {
        Console.WriteLine("Delete error: " + e);
        Console.WriteLine("Response body: " + e);
        if (e.Message.Equals("Conflict") && tryings < 20)
        {
          Console.WriteLine("Try again in one minute...");
          Thread.Sleep(15000);
          deleteServer(server, tryings + 1);
        }
        else
        {
          Console.WriteLine("Can't delete all test servers");
        }
      }
    }

    public static void deleteAllServers()
    {
      try
      {
        List<Server> serverList = serverApi.ListServers().servers.server;
        foreach (Server server in serverList)
        {
          deleteServer(server, 0);
        }
      }
      catch (ApiException e)
      {
        Console.WriteLine("Message: " + e.Message);
        Console.WriteLine("Response body: " + e.ErrorContent);
      }
    }


  }



}
