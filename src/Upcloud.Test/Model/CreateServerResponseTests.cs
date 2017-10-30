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
    ///  Class for testing CreateServerResponse
    /// </summary>
    [TestFixture]
    public class CreateServerResponseTests
    {
        // TODO uncomment below to declare an instance variable for CreateServerResponse
        //private CreateServerResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CreateServerResponse
            //instance = new CreateServerResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreateServerResponse
        /// </summary>
        [Test]
        public void CreateServerResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateServerResponse
            //Assert.IsInstanceOfType<CreateServerResponse> (instance, "variable 'instance' is a CreateServerResponse");
        }

        /// <summary>
        /// Test the property 'server'
        /// </summary>
        [Test]
        public void serverTest()
        {
            // TODO unit test for the property 'server'
        }

    }

}
