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
    ///  Class for testing IpAddress
    /// </summary>
    [TestFixture]
    public class IpAddressTests
    {
        // TODO uncomment below to declare an instance variable for IpAddress
        //private IpAddress instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of IpAddress
            //instance = new IpAddress();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IpAddress
        /// </summary>
        [Test]
        public void IpAddressInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" IpAddress
            //Assert.IsInstanceOfType<IpAddress> (instance, "variable 'instance' is a IpAddress");
        }

        /// <summary>
        /// Test the property 'Access'
        /// </summary>
        [Test]
        public void AccessTest()
        {
            // TODO unit test for the property 'Access'
        }
        /// <summary>
        /// Test the property 'Family'
        /// </summary>
        [Test]
        public void FamilyTest()
        {
            // TODO unit test for the property 'Family'
        }
        /// <summary>
        /// Test the property 'Server'
        /// </summary>
        [Test]
        public void ServerTest()
        {
            // TODO unit test for the property 'Server'
        }

    }

}
