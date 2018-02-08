// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Face list object.
    /// </summary>
    public partial class FaceList : NameAndUserDataContract
    {
        /// <summary>
        /// Initializes a new instance of the FaceList class.
        /// </summary>
        public FaceList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FaceList class.
        /// </summary>
        /// <param name="faceListId">FaceListId of the target face
        /// list.</param>
        /// <param name="name">User defined name, maximum length is
        /// 128.</param>
        /// <param name="userData">User specified data. Length should not
        /// exceed 16KB.</param>
        /// <param name="persistedFaces">Persisted faces within the face
        /// list.</param>
        public FaceList(string faceListId, string name = default(string), string userData = default(string), IList<PersistedFace> persistedFaces = default(IList<PersistedFace>))
            : base(name, userData)
        {
            FaceListId = faceListId;
            PersistedFaces = persistedFaces;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets faceListId of the target face list.
        /// </summary>
        [JsonProperty(PropertyName = "faceListId")]
        public string FaceListId { get; set; }

        /// <summary>
        /// Gets or sets persisted faces within the face list.
        /// </summary>
        [JsonProperty(PropertyName = "persistedFaces")]
        public IList<PersistedFace> PersistedFaces { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (FaceListId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FaceListId");
            }
            if (FaceListId != null)
            {
                if (FaceListId.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FaceListId", 64);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(FaceListId, "^[a-z0-9-_]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "FaceListId", "^[a-z0-9-_]+$");
                }
            }
            if (PersistedFaces != null)
            {
                foreach (var element in PersistedFaces)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
