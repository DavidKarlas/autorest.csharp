// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtResourceName
{
    /// <summary> A class representing the DisplayResource data model. </summary>
    public partial class DisplayResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of DisplayResourceData. </summary>
        public DisplayResourceData()
        {
        }

        /// <summary> Initializes a new instance of DisplayResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="new"></param>
        internal DisplayResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string @new) : base(id, name, resourceType, systemData)
        {
            New = @new;
        }

        /// <summary> Gets or sets the new. </summary>
        public string New { get; set; }
    }
}
