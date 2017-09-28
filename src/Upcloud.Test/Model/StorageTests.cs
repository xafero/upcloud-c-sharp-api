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
    ///  Class for testing Storage
    /// </summary>
    [TestFixture]
    public class StorageTests
    {
        // TODO uncomment below to declare an instance variable for Storage
        //private Storage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Storage
            //instance = new Storage();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Storage
        /// </summary>
        [Test]
        public void StorageInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Storage
            //Assert.IsInstanceOfType<Storage> (instance, "variable 'instance' is a Storage");
        }

        /// <summary>
        /// Test the property 'Size'
        /// </summary>
        [Test]
        public void SizeTest()
        {
            // TODO unit test for the property 'Size'
        }
        /// <summary>
        /// Test the property 'Tier'
        /// </summary>
        [Test]
        public void TierTest()
        {
            // TODO unit test for the property 'Tier'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Zone'
        /// </summary>
        [Test]
        public void ZoneTest()
        {
            // TODO unit test for the property 'Zone'
        }
        /// <summary>
        /// Test the property 'BackupRule'
        /// </summary>
        [Test]
        public void BackupRuleTest()
        {
            // TODO unit test for the property 'BackupRule'
        }

    }

}