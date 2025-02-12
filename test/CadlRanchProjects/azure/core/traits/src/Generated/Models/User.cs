// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace _Specs_.Azure.Core.Traits.Models
{
    /// <summary> Sample Model. </summary>
    public partial class User
    {
        /// <summary> Initializes a new instance of User. </summary>
        internal User()
        {
        }

        /// <summary> Initializes a new instance of User. </summary>
        /// <param name="id"> The user's id. </param>
        /// <param name="name"> The user's name. </param>
        internal User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary> The user's id. </summary>
        public int Id { get; }
        /// <summary> The user's name. </summary>
        public string Name { get; }
    }
}
