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
  ///  Class for testing PricesApi
  /// </summary>
  [TestFixture]
  public class PricesApiTests
  {
    private PricesApi instance;

    /// <summary>
    /// Setup before each unit test
    /// </summary>
    [SetUp]
    public void Init()
    {
      instance = new PricesApi();
    }

    /// <summary>
    /// Clean up after each unit test
    /// </summary>
    [TearDown]
    public void Cleanup()
    {

    }

    /// <summary>
    /// Test an instance of PricesApi
    /// </summary>
    [Test]
    public void InstanceTest()
    {
      // TODO uncomment below to test 'IsInstanceOfType' PricesApi
      //Assert.IsInstanceOfType(typeof(PricesApi), instance, "instance is a PricesApi");
    }


    /// <summary>
    /// Test ListPrices
    /// </summary>
    [Test]
    public void ListPricesTest()
    {
      PriceListResponse response = instance.ListPrices();
      List<PriceZone> priceZones = response.prices.zone;
      PriceZone priceZone = priceZones[0];

      Assert.AreNotEqual(0, priceZones.Count);
      Assert.NotNull(priceZone.name);
      Assert.NotNull(priceZone.firewall);
      Assert.NotNull(priceZone.ioRequestBackup);
      Assert.NotNull(priceZone.ioRequestMaxiops);
      Assert.NotNull(priceZone.ipv4Address);
      Assert.NotNull(priceZone.ipv6Address);
      Assert.NotNull(priceZone.publicIpv4BandwidthIn);
      Assert.NotNull(priceZone.publicIpv4BandwidthOut);
      Assert.NotNull(priceZone.publicIpv6BandwidthIn);
      Assert.NotNull(priceZone.publicIpv6BandwidthOut);
      Assert.NotNull(priceZone.serverCore);
      Assert.NotNull(priceZone.serverMemory);
      Assert.NotNull(priceZone.serverPlan1xCPU1GB);
      Assert.NotNull(priceZone.serverPlan2xCPU2GB);
      Assert.NotNull(priceZone.storageBackup);
      Assert.NotNull(priceZone.storageMaxiops);
    }

  }

}
