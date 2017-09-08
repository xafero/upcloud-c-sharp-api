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
    ///  Class for testing Zone
    /// </summary>
    [TestFixture]
    public class ZoneTests
    {
        // TODO uncomment below to declare an instance variable for Zone
        //private Zone instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Zone
            //instance = new Zone();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Zone
        /// </summary>
        [Test]
        public void ZoneInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Zone
            //Assert.IsInstanceOfType<Zone> (instance, "variable 'instance' is a Zone");
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }

    }

}
