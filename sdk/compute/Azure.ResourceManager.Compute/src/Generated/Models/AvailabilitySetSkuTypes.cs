// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the sku of an Availability Set. Use &apos;Aligned&apos; for virtual machines with managed disks and &apos;Classic&apos; for virtual machines with unmanaged disks. Default value is &apos;Classic&apos;. </summary>
    public readonly partial struct AvailabilitySetSkuTypes : IEquatable<AvailabilitySetSkuTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AvailabilitySetSkuTypes"/> values are the same. </summary>
        public AvailabilitySetSkuTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClassicValue = "Classic";
        private const string AlignedValue = "Aligned";

        /// <summary> Classic. </summary>
        public static AvailabilitySetSkuTypes Classic { get; } = new AvailabilitySetSkuTypes(ClassicValue);
        /// <summary> Aligned. </summary>
        public static AvailabilitySetSkuTypes Aligned { get; } = new AvailabilitySetSkuTypes(AlignedValue);
        /// <summary> Determines if two <see cref="AvailabilitySetSkuTypes"/> values are the same. </summary>
        public static bool operator ==(AvailabilitySetSkuTypes left, AvailabilitySetSkuTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvailabilitySetSkuTypes"/> values are not the same. </summary>
        public static bool operator !=(AvailabilitySetSkuTypes left, AvailabilitySetSkuTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvailabilitySetSkuTypes"/>. </summary>
        public static implicit operator AvailabilitySetSkuTypes(string value) => new AvailabilitySetSkuTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvailabilitySetSkuTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvailabilitySetSkuTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
