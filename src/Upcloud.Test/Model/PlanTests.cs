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
    ///  Class for testing Plan
    /// </summary>
    [TestFixture]
    public class PlanTests
    {
        // TODO uncomment below to declare an instance variable for Plan
        //private Plan instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Plan
            //instance = new Plan();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Plan
        /// </summary>
        [Test]
        public void PlanInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Plan
            //Assert.IsInstanceOfType<Plan> (instance, "variable 'instance' is a Plan");
        }

        /// <summary>
        /// Test the property 'CoreNumber'
        /// </summary>
        [Test]
        public void CoreNumberTest()
        {
            // TODO unit test for the property 'CoreNumber'
        }
        /// <summary>
        /// Test the property 'MemoryAmount'
        /// </summary>
        [Test]
        public void MemoryAmountTest()
        {
            // TODO unit test for the property 'MemoryAmount'
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
        /// Test the property 'PublicTrafficOut'
        /// </summary>
        [Test]
        public void PublicTrafficOutTest()
        {
            // TODO unit test for the property 'PublicTrafficOut'
        }
        /// <summary>
        /// Test the property 'StorageSize'
        /// </summary>
        [Test]
        public void StorageSizeTest()
        {
            // TODO unit test for the property 'StorageSize'
        }
        /// <summary>
        /// Test the property 'StorageTier'
        /// </summary>
        [Test]
        public void StorageTierTest()
        {
            // TODO unit test for the property 'StorageTier'
        }

    }

}
