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
    ///  Class for testing TimezoneListResponse
    /// </summary>
    [TestFixture]
    public class TimezoneListResponseTests
    {
        // TODO uncomment below to declare an instance variable for TimezoneListResponse
        //private TimezoneListResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TimezoneListResponse
            //instance = new TimezoneListResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TimezoneListResponse
        /// </summary>
        [Test]
        public void TimezoneListResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TimezoneListResponse
            //Assert.IsInstanceOfType<TimezoneListResponse> (instance, "variable 'instance' is a TimezoneListResponse");
        }

        /// <summary>
        /// Test the property 'Timezones'
        /// </summary>
        [Test]
        public void TimezonesTest()
        {
            // TODO unit test for the property 'Timezones'
        }

    }

}
