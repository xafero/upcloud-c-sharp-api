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
    ///  Class for testing Storage3
    /// </summary>
    [TestFixture]
    public class Storage3Tests
    {
        // TODO uncomment below to declare an instance variable for Storage3
        //private Storage3 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Storage3
            //instance = new Storage3();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Storage3
        /// </summary>
        [Test]
        public void Storage3InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Storage3
            //Assert.IsInstanceOfType<Storage3> (instance, "variable 'instance' is a Storage3");
        }

        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }

    }

}
