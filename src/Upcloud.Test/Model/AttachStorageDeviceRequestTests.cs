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
    ///  Class for testing AttachStorageDeviceRequest
    /// </summary>
    [TestFixture]
    public class AttachStorageDeviceRequestTests
    {
        // TODO uncomment below to declare an instance variable for AttachStorageDeviceRequest
        //private AttachStorageDeviceRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AttachStorageDeviceRequest
            //instance = new AttachStorageDeviceRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AttachStorageDeviceRequest
        /// </summary>
        [Test]
        public void AttachStorageDeviceRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AttachStorageDeviceRequest
            //Assert.IsInstanceOfType<AttachStorageDeviceRequest> (instance, "variable 'instance' is a AttachStorageDeviceRequest");
        }

        /// <summary>
        /// Test the property 'StorageDevice'
        /// </summary>
        [Test]
        public void StorageDeviceTest()
        {
            // TODO unit test for the property 'StorageDevice'
        }

    }

}
