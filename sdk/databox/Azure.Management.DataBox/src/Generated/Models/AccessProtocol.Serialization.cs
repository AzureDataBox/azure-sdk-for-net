// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.DataBox.Models
{
    internal static class AccessProtocolExtensions
    {
        public static string ToSerialString(this AccessProtocol value) => value switch
        {
            AccessProtocol.SMB => "SMB",
            AccessProtocol.NFS => "NFS",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessProtocol value.")
        };

        public static AccessProtocol ToAccessProtocol(this string value)
        {
            if (string.Equals(value, "SMB", StringComparison.InvariantCultureIgnoreCase)) return AccessProtocol.SMB;
            if (string.Equals(value, "NFS", StringComparison.InvariantCultureIgnoreCase)) return AccessProtocol.NFS;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessProtocol value.");
        }
    }
}
