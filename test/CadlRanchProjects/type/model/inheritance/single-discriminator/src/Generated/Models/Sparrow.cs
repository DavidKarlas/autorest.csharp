// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace _Type.Model.Inheritance.SingleDiscriminator.Models
{
    /// <summary> The second level model in polymorphic single level inheritance. </summary>
    public partial class Sparrow : Bird
    {
        /// <summary> Initializes a new instance of Sparrow. </summary>
        /// <param name="wingspan"></param>
        public Sparrow(int wingspan) : base(wingspan)
        {
            Kind = "sparrow";
        }

        /// <summary> Initializes a new instance of Sparrow. </summary>
        /// <param name="kind"></param>
        /// <param name="wingspan"></param>
        internal Sparrow(string kind, int wingspan) : base(kind, wingspan)
        {
        }
    }
}
