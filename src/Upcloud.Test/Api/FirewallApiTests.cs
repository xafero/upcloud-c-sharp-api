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
    private Server testServer;
    private FirewallRule testFirewallRule;
    private List<FirewallRule> testFirewallRules = new List<FirewallRule>();
    /// <summary>
    /// Setup before each unit test
    /// </summary>
    [SetUp]
    public void Init()
    {
      instance = new FirewallApi
      {
        Configuration = {
                    Username = "toughbyte",
                    Password = "Topsekret5"
                }
      };

      Utils.deleteAllServers();

      StorageDevice testStorageDevice = new StorageDevice
      {
        action = "clone",
        title = "Debian from a template",
        size = 50,
        storage = "01000000-0000-4000-8000-000020030100",
        tier = "maxiops"
      };

      testServer = Utils.createReadyServer();

      testFirewallRule = new FirewallRule
      {
        position = (500),
        direction = FirewallRule.DirectionEnum.In,
        family = AddressFamily.IPv4,
        protocol = FirewallRule.ProtocolEnum.Tcp,
        sourceAddressStart = "192.168.1.1",
        sourceAddressEnd = "192.168.1.255",
        sourcePortStart = (1),
        sourcePortEnd = (32000),
        destinationPortStart = (22),
        destinationPortEnd = (22),
        action = FirewallRule.ActionEnum.Accept,
        comment = "Allow SSH from this network"
      };
    }

    /// <summary>
    /// Clean up after each unit test
    /// </summary>
    [TearDown]
    public void Cleanup()
    {
      Utils.deleteAllServers();
    }

    [TestFixtureSetUp]
    public void SetUpEach()
    {
      Guid? serverId = testServer.uuid;

      FirewallRule firewallRule = instance.CreateFirewallRule(
              serverId, new FirewallRuleRequest
              {
                firewallRule =
                      new FirewallRule
                      {
                        direction = FirewallRule.DirectionEnum.In,
                        family = AddressFamily.IPv4,
                        protocol = FirewallRule.ProtocolEnum.Tcp,
                        sourceAddressStart = "193.168.1.1",
                        sourceAddressEnd = "193.168.1.255",
                        sourcePortStart = 1,
                        sourcePortEnd = 32000,
                        destinationPortStart = 22,
                        destinationPortEnd = 22,
                        action = FirewallRule.ActionEnum.Accept,
                        comment = "Common firewall rule"
                      }
              }
      ).firewallRule;

      testFirewallRules.Add(firewallRule);
    }

    [TestFixtureTearDown]
    public void TearDownEach()
    {
      Guid? serverId = testServer.uuid;
      foreach (FirewallRule firewallRule in testFirewallRules)
      {
        instance.DeleteFirewallRule(serverId, firewallRule.position);
      }
      testFirewallRules.Clear();
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
      Guid? serverId = testServer.uuid;

      FirewallRule createdRule = instance.CreateFirewallRule(
              serverId,
              new FirewallRuleRequest
              {
                firewallRule = testFirewallRule
              }).firewallRule;

      Assert.AreEqual(createdRule.direction, FirewallRule.DirectionEnum.In);
      Assert.AreEqual(createdRule.action, FirewallRule.ActionEnum.Accept);
      Assert.AreEqual(createdRule.family, AddressFamily.IPv4);
      Assert.AreEqual(createdRule.icmpType, "");
      Assert.AreEqual(createdRule.destinationAddressStart, "");
      Assert.AreEqual(createdRule.destinationPortEnd, "");
      Assert.AreEqual(createdRule.destinationPortStart, "22");
      Assert.AreEqual(createdRule.destinationPortEnd, "22");
      Assert.AreEqual(createdRule.sourceAddressStart, "192.168.1.1");
      Assert.AreEqual(createdRule.sourceAddressEnd, "192.168.1.255");
      Assert.AreEqual(createdRule.sourcePortStart, (1));
      Assert.AreEqual(createdRule.sourcePortEnd, (32000));

      instance.DeleteFirewallRule(serverId, createdRule.position);
    }

    /// <summary>
    /// Test DeleteFirewallRule
    /// </summary>
    [Test]
    public void DeleteFirewallRuleTest()
    {
      Guid? serverId = testServer.uuid;
      var createdRule = instance.CreateFirewallRule(
              serverId,
              new FirewallRuleRequest { firewallRule = testFirewallRule }).firewallRule;
      var ruleForDelete = instance.GetFirewallRule(serverId, createdRule.position).firewallRule;
      Assert.AreEqual(createdRule.position, ruleForDelete.position);
      instance.DeleteFirewallRule(serverId, ruleForDelete.position);
      ApiException exception = Assert.Throws<ApiException>(() =>
                instance.GetFirewallRule(serverId, ruleForDelete.position)
        );
      Assert.AreEqual(exception.Message, "Not Found");

    }

    /// <summary>
    /// Test ServerServerIdFirewallRuleGet
    /// </summary>
    [Test]
    public void ServerServerIdFirewallRuleGetTest()
    {
      Guid? serverId = testServer.uuid;
      List<FirewallRule> firewallRules = instance.ServerServerIdFirewallRuleGet(serverId).firewallRules.firewallRule;

      Assert.True(firewallRules.Any(item => item.comment.Equals("Common firewall rule")));
    }

  }

}
