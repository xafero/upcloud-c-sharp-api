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
    ///  Class for testing RestartServer
    /// </summary>
    [TestFixture]
    public class RestartServerTests
    {
        // TODO uncomment below to declare an instance variable for RestartServer
        //private RestartServer instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RestartServer
            //instance = new RestartServer();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RestartServer
        /// </summary>
        [Test]
        public void RestartServerInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RestartServer
            //Assert.IsInstanceOfType<RestartServer> (instance, "variable 'instance' is a RestartServer");
        }

        /// <summary>
        /// Test the property 'stopType'
        /// </summary>
        [Test]
        public void stopTypeTest()
        {
            // TODO unit test for the property 'stopType'
        }
        /// <summary>
        /// Test the property 'timeout'
        /// </summary>
        [Test]
        public void timeoutTest()
        {
            // TODO unit test for the property 'timeout'
        }
        /// <summary>
        /// Test the property 'timeoutAction'
        /// </summary>
        [Test]
        public void timeoutActionTest()
        {
            // TODO unit test for the property 'timeoutAction'
        }

    }

}
