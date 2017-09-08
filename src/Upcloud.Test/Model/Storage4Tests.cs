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
    ///  Class for testing Storage4
    /// </summary>
    [TestFixture]
    public class Storage4Tests
    {
        // TODO uncomment below to declare an instance variable for Storage4
        //private Storage4 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Storage4
            //instance = new Storage4();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Storage4
        /// </summary>
        [Test]
        public void Storage4InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Storage4
            //Assert.IsInstanceOfType<Storage4> (instance, "variable 'instance' is a Storage4");
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
