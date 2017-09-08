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
    ///  Class for testing Tag1
    /// </summary>
    [TestFixture]
    public class Tag1Tests
    {
        // TODO uncomment below to declare an instance variable for Tag1
        //private Tag1 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Tag1
            //instance = new Tag1();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Tag1
        /// </summary>
        [Test]
        public void Tag1InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Tag1
            //Assert.IsInstanceOfType<Tag1> (instance, "variable 'instance' is a Tag1");
        }

        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Test]
        public void TagTest()
        {
            // TODO unit test for the property 'Tag'
        }

    }

}
