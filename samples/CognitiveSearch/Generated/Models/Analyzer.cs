// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace CognitiveSearch.Models
{
    /// <summary>
    /// Base type for analyzers.
    /// Please note <see cref="Analyzer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CustomAnalyzer"/>, <see cref="PatternAnalyzer"/>, <see cref="StandardAnalyzer"/> and <see cref="StopAnalyzer"/>.
    /// </summary>
    public partial class Analyzer
    {
        /// <summary> Initializes a new instance of Analyzer. </summary>
        /// <param name="name"> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Analyzer(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of Analyzer. </summary>
        /// <param name="odataType"> Identifies the concrete type of the analyzer. </param>
        /// <param name="name"> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal Analyzer(string odataType, string name)
        {
            OdataType = odataType;
            Name = name;
        }

        /// <summary> Identifies the concrete type of the analyzer. </summary>
        internal string OdataType { get; set; }
        /// <summary> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </summary>
        public string Name { get; set; }
    }
}
