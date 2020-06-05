// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.DataBox.Models
{
    /// <summary> Details of the filter files to be used for data transfer. </summary>
    public partial class FilterFileDetails
    {
        /// <summary> Initializes a new instance of FilterFileDetails. </summary>
        /// <param name="filterFileType"> Type of the filter file. </param>
        /// <param name="filterFilePath"> Path of the file that contains the details of all items to transfer. </param>
        public FilterFileDetails(FilterFileType filterFileType, string filterFilePath)
        {
            if (filterFilePath == null)
            {
                throw new ArgumentNullException(nameof(filterFilePath));
            }

            FilterFileType = filterFileType;
            FilterFilePath = filterFilePath;
        }

        /// <summary> Type of the filter file. </summary>
        public FilterFileType FilterFileType { get; set; }
        /// <summary> Path of the file that contains the details of all items to transfer. </summary>
        public string FilterFilePath { get; set; }
    }
}
