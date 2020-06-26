// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.DataBox.Models
{
    /// <summary> Type of the share. </summary>
    public enum ShareDestinationFormatType
    {
        /// <summary> Unknown format. </summary>
        UnknownType,
        /// <summary> Storsimple data format. </summary>
        HCS,
        /// <summary> Azure storage block blob format. </summary>
        BlockBlob,
        /// <summary> Azure storage page blob format. </summary>
        PageBlob,
        /// <summary> Azure storage file format. </summary>
        AzureFile,
        /// <summary> Azure Compute Disk. </summary>
        ManagedDisk
    }
}
