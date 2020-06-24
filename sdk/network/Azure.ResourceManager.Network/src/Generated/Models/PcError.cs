// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The PcError. </summary>
    public readonly partial struct PcError : IEquatable<PcError>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PcError"/> values are the same. </summary>
        public PcError(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InternalErrorValue = "InternalError";
        private const string AgentStoppedValue = "AgentStopped";
        private const string CaptureFailedValue = "CaptureFailed";
        private const string LocalFileFailedValue = "LocalFileFailed";
        private const string StorageFailedValue = "StorageFailed";

        /// <summary> InternalError. </summary>
        public static PcError InternalError { get; } = new PcError(InternalErrorValue);
        /// <summary> AgentStopped. </summary>
        public static PcError AgentStopped { get; } = new PcError(AgentStoppedValue);
        /// <summary> CaptureFailed. </summary>
        public static PcError CaptureFailed { get; } = new PcError(CaptureFailedValue);
        /// <summary> LocalFileFailed. </summary>
        public static PcError LocalFileFailed { get; } = new PcError(LocalFileFailedValue);
        /// <summary> StorageFailed. </summary>
        public static PcError StorageFailed { get; } = new PcError(StorageFailedValue);
        /// <summary> Determines if two <see cref="PcError"/> values are the same. </summary>
        public static bool operator ==(PcError left, PcError right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PcError"/> values are not the same. </summary>
        public static bool operator !=(PcError left, PcError right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PcError"/>. </summary>
        public static implicit operator PcError(string value) => new PcError(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PcError other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PcError other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
