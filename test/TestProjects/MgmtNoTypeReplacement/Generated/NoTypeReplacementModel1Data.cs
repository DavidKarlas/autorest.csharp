// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace MgmtNoTypeReplacement
{
    /// <summary> A class representing the NoTypeReplacementModel1 data model. </summary>
    public partial class NoTypeReplacementModel1Data : ResourceData
    {
        /// <summary> Initializes a new instance of NoTypeReplacementModel1Data. </summary>
        public NoTypeReplacementModel1Data()
        {
        }

        /// <summary> Initializes a new instance of NoTypeReplacementModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="foo"> Gets or sets the foo. </param>
        internal NoTypeReplacementModel1Data(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SubResource foo) : base(id, name, resourceType, systemData)
        {
            Foo = foo;
        }

        /// <summary> Gets or sets the foo. </summary>
        internal SubResource Foo { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier FooId
        {
            get => Foo is null ? default : Foo.Id;
        }
    }
}
