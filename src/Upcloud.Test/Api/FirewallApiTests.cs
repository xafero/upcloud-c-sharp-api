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
    ///  Class for testing FirewallApi
    /// </summary>
    [TestFixture]
    public class FirewallApiTests
    {
        private FirewallApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FirewallApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FirewallApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FirewallApi
            //Assert.IsInstanceOfType(typeof(FirewallApi), instance, "instance is a FirewallApi");
        }

        
        /// <summary>
        /// Test CreateFirewallRule
        /// </summary>
        [Test]
        public void CreateFirewallRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //FirewallRule firewallRule = null;
            //instance.CreateFirewallRule(serverId, firewallRule);
            
        }
        
        /// <summary>
        /// Test DeleteFirewallRule
        /// </summary>
        [Test]
        public void DeleteFirewallRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //Guid? firewallRuleNumber = null;
            //instance.DeleteFirewallRule(serverId, firewallRuleNumber);
            
        }
        
        /// <summary>
        /// Test GetFirewallRule
        /// </summary>
        [Test]
        public void GetFirewallRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //Guid? firewallRuleNumber = null;
            //var response = instance.GetFirewallRule(serverId, firewallRuleNumber);
            //Assert.IsInstanceOf<FirewallRuleDetailsResponse> (response, "response is FirewallRuleDetailsResponse");
        }
        
        /// <summary>
        /// Test ServerServerIdFirewallRuleGet
        /// </summary>
        [Test]
        public void ServerServerIdFirewallRuleGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //var response = instance.ServerServerIdFirewallRuleGet(serverId);
            //Assert.IsInstanceOf<FirewallRuleListResponse> (response, "response is FirewallRuleListResponse");
        }
        
    }

}
