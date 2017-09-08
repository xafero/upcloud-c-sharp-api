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
    ///  Class for testing StorageApi
    /// </summary>
    [TestFixture]
    public class StorageApiTests
    {
        private StorageApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StorageApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StorageApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StorageApi
            //Assert.IsInstanceOfType(typeof(StorageApi), instance, "instance is a StorageApi");
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
            //Assert.IsInstanceOf<ServerListResponse> (response, "response is ServerListResponse");
        }
        
        /// <summary>
        /// Test BackupStorage
        /// </summary>
        [Test]
        public void BackupStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //Storage4 storage = null;
            //var response = instance.BackupStorage(storageId, storage);
            //Assert.IsInstanceOf<CreateStorageResponse> (response, "response is CreateStorageResponse");
        }
        
        /// <summary>
        /// Test CancelOperation
        /// </summary>
        [Test]
        public void CancelOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //instance.CancelOperation(storageId);
            
        }
        
        /// <summary>
        /// Test CloneStorage
        /// </summary>
        [Test]
        public void CloneStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //Storage2 storage = null;
            //var response = instance.CloneStorage(storageId, storage);
            //Assert.IsInstanceOf<CreateStorageResponse> (response, "response is CreateStorageResponse");
        }
        
        /// <summary>
        /// Test CreateStorage
        /// </summary>
        [Test]
        public void CreateStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Storage storage = null;
            //var response = instance.CreateStorage(storage);
            //Assert.IsInstanceOf<CreateStorageResponse> (response, "response is CreateStorageResponse");
        }
        
        /// <summary>
        /// Test DeleteStorage
        /// </summary>
        [Test]
        public void DeleteStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //instance.DeleteStorage(storageId);
            
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
            //Assert.IsInstanceOf<ServerListResponse> (response, "response is ServerListResponse");
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
            //Assert.IsInstanceOf<ServerListResponse> (response, "response is ServerListResponse");
        }
        
        /// <summary>
        /// Test FavoriteStorage
        /// </summary>
        [Test]
        public void FavoriteStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //instance.FavoriteStorage(storageId);
            
        }
        
        /// <summary>
        /// Test GetStorageDetails
        /// </summary>
        [Test]
        public void GetStorageDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //var response = instance.GetStorageDetails(storageId);
            //Assert.IsInstanceOf<CreateStorageResponse> (response, "response is CreateStorageResponse");
        }
        
        /// <summary>
        /// Test ListStorageTypes
        /// </summary>
        [Test]
        public void ListStorageTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //var response = instance.ListStorageTypes(type);
            //Assert.IsInstanceOf<SuccessStoragesResponse> (response, "response is SuccessStoragesResponse");
        }
        
        /// <summary>
        /// Test ListStorages
        /// </summary>
        [Test]
        public void ListStoragesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListStorages();
            //Assert.IsInstanceOf<SuccessStoragesResponse> (response, "response is SuccessStoragesResponse");
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
            //Assert.IsInstanceOf<ServerListResponse> (response, "response is ServerListResponse");
        }
        
        /// <summary>
        /// Test ModifyStorage
        /// </summary>
        [Test]
        public void ModifyStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //Storage1 storage = null;
            //var response = instance.ModifyStorage(storageId, storage);
            //Assert.IsInstanceOf<CreateStorageResponse> (response, "response is CreateStorageResponse");
        }
        
        /// <summary>
        /// Test RestoreStorage
        /// </summary>
        [Test]
        public void RestoreStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //instance.RestoreStorage(storageId);
            
        }
        
        /// <summary>
        /// Test TemplatizeStorage
        /// </summary>
        [Test]
        public void TemplatizeStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //Storage3 storage = null;
            //var response = instance.TemplatizeStorage(storageId, storage);
            //Assert.IsInstanceOf<CreateStorageResponse> (response, "response is CreateStorageResponse");
        }
        
        /// <summary>
        /// Test UnfavoriteStorage
        /// </summary>
        [Test]
        public void UnfavoriteStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? storageId = null;
            //instance.UnfavoriteStorage(storageId);
            
        }
        
    }

}
