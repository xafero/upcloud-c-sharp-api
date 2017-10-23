/* 
 * Upcloud api
 *
 * The UpCloud API consists of operations used to control resources on UpCloud. The API is a web service interface. HTTPS is used to connect to the API. The API follows the principles of a RESTful web service wherever possible. The base URL for all API operations is  https://api.upcloud.com/. All API operations require authentication.
 *
 * OpenAPI spec version: 1.2.0
 * 
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Upcloud.Api;
using Upcloud.Model;
using Upcloud.Client;
using System.Reflection;

namespace Upcloud.Test
{
    /// <summary>
    ///  Class for testing Price
    /// </summary>
    [TestFixture]
    public class PriceTests
    {
        // TODO uncomment below to declare an instance variable for Price
        //private Price instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Price
            //instance = new Price();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Price
        /// </summary>
        [Test]
        public void PriceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Price
            //Assert.IsInstanceOfType<Price> (instance, "variable 'instance' is a Price");
        }

        /// <summary>
        /// Test the property 'amount'
        /// </summary>
        [Test]
        public void amountTest()
        {
            // TODO unit test for the property 'amount'
        }
        /// <summary>
        /// Test the property '_price'
        /// </summary>
        [Test]
        public void _priceTest()
        {
            // TODO unit test for the property '_price'
        }

    }

}
