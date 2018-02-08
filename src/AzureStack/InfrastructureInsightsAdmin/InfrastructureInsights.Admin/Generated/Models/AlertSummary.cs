// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.InfrastructureInsights.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.InfrastructureInsights;
    using Microsoft.AzureStack.Management.InfrastructureInsights.Admin;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Summary of the alerts.
    /// </summary>
    public partial class AlertSummary
    {
        /// <summary>
        /// Initializes a new instance of the AlertSummary class.
        /// </summary>
        public AlertSummary()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertSummary class.
        /// </summary>
        /// <param name="criticalAlertCount">How many critical alerts this
        /// service has.</param>
        /// <param name="warningAlertCount">How many warning alerts this
        /// service has.</param>
        public AlertSummary(int? criticalAlertCount = default(int?), int? warningAlertCount = default(int?))
        {
            CriticalAlertCount = criticalAlertCount;
            WarningAlertCount = warningAlertCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets how many critical alerts this service has.
        /// </summary>
        [JsonProperty(PropertyName = "criticalAlertCount")]
        public int? CriticalAlertCount { get; set; }

        /// <summary>
        /// Gets or sets how many warning alerts this service has.
        /// </summary>
        [JsonProperty(PropertyName = "warningAlertCount")]
        public int? WarningAlertCount { get; set; }

    }
}
