// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A process exit code and how the Batch service should respond if a task exits with that exit code.
    /// </summary>
    public partial class ExitCodeMapping : ITransportObjectProvider<Models.ExitCodeMapping>, IPropertyMetadata
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ExitCodeMapping"/> class.
        /// </summary>
        /// <param name='code'>The process exit code.</param>
        /// <param name='exitOptions'>How the Batch service should respond if the task exits with this exit code.</param>
        public ExitCodeMapping(
            int code,
            ExitOptions exitOptions)
        {
            this.Code = code;
            this.ExitOptions = exitOptions;
        }

        internal ExitCodeMapping(Models.ExitCodeMapping protocolObject)
        {
            this.Code = protocolObject.Code;
            this.ExitOptions = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ExitOptions, o => new ExitOptions(o).Freeze());
        }

        #endregion Constructors

        #region ExitCodeMapping

        /// <summary>
        /// Gets the process exit code.
        /// </summary>
        public int Code { get; }

        /// <summary>
        /// Gets how the Batch service should respond if the task exits with this exit code.
        /// </summary>
        public ExitOptions ExitOptions { get; }

        #endregion // ExitCodeMapping

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.ExitCodeMapping ITransportObjectProvider<Models.ExitCodeMapping>.GetTransportObject()
        {
            Models.ExitCodeMapping result = new Models.ExitCodeMapping()
            {
                Code = this.Code,
                ExitOptions = UtilitiesInternal.CreateObjectWithNullCheck(this.ExitOptions, (o) => o.GetTransportObject()),
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<ExitCodeMapping> ConvertFromProtocolCollection(IEnumerable<Models.ExitCodeMapping> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ExitCodeMapping> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ExitCodeMapping(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<ExitCodeMapping> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.ExitCodeMapping> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ExitCodeMapping> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ExitCodeMapping(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<ExitCodeMapping> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.ExitCodeMapping> protoCollection)
        {
            IReadOnlyList<ExitCodeMapping> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new ExitCodeMapping(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}