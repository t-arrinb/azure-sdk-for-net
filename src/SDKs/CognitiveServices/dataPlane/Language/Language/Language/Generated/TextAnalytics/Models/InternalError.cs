// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.CognitiveServices;
    using Microsoft.Azure.CognitiveServices.Language;
    using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class InternalError
    {
        /// <summary>
        /// Initializes a new instance of the InternalError class.
        /// </summary>
        public InternalError()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InternalError class.
        /// </summary>
        public InternalError(string code = default(string), string message = default(string), InternalError innerError = default(InternalError))
        {
            Code = code;
            Message = message;
            InnerError = innerError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "innerError")]
        public InternalError InnerError { get; set; }

    }
}
