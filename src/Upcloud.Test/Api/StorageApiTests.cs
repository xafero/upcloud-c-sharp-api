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
    private Server testServer;
    private Storage testStorage;

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
      //Assert.IsInstanceOfType(typeof(StorageApi), instance, "instance is a StorageApi");
    }


    /// <summary>
    /// Test AttachStorage
    /// </summary>
    [Test]
    public void AttachStorageTest()
    {
      var serverId = testServer.uuid;
      var storageDevice = new StorageDevice
      {
        storage = testStorage.uuid.ToString(),
        address = "scsi:0:0",
        type = "disk"
      };
      var response = instance.AttachStorage(serverId, new AttachStorageDeviceRequest { storageDevice = (storageDevice) });
      var server = response.server;
      Assert.True(server
              .storageDevices
              .storageDevice
              .Any(item => item.storageTitle.Equals("Test create storage storage"))
      );
      server = instance.DetachStorage(serverId, new StorageDeviceDetachRequest { storageDevice = new StorageDevice { address = "scsi:0:0" } }).server;
      Assert.False(
              server
                      .storageDevices
                      .storageDevice.Any(item => item.address.Equals("scsi:0:0"))
      );
    }

    /// <summary>
    /// Test BackupStorage
    /// </summary>
    [Test]
    public void BackupStorageTest()
    {
      var storageId = testStorage.uuid;
      var response = instance.BackupStorage(storageId, new CreateBackupStorageRequest
      {
        storage =
            new Storage { title = ("Test backup") }

      });
      var storage = response.storage;

      Assert.AreEqual(testStorage.access, storage.access);
      Assert.AreEqual(testStorage.license, storage.license);
      Assert.AreEqual(testStorage.uuid, storage.origin);
      Assert.AreEqual("Test backup", storage.title);
    }

    /// <summary>
    /// Test CancelOperation
    /// </summary>
    [Test]
    public void CancelOperationTest()
    {
      var storageId = testStorage.uuid;
      var clonedStorage = new Storage
      {
        title = ("Cloned storage"),
        zone = ("fi-hel1"),
        tier = (StorageTier.Maxiops),
      };
      var response = instance.CloneStorage(storageId, new CloneStorageRequest { storage = (clonedStorage) });
      clonedStorage = response.storage;
      instance.CancelOperation(clonedStorage.uuid);
      var clonedStorageId = clonedStorage.uuid;

      Assert.AreEqual(instance.GetStorageDetails(clonedStorageId).storage.state, StorageState.Maintenance);
    }

    /// <summary>
    /// Test CloneStorage
    /// </summary>
    [Test]
    public void CloneStorageTest()
    {
      var storageId = testStorage.uuid;
      var clonedStorage = new Storage
      {
        title = ("Cloned storage"),
        zone = ("fi-hel1"),
        tier = (StorageTier.Maxiops)
      };
      var response = instance.CloneStorage(storageId, new CloneStorageRequest { storage = (clonedStorage) });
      clonedStorage = response.storage;

      Assert.Null(clonedStorage.origin);
      Assert.AreEqual("Cloned storage", clonedStorage.title);
      Utils.deleteStorage(clonedStorage);
    }

    /// <summary>
    /// Test CreateStorage
    /// </summary>
    [Test]
    public void CreateStorageTest()
    {
      var storage = new Storage
      {
        size = 10,
        tier = (StorageTier.Maxiops),
        title = ("Test create storage storage"),
        zone = ("fi-hel1"),
        backupRule = new BackupRule
        {
          interval = (BackupRule.IntervalEnum.Daily),
          time = ("0430"),
          retention = (365)
        }
      };
      var response = instance.CreateStorage(new CreateStorageRequest { storage = (storage) });
      storage = response.storage;

      Assert.AreEqual(StorageAccessType.Private, storage.access);
      Assert.NotNull(storage.backupRule);
      Assert.NotNull(storage.backups);
      Assert.Equals(0, storage.license);
      Assert.NotNull(storage.servers);
      Assert.Equals((10), storage.size);
      Assert.Equals(StorageState.Online, storage.state);
      Assert.Equals(StorageTier.Maxiops, storage.tier);
      Assert.Equals("Test create storage storage", storage.title);
      Assert.Equals(StorageType.Normal, storage.type);
      Assert.NotNull(storage.uuid);
      Assert.NotNull(storage.zone);

      instance.DeleteStorage(storage.uuid);
    }

    /// <summary>
    /// Test DeleteStorage
    /// </summary>
    [Test]
    public void DeleteStorageTest()
    {
      var storageId = testStorage.uuid;
      instance.DeleteStorage(storageId);

      var exception = Assert.Throws<ApiException>(() => instance.GetStorageDetails(storageId));
      Assert.AreEqual("Not Found", exception.Message);
      Assert.AreEqual(404, exception.ErrorCode);
      testStorage = null;
    }

    /// <summary>
    /// Test DetachStorage
    /// </summary>
    [Test]
    public void EjectCdromTest()
    {
      var serverId = testServer.uuid;
      var storageDevice = new StorageDevice
      {
        storage = (testStorage.uuid.ToString()),
        address = ("scsi:0:0"),
        type = ("cdrom")
      };
      instance.AttachStorage(serverId, new AttachStorageDeviceRequest { storageDevice = (storageDevice) });
      instance.EjectCdrom(serverId);
      var serverApi = new ServerApi();
      var server = serverApi.ServerDetails(serverId).server;
      instance.DetachStorage(serverId, new StorageDeviceDetachRequest
      {
        storageDevice = (new StorageDevice { address = ("scsi:0:0") })
      });

      Assert.True(server
              .storageDevices
              .storageDevice
              .Any(storage => storage.type.Equals("cdrom") && storage.storage.Equals("")));
    }

    /// <summary>
    /// Test FavoriteStorage
    /// </summary>
    [Test]
    public void FavoriteStorageTest()
    {
      var storageId = testStorage.uuid;
      var favoritedStorages = instance.ListStorageTypes("favorite").storages.storage;
      var favoritesCount = favoritedStorages.Count;
      instance.FavoriteStorage(storageId);
      favoritedStorages = instance.ListStorageTypes("favorite").storages.storage;
      Assert.AreEqual(favoritesCount + 1, favoritedStorages.Count);

    }

    /// <summary>
    /// Test GetStorageDetails
    /// </summary>
    [Test]
    public void GetStorageDetailsTest()
    {
      var storageId = testStorage.uuid;
      var response = instance.GetStorageDetails(storageId);
      var storage = response.storage;

      Assert.AreEqual("Test create storage storage", storage.title);
    }

    /// <summary>
    /// Test ListStorages
    /// </summary>
    [Test]
    public void ListStoragesTest()
    {
      var response = instance.ListStorages();
      var storageList = response.storages.storage;

      Assert.True(storageList.Count > 0);
      Assert.True(storageList.Any(storage => storage.title.Equals("Test create storage storage")));
    }

    /// <summary>
    /// Test ModifyStorage
    /// </summary>
    [Test]
    public void ModifyStorageTest()
    {
      var storageId = testStorage.uuid;
      var response = instance.ModifyStorage(storageId, new ModifyStorageRequest
      {
        storage = new Storage
        {
          title = ("Modified title")
        }
      });
      var modifiedStorage = response.storage;

      Assert.AreEqual("Modified title", modifiedStorage.title);
    }

  }

}
