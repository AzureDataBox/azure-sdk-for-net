// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Compute.Models
{
    /// <summary> Specifies the HyperVGeneration Type. </summary>
    public readonly partial struct HyperVGenerationTypes : IEquatable<HyperVGenerationTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="HyperVGenerationTypes"/> values are the same. </summary>
        public HyperVGenerationTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string V1Value = "V1";
        private const string V2Value = "V2";

        /// <summary> V1. </summary>
        public static HyperVGenerationTypes V1 { get; } = new HyperVGenerationTypes(V1Value);
        /// <summary> V2. </summary>
        public static HyperVGenerationTypes V2 { get; } = new HyperVGenerationTypes(V2Value);
        /// <summary> Determines if two <see cref="HyperVGenerationTypes"/> values are the same. </summary>
        public static bool operator ==(HyperVGenerationTypes left, HyperVGenerationTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HyperVGenerationTypes"/> values are not the same. </summary>
        public static bool operator !=(HyperVGenerationTypes left, HyperVGenerationTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HyperVGenerationTypes"/>. </summary>
        public static implicit operator HyperVGenerationTypes(string value) => new HyperVGenerationTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HyperVGenerationTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HyperVGenerationTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
