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
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListPrices();
            //Assert.IsInstanceOf<PriceListResponse> (response, "response is PriceListResponse");
        }
        
    }

}
