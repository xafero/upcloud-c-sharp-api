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
    ///  Class for testing ServerApi
    /// </summary>
    [TestFixture]
    public class ServerApiTests
    {
        private ServerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ServerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ServerApi
            //Assert.IsInstanceOfType(typeof(ServerApi), instance, "instance is a ServerApi");
        }

        
        /// <summary>
        /// Test AssignTag
        /// </summary>
        [Test]
        public void AssignTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //string tagList = null;
            //var response = instance.AssignTag(serverId, tagList);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
        /// <summary>
        /// Test AttachStorage
        /// </summary>
        [Test]
        public void AttachStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //StorageDevice storageDevice = null;
            //var response = instance.AttachStorage(serverId, storageDevice);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
        /// <summary>
        /// Test CreateFirewallRule
        /// </summary>
        [Test]
        public void CreateFirewallRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //FirewallRuleRequest firewallRule = null;
            //var response = instance.CreateFirewallRule(serverId, firewallRule);
            //Assert.IsInstanceOf<FirewallRuleCreateResponse> (response, "response is FirewallRuleCreateResponse");
        }
        
        /// <summary>
        /// Test CreateServer
        /// </summary>
        [Test]
        public void CreateServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Server server = null;
            //var response = instance.CreateServer(server);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
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
        /// Test DeleteServer
        /// </summary>
        [Test]
        public void DeleteServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //instance.DeleteServer(serverId);
            
        }
        
        /// <summary>
        /// Test DetachStorage
        /// </summary>
        [Test]
        public void DetachStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //StorageDevice storageDevice = null;
            //var response = instance.DetachStorage(serverId, storageDevice);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
        /// <summary>
        /// Test EjectCdrom
        /// </summary>
        [Test]
        public void EjectCdromTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //var response = instance.EjectCdrom(serverId);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
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
            //Assert.IsInstanceOf<FirewallRuleCreateResponse> (response, "response is FirewallRuleCreateResponse");
        }
        
        /// <summary>
        /// Test ListServerConfigurations
        /// </summary>
        [Test]
        public void ListServerConfigurationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListServerConfigurations();
            //Assert.IsInstanceOf<ConfigurationListResponse> (response, "response is ConfigurationListResponse");
        }
        
        /// <summary>
        /// Test ListServers
        /// </summary>
        [Test]
        public void ListServersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListServers();
            //Assert.IsInstanceOf<ServerListResponse> (response, "response is ServerListResponse");
        }
        
        /// <summary>
        /// Test LoadCdrom
        /// </summary>
        [Test]
        public void LoadCdromTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //StorageDevice1 storageDevice = null;
            //var response = instance.LoadCdrom(serverId, storageDevice);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
        /// <summary>
        /// Test ModifyServer
        /// </summary>
        [Test]
        public void ModifyServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //Server server = null;
            //var response = instance.ModifyServer(serverId, server);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
        /// <summary>
        /// Test RestartServer
        /// </summary>
        [Test]
        public void RestartServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //RestartServer restartServer = null;
            //var response = instance.RestartServer(serverId, restartServer);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
        /// <summary>
        /// Test ServerDetails
        /// </summary>
        [Test]
        public void ServerDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //var response = instance.ServerDetails(serverId);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
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
        
        /// <summary>
        /// Test StartServer
        /// </summary>
        [Test]
        public void StartServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //var response = instance.StartServer(serverId);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
        /// <summary>
        /// Test StopServer
        /// </summary>
        [Test]
        public void StopServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //StopServer stopServer = null;
            //var response = instance.StopServer(serverId, stopServer);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
        /// <summary>
        /// Test Untag
        /// </summary>
        [Test]
        public void UntagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? serverId = null;
            //string tagName = null;
            //var response = instance.Untag(serverId, tagName);
            //Assert.IsInstanceOf<CreateServerResponse> (response, "response is CreateServerResponse");
        }
        
    }

}
