// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// the statistics information for resource usage.
    /// </summary>
    public partial class ResourceUsageStatistics
    {
        /// <summary>
        /// Initializes a new instance of the ResourceUsageStatistics class.
        /// </summary>
        public ResourceUsageStatistics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceUsageStatistics class.
        /// </summary>
        /// <param name="average">the average value.</param>
        /// <param name="minimum">the minimum value.</param>
        /// <param name="maximum">the maximum value.</param>
        public ResourceUsageStatistics(double? average = default(double?), long? minimum = default(long?), long? maximum = default(long?))
        {
            Average = average;
            Minimum = minimum;
            Maximum = maximum;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the average value.
        /// </summary>
        [JsonProperty(PropertyName = "average")]
        public double? Average { get; private set; }

        /// <summary>
        /// Gets the minimum value.
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public long? Minimum { get; private set; }

        /// <summary>
        /// Gets the maximum value.
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public long? Maximum { get; private set; }

    }
}
