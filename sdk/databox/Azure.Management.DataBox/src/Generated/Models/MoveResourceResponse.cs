// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Response of move resource. </summary>
    internal partial class MoveResourceResponse
    {
        /// <summary> Initializes a new instance of MoveResourceResponse. </summary>
        internal MoveResourceResponse()
        {
        }

        /// <summary> Initializes a new instance of MoveResourceResponse. </summary>
        /// <param name="updatedResourceId"> . </param>
        internal MoveResourceResponse(IReadOnlyList<string> updatedResourceId)
        {
            UpdatedResourceId = updatedResourceId;
        }

        public IReadOnlyList<string> UpdatedResourceId { get; set; }
    }
}
