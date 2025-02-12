// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using MgmtHierarchicalNonResource;

namespace MgmtHierarchicalNonResource.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMgmtHierarchicalNonResourceModelFactory
    {
        /// <summary> Initializes a new instance of SharedGalleryData. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="uniqueId"> The unique id of this shared gallery. </param>
        /// <returns> A new <see cref="MgmtHierarchicalNonResource.SharedGalleryData"/> instance for mocking. </returns>
        public static SharedGalleryData SharedGalleryData(string name = null, string location = null, string uniqueId = null)
        {
            return new SharedGalleryData(name, location, uniqueId);
        }

        /// <summary> Initializes a new instance of PirSharedGalleryResource. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="uniqueId"> The unique id of this shared gallery. </param>
        /// <returns> A new <see cref="Models.PirSharedGalleryResource"/> instance for mocking. </returns>
        public static PirSharedGalleryResource PirSharedGalleryResource(string name = null, string location = null, string uniqueId = null)
        {
            return new PirSharedGalleryResource(name, location, uniqueId);
        }

        /// <summary> Initializes a new instance of PirResource. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <returns> A new <see cref="Models.PirResource"/> instance for mocking. </returns>
        public static PirResource PirResource(string name = null, string location = null)
        {
            return new PirResource(name, location);
        }

        /// <summary> Initializes a new instance of SharedGalleryImage. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="uniqueId"> The unique id of this shared gallery. </param>
        /// <param name="osType"> This property allows you to specify the type of the OS that is included in the disk when creating a VM from a managed image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </param>
        /// <param name="osState"> This property allows the user to specify whether the virtual machines created under this image are 'Generalized' or 'Specialized'. </param>
        /// <param name="endOfLifeOn"> The end of life date of the gallery image definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="identifier"> This is the gallery image definition identifier. </param>
        /// <param name="recommended"> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </param>
        /// <param name="disallowedDiskTypes"> Describes the disallowed disk types. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </param>
        /// <param name="features"> A list of gallery image features. </param>
        /// <param name="purchasePlan"> Describes the gallery image definition purchase plan. This is used by marketplace images. </param>
        /// <returns> A new <see cref="Models.SharedGalleryImage"/> instance for mocking. </returns>
        public static SharedGalleryImage SharedGalleryImage(string name = null, string location = null, string uniqueId = null, OperatingSystemType? osType = null, OperatingSystemStateType? osState = null, DateTimeOffset? endOfLifeOn = null, GalleryImageIdentifier identifier = null, RecommendedMachineConfiguration recommended = null, IEnumerable<string> disallowedDiskTypes = null, HyperVGeneration? hyperVGeneration = null, IEnumerable<GalleryImageFeature> features = null, ImagePurchasePlan purchasePlan = null)
        {
            disallowedDiskTypes ??= new List<string>();
            features ??= new List<GalleryImageFeature>();

            return new SharedGalleryImage(name, location, uniqueId, osType, osState, endOfLifeOn, identifier, recommended, disallowedDiskTypes != null ? new Disallowed(disallowedDiskTypes?.ToList()) : null, hyperVGeneration, features?.ToList(), purchasePlan);
        }

        /// <summary> Initializes a new instance of GalleryImageIdentifier. </summary>
        /// <param name="publisher"> The name of the gallery image definition publisher. </param>
        /// <param name="offer"> The name of the gallery image definition offer. </param>
        /// <param name="sku"> The name of the gallery image definition SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisher"/>, <paramref name="offer"/> or <paramref name="sku"/> is null. </exception>
        /// <returns> A new <see cref="Models.GalleryImageIdentifier"/> instance for mocking. </returns>
        public static GalleryImageIdentifier GalleryImageIdentifier(string publisher = null, string offer = null, string sku = null)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (offer == null)
            {
                throw new ArgumentNullException(nameof(offer));
            }
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            return new GalleryImageIdentifier(publisher, offer, sku);
        }

        /// <summary> Initializes a new instance of RecommendedMachineConfiguration. </summary>
        /// <param name="vCpus"> Describes the resource range. </param>
        /// <param name="memory"> Describes the resource range. </param>
        /// <returns> A new <see cref="Models.RecommendedMachineConfiguration"/> instance for mocking. </returns>
        public static RecommendedMachineConfiguration RecommendedMachineConfiguration(ResourceRange vCpus = null, ResourceRange memory = null)
        {
            return new RecommendedMachineConfiguration(vCpus, memory);
        }

        /// <summary> Initializes a new instance of ResourceRange. </summary>
        /// <param name="min"> The minimum number of the resource. </param>
        /// <param name="max"> The maximum number of the resource. </param>
        /// <returns> A new <see cref="Models.ResourceRange"/> instance for mocking. </returns>
        public static ResourceRange ResourceRange(int? min = null, int? max = null)
        {
            return new ResourceRange(min, max);
        }

        /// <summary> Initializes a new instance of GalleryImageFeature. </summary>
        /// <param name="name"> The name of the gallery image feature. </param>
        /// <param name="value"> The value of the gallery image feature. </param>
        /// <returns> A new <see cref="Models.GalleryImageFeature"/> instance for mocking. </returns>
        public static GalleryImageFeature GalleryImageFeature(string name = null, string value = null)
        {
            return new GalleryImageFeature(name, value);
        }

        /// <summary> Initializes a new instance of ImagePurchasePlan. </summary>
        /// <param name="name"> The plan ID. </param>
        /// <param name="publisher"> The publisher ID. </param>
        /// <param name="product"> The product ID. </param>
        /// <returns> A new <see cref="Models.ImagePurchasePlan"/> instance for mocking. </returns>
        public static ImagePurchasePlan ImagePurchasePlan(string name = null, string publisher = null, string product = null)
        {
            return new ImagePurchasePlan(name, publisher, product);
        }

        /// <summary> Initializes a new instance of SharedGalleryImageVersion. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="uniqueId"> The unique id of this shared gallery. </param>
        /// <param name="publishedOn"> The published date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="endOfLifeOn"> The end of life date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <returns> A new <see cref="Models.SharedGalleryImageVersion"/> instance for mocking. </returns>
        public static SharedGalleryImageVersion SharedGalleryImageVersion(string name = null, string location = null, string uniqueId = null, DateTimeOffset? publishedOn = null, DateTimeOffset? endOfLifeOn = null)
        {
            return new SharedGalleryImageVersion(name, location, uniqueId, publishedOn, endOfLifeOn);
        }
    }
}
