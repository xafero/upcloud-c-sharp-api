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
    ///  Class for testing StorageType
    /// </summary>
    [TestFixture]
    public class StorageTypeTests
    {
        // TODO uncomment below to declare an instance variable for StorageType
        //private StorageType instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of StorageType
            //instance = new StorageType();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StorageType
        /// </summary>
        [Test]
        public void StorageTypeInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" StorageType
            //Assert.IsInstanceOfType<StorageType> (instance, "variable 'instance' is a StorageType");
        }


    }

}
