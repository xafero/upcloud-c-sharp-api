/* 
 * Upcloud api
 *
 * The UpCloud API consists of operations used to control resources on UpCloud. The API is a web service interface. HTTPS is used to connect to the API. The API follows the principles of a RESTful web service wherever possible. The base URL for all API operations is  https://api.upcloud.com/. All API operations require authentication.
 *
 * OpenAPI spec version: 1.2.0
 * 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Upcloud.Client;
using Upcloud.Api;
using Upcloud.Model;

namespace Upcloud.Test
{
    /// <summary>
    ///  Class for testing PlanApi
    /// </summary>
    [TestFixture]
    public class PlanApiTests
    {
        private PlanApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PlanApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PlanApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PlanApi
            //Assert.IsInstanceOfType(typeof(PlanApi), instance, "instance is a PlanApi");
        }

        
        /// <summary>
        /// Test ListPlans
        /// </summary>
        [Test]
        public void ListPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListPlans();
            //Assert.IsInstanceOf<AvailablePlanListResponse> (response, "response is AvailablePlanListResponse");
        }
        
    }

}
