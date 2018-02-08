// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for FirewallState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FirewallState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class FirewallStateEnumExtension
    {
        internal static string ToSerializedValue(this FirewallState? value)
        {
            return value == null ? null : ((FirewallState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FirewallState value)
        {
            switch( value )
            {
                case FirewallState.Enabled:
                    return "Enabled";
                case FirewallState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static FirewallState? ParseFirewallState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return FirewallState.Enabled;
                case "Disabled":
                    return FirewallState.Disabled;
            }
            return null;
        }
    }
}
