// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Additional error info. </summary>
    public partial class AdditionalErrorInfo
    {
        /// <summary> Initializes a new instance of AdditionalErrorInfo. </summary>
        public AdditionalErrorInfo()
        {
        }

        /// <summary> Initializes a new instance of AdditionalErrorInfo. </summary>
        /// <param name="type"> Additional error type. </param>
        /// <param name="info"> Additional error info. </param>
        internal AdditionalErrorInfo(string type, object info)
        {
            Type = type;
            Info = info;
        }

        /// <summary> Additional error type. </summary>
        public string Type { get; set; }
        /// <summary> Additional error info. </summary>
        public object Info { get; set; }
    }
}
