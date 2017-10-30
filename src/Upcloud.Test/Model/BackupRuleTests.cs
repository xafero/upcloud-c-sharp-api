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
    ///  Class for testing BackupRule
    /// </summary>
    [TestFixture]
    public class BackupRuleTests
    {
        // TODO uncomment below to declare an instance variable for BackupRule
        //private BackupRule instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BackupRule
            //instance = new BackupRule();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BackupRule
        /// </summary>
        [Test]
        public void BackupRuleInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BackupRule
            //Assert.IsInstanceOfType<BackupRule> (instance, "variable 'instance' is a BackupRule");
        }

        /// <summary>
        /// Test the property 'interval'
        /// </summary>
        [Test]
        public void intervalTest()
        {
            // TODO unit test for the property 'interval'
        }
        /// <summary>
        /// Test the property 'time'
        /// </summary>
        [Test]
        public void timeTest()
        {
            // TODO unit test for the property 'time'
        }
        /// <summary>
        /// Test the property 'retention'
        /// </summary>
        [Test]
        public void retentionTest()
        {
            // TODO unit test for the property 'retention'
        }

    }

}
