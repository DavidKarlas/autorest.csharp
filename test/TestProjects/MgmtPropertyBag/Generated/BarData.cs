// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtPropertyBag
{
    /// <summary>
    /// A class representing the Bar data model.
    /// Bar instance details.
    /// </summary>
    public partial class BarData : ResourceData
    {
        /// <summary> Initializes a new instance of BarData. </summary>
        public BarData()
        {
        }

        /// <summary> Initializes a new instance of BarData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="details"> The details of the resource. </param>
        internal BarData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string details) : base(id, name, resourceType, systemData)
        {
            Details = details;
        }

        /// <summary> The details of the resource. </summary>
        public string Details { get; set; }
    }
}
