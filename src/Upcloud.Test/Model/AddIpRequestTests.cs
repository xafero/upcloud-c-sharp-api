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
    ///  Class for testing AddIpRequest
    /// </summary>
    [TestFixture]
    public class AddIpRequestTests
    {
        // TODO uncomment below to declare an instance variable for AddIpRequest
        //private AddIpRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AddIpRequest
            //instance = new AddIpRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddIpRequest
        /// </summary>
        [Test]
        public void AddIpRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AddIpRequest
            //Assert.IsInstanceOfType<AddIpRequest> (instance, "variable 'instance' is a AddIpRequest");
        }

        /// <summary>
        /// Test the property 'ipAddress'
        /// </summary>
        [Test]
        public void ipAddressTest()
        {
            // TODO unit test for the property 'ipAddress'
        }

    }

}
