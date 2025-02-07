// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using MgmtMockAndSample;
using MgmtMockAndSample.Models;

namespace MgmtMockAndSample.Tests.Mock
{
    /// <summary> Test for FirewallPolicyRuleCollectionGroupResource. </summary>
    public partial class FirewallPolicyRuleCollectionGroupResourceMockTests : MockTestBase
    {
        public FirewallPolicyRuleCollectionGroupResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete FirewallPolicyRuleCollectionGroup

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleCollectionGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.DeleteAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task Get_GetFirewallPolicyNatRuleCollectionGroup()
        {
            // Example: Get FirewallPolicyNatRuleCollectionGroup

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleCollectionGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.GetAsync();
        }

        [RecordedTest]
        public async Task Get_GetFirewallPolicyRuleCollectionGroup()
        {
            // Example: Get FirewallPolicyRuleCollectionGroup

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleCollectionGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.GetAsync();
        }

        [RecordedTest]
        public async Task Get_GetFirewallPolicyRuleCollectionGroupWithIpGroups()
        {
            // Example: Get FirewallPolicyRuleCollectionGroup With IpGroups

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.GetAsync();
        }

        [RecordedTest]
        public async Task Get_GetFirewallPolicyRuleCollectionGroupWithWebCategories()
        {
            // Example: Get FirewallPolicyRuleCollectionGroup With Web Categories

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleCollectionGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.GetAsync();
        }

        [RecordedTest]
        public async Task Update_CreateFirewallPolicyNatRuleCollectionGroup()
        {
            // Example: Create FirewallPolicyNatRuleCollectionGroup

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleCollectionGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, new FirewallPolicyRuleCollectionGroupData()
            {
                Priority = 100,
                RuleCollections =
{
new FirewallPolicyNatRuleCollection()
{
ActionType = FirewallPolicyNatRuleCollectionActionType.Dnat,
Rules =
{
new NatRule()
{
IpProtocols =
{
FirewallPolicyRuleNetworkProtocol.TCP,FirewallPolicyRuleNetworkProtocol.UDP
},
SourceAddresses =
{
"2.2.2.2"
},
DestinationAddresses =
{
"152.23.32.23"
},
DestinationPorts =
{
"8080"
},
TranslatedPort = "8080",
SourceIpGroups =
{
},
TranslatedFqdn = "internalhttp.server.net",
Name = "nat-rule1",
}
},
Name = "Example-Nat-Rule-Collection",
Priority = 100,
}
},
            });
        }

        [RecordedTest]
        public async Task Update_CreateFirewallPolicyRuleCollectionGroup()
        {
            // Example: Create FirewallPolicyRuleCollectionGroup

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleCollectionGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, new FirewallPolicyRuleCollectionGroupData()
            {
                Priority = 100,
                RuleCollections =
{
new FirewallPolicyFilterRuleCollection()
{
ActionType = FirewallPolicyFilterRuleCollectionActionType.Deny,
Rules =
{
new NetworkRule()
{
IpProtocols =
{
FirewallPolicyRuleNetworkProtocol.TCP
},
SourceAddresses =
{
"10.1.25.0/24"
},
DestinationAddresses =
{
"*"
},
DestinationPorts =
{
"*"
},
Name = "network-rule1",
}
},
Name = "Example-Filter-Rule-Collection",
Priority = 100,
}
},
            });
        }

        [RecordedTest]
        public async Task Update_CreateFirewallPolicyRuleCollectionGroupWithAllDefaultValues()
        {
            // Example: Create FirewallPolicyRuleCollectionGroup With All Default Values

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleCollectionGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, new FirewallPolicyRuleCollectionGroupData());
        }

        [RecordedTest]
        public async Task Update_CreateFirewallPolicyRuleCollectionGroupWithIpGroups()
        {
            // Example: Create FirewallPolicyRuleCollectionGroup With IpGroups

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleCollectionGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, new FirewallPolicyRuleCollectionGroupData()
            {
                Priority = 110,
                RuleCollections =
{
new FirewallPolicyFilterRuleCollection()
{
ActionType = FirewallPolicyFilterRuleCollectionActionType.Deny,
Rules =
{
new NetworkRule()
{
IpProtocols =
{
FirewallPolicyRuleNetworkProtocol.TCP
},
DestinationPorts =
{
"*"
},
SourceIpGroups =
{
"/subscriptions/subid/providers/Microsoft.Network/resourceGroup/rg1/ipGroups/ipGroups1"
},
DestinationIpGroups =
{
"/subscriptions/subid/providers/Microsoft.Network/resourceGroup/rg1/ipGroups/ipGroups2"
},
Name = "network-1",
}
},
Name = "Example-Filter-Rule-Collection",
}
},
            });
        }

        [RecordedTest]
        public async Task Update_CreateFirewallPolicyRuleCollectionGroupWithWebCategories()
        {
            // Example: Create FirewallPolicyRuleCollectionGroup With Web Categories

            ResourceIdentifier firewallPolicyRuleCollectionGroupResourceId = FirewallPolicyRuleCollectionGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "rg1", "firewallPolicy", "ruleCollectionGroup1");
            FirewallPolicyRuleCollectionGroupResource firewallPolicyRuleCollectionGroup = GetArmClient().GetFirewallPolicyRuleCollectionGroupResource(firewallPolicyRuleCollectionGroupResourceId);
            await firewallPolicyRuleCollectionGroup.UpdateAsync(WaitUntil.Completed, new FirewallPolicyRuleCollectionGroupData()
            {
                Priority = 110,
                RuleCollections =
{
new FirewallPolicyFilterRuleCollection()
{
ActionType = FirewallPolicyFilterRuleCollectionActionType.Deny,
Rules =
{
new ApplicationRule()
{
SourceAddresses =
{
"216.58.216.164","10.0.0.0/24"
},
Protocols =
{
new FirewallPolicyRuleApplicationProtocol()
{
ProtocolType = FirewallPolicyRuleApplicationProtocolType.Https,
Port = 443,
}
},
WebCategories =
{
"Hacking"
},
Name = "rule1",
Description = "Deny inbound rule",
}
},
Name = "Example-Filter-Rule-Collection",
}
},
            });
        }
    }
}
