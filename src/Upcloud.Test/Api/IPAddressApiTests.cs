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
  ///  Class for testing IPAddressApi
  /// </summary>
  [TestFixture]
  public class IPAddressApiTests
  {
    private IPAddressApi instance;
    private Server testServer;
    private IpAddress testIpAddress;

    /// <summary>
    /// Setup before each unit test
    /// </summary>
    [SetUp]
    public void Init()
    {
      instance = new IPAddressApi
      {
        Configuration = {
                    Username = "toughbyte",
                    Password = "Topsekret5"
                }
      };
      testServer = Utils.createReadyServer();
      Utils.stopAllServers();
    }

    /// <summary>
    /// Clean up after each unit test
    /// </summary>
    [TearDown]
    public void Cleanup()
    {

      Utils.deleteAllServers();

    }

    [TestFixtureSetUp]
    public void SetUpEach()
    {
      Guid? serverId = testServer.uuid;
      testIpAddress = new IpAddress { family = (IpAddress.FamilyEnum.IPv4), server = (serverId) };
      AssignIpResponse response = instance.AddIp(new AddIpRequest { ipAddress = (testIpAddress) });
      testIpAddress = response.ipAddress;
    }

    [TestFixtureTearDown]
    public void TearDownEach()
    {
      if (testIpAddress != null)
      {
        instance.DeleteIp(testIpAddress.address);
      }
    }

    /// <summary>
    /// Test an instance of IPAddressApi
    /// </summary>
    [Test]
    public void InstanceTest()
    {
      // TODO uncomment below to test 'IsInstanceOfType' IPAddressApi
      Assert.IsInstanceOfType(typeof(IPAddressApi), instance, "instance is a IPAddressApi");
    }


    /// <summary>
    /// Test AddIp
    /// </summary>
    [Test]
    public void AddIpTest()
    {
      Guid? serverId = testServer.uuid;
      IpAddress ipAddress = new IpAddress
      {
        family = IpAddress.FamilyEnum.IPv4,
        server = serverId
      };
      AssignIpResponse response = instance.AddIp(new AddIpRequest { ipAddress = (ipAddress) });
      ipAddress = response.ipAddress;
      Assert.AreEqual(IpAddress.AccessEnum.Public, ipAddress.access);
      Assert.AreEqual(IpAddress.FamilyEnum.IPv4, ipAddress.family);
      Assert.AreEqual(serverId, ipAddress.server);
    }

    /// <summary>
    /// Test DeleteIp
    /// </summary>
    [Test]
    public void DeleteIpTest()
    {
      instance.DeleteIp(testIpAddress.address);
      ApiException exception = Assert.Throws<ApiException>(() => instance.GetDetails(testIpAddress.address));
      Assert.AreEqual("Not Found", exception.Message);
      testIpAddress = null;
    }

    /// <summary>
    /// Test GetDetails
    /// </summary>
    [Test]
    public void GetDetailsTest()
    {
      String ip = testIpAddress.address;
      AssignIpResponse response = instance.GetDetails(ip);
      IpAddress ipAddress = response.ipAddress;

      Assert.AreEqual(testIpAddress.access, ipAddress.access);
      Assert.AreEqual(testIpAddress.address, ipAddress.address);
      Assert.AreEqual(testIpAddress.family, ipAddress.family);
      Assert.NotNull(ipAddress.ptrRecord);
      Assert.NotNull(ipAddress.server);
    }

    /// <summary>
    /// Test ListIps
    /// </summary>
    [Test]
    public void ListIpsTest()
    {
      IpAddressListResponse response = instance.ListIps();
      List<IpAddress> ipAddresses = response.ipAddresses.ipAddress;
      Assert.True(ipAddresses.Any(ipAddress => ipAddress.address.Equals(testIpAddress.address)));
    }

    /// <summary>
    /// Test ModifyIp
    /// </summary>
    [Test]
    public void ModifyIpTest()
    {
      String ip = testIpAddress.address;
      IpAddress ipAddress = new IpAddress { ptrRecord = "hostname.example.com" };
      AssignIpResponse response = instance.ModifyIp(ip, new ModifyIpRequest { ipAddress = (ipAddress) });
      ipAddress = response.ipAddress;
      Assert.AreEqual("hostname.example.com", ipAddress.ptrRecord);
      Assert.AreEqual(testIpAddress.access, ipAddress.access);
      Assert.AreEqual(testIpAddress.family, ipAddress.family);
      Assert.AreEqual(testIpAddress.server, ipAddress.server);
    }

  }

}
