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
    ///  Class for testing IPAddressApi
    /// </summary>
    [TestFixture]
    public class IPAddressApiTests
    {
        private IPAddressApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IPAddressApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IPAddressApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IPAddressApi
            //Assert.IsInstanceOfType(typeof(IPAddressApi), instance, "instance is a IPAddressApi");
        }

        
        /// <summary>
        /// Test AddIp
        /// </summary>
        [Test]
        public void AddIpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IpAddress ipAddress = null;
            //var response = instance.AddIp(ipAddress);
            //Assert.IsInstanceOf<AssignIpResponse> (response, "response is AssignIpResponse");
        }
        
        /// <summary>
        /// Test DeleteIp
        /// </summary>
        [Test]
        public void DeleteIpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ip = null;
            //instance.DeleteIp(ip);
            
        }
        
        /// <summary>
        /// Test GetDetails
        /// </summary>
        [Test]
        public void GetDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ip = null;
            //var response = instance.GetDetails(ip);
            //Assert.IsInstanceOf<AssignIpResponse> (response, "response is AssignIpResponse");
        }
        
        /// <summary>
        /// Test ListIps
        /// </summary>
        [Test]
        public void ListIpsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListIps();
            //Assert.IsInstanceOf<IpAddressListResponse> (response, "response is IpAddressListResponse");
        }
        
        /// <summary>
        /// Test ModifyIp
        /// </summary>
        [Test]
        public void ModifyIpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ip = null;
            //IpAddress1 ipAddress = null;
            //var response = instance.ModifyIp(ip, ipAddress);
            //Assert.IsInstanceOf<AssignIpResponse> (response, "response is AssignIpResponse");
        }
        
    }

}
