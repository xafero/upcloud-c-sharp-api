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
  ///  Class for testing TimezoneApi
  /// </summary>
  [TestFixture]
  public class TimezoneApiTests
  {
    private TimezoneApi instance;

    /// <summary>
    /// Setup before each unit test
    /// </summary>
    [SetUp]
    public void Init()
    {
      instance = new TimezoneApi();
    }

    /// <summary>
    /// Clean up after each unit test
    /// </summary>
    [TearDown]
    public void Cleanup()
    {

    }

    /// <summary>
    /// Test an instance of TimezoneApi
    /// </summary>
    [Test]
    public void InstanceTest()
    {
      // TODO uncomment below to test 'IsInstanceOfType' TimezoneApi
      //Assert.IsInstanceOfType(typeof(TimezoneApi), instance, "instance is a TimezoneApi");
    }


    /// <summary>
    /// Test ListTimezones
    /// </summary>
    [Test]
    public void ListTimezonesTest()
    {
      var response = instance.ListTimezones();
      var continentals = new String[] {
                "Africa", "America", "Antarctica", "Arctic", "Asia", "Atlantic", "Australia", "Europe", "Indian", "Pacific"
        };

      var timezones = response.timezones.timezone;
      Assert.True(timezones
              .All(timezone =>
                      continentals.Contains(timezone.Split('/')[0]) || timezone.Equals("UTC")
              ));
    }

  }

}
