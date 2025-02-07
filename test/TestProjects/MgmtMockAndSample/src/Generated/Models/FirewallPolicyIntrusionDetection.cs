// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtMockAndSample.Models
{
    /// <summary> Configuration for intrusion detection mode and rules. </summary>
    public partial class FirewallPolicyIntrusionDetection
    {
        /// <summary> Initializes a new instance of FirewallPolicyIntrusionDetection. </summary>
        public FirewallPolicyIntrusionDetection()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyIntrusionDetection. </summary>
        /// <param name="mode"> Intrusion detection general state. </param>
        /// <param name="configuration"> Intrusion detection configuration properties. </param>
        internal FirewallPolicyIntrusionDetection(FirewallPolicyIntrusionDetectionStateType? mode, FirewallPolicyIntrusionDetectionConfiguration configuration)
        {
            Mode = mode;
            Configuration = configuration;
        }

        /// <summary> Intrusion detection general state. </summary>
        public FirewallPolicyIntrusionDetectionStateType? Mode { get; set; }
        /// <summary> Intrusion detection configuration properties. </summary>
        public FirewallPolicyIntrusionDetectionConfiguration Configuration { get; set; }
    }
}
