// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Identifies the Azure key vault associated with a Batch account.
    /// </summary>
    public partial class KeyVaultReference
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultReference class.
        /// </summary>
        public KeyVaultReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultReference class.
        /// </summary>
        /// <param name="id">The resource ID of the Azure key vault associated
        /// with the Batch account.</param>
        /// <param name="url">The URL of the Azure key vault associated with
        /// the Batch account.</param>
        public KeyVaultReference(string id, string url)
        {
            Id = id;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the Azure key vault associated with
        /// the Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the URL of the Azure key vault associated with the
        /// Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
