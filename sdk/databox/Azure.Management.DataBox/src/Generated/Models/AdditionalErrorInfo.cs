// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> The AdditionalErrorInfo. </summary>
    public partial class AdditionalErrorInfo
    {
        /// <summary> Initializes a new instance of AdditionalErrorInfo. </summary>
        public AdditionalErrorInfo()
        {
        }

        /// <summary> Initializes a new instance of AdditionalErrorInfo. </summary>
        /// <param name="type"> Error type. </param>
        /// <param name="info"> Any object. </param>
        internal AdditionalErrorInfo(string type, object info)
        {
            Type = type;
            Info = info;
        }

        /// <summary> Error type. </summary>
        public string Type { get; set; }
        /// <summary> Any object. </summary>
        public object Info { get; set; }
    }
}
