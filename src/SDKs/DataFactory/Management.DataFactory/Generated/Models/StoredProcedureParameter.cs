// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SQL stored procedure parameter.
    /// </summary>
    public partial class StoredProcedureParameter
    {
        /// <summary>
        /// Initializes a new instance of the StoredProcedureParameter class.
        /// </summary>
        public StoredProcedureParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StoredProcedureParameter class.
        /// </summary>
        /// <param name="value">Stored procedure parameter value. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="type">Stored procedure parameter type. Possible values
        /// include: 'String', 'Int', 'Decimal', 'Guid', 'Boolean',
        /// 'Date'</param>
        public StoredProcedureParameter(object value, string type = default(string))
        {
            Value = value;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets stored procedure parameter value. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets stored procedure parameter type. Possible values
        /// include: 'String', 'Int', 'Decimal', 'Guid', 'Boolean', 'Date'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
