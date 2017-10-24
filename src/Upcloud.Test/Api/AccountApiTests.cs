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
  ///  Class for testing AccountApi
  /// </summary>
  [TestFixture]
  public class AccountApiTests
  {
    private AccountApi instance;

    /// <summary>
    /// Setup before each unit test
    /// </summary>
    [SetUp]
    public void Init()
    {
      instance = new AccountApi();
      instance.Configuration.Username = "toughbyte";
      instance.Configuration.Password = "Topsekret5";
    }

    /// <summary>
    /// Clean up after each unit test
    /// </summary>
    [TearDown]
    public void Cleanup()
    {

    }


    /// <summary>
    /// Test GetAccount
    /// </summary>

    [Test]
    [Category("RunOnlyThis")]
    public void GetAccountTest()
    {
      var response = instance.GetAccount();
      Assert.IsInstanceOf<AccountResponse>(response, "response is AccountResponse");
      Assert.AreEqual("toughbyte", response.account.username);
    }

  }

}
