// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The value of effective route. </summary>
    public readonly partial struct EffectiveRouteState : IEquatable<EffectiveRouteState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EffectiveRouteState"/> values are the same. </summary>
        public EffectiveRouteState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string InvalidValue = "Invalid";

        /// <summary> Active. </summary>
        public static EffectiveRouteState Active { get; } = new EffectiveRouteState(ActiveValue);
        /// <summary> Invalid. </summary>
        public static EffectiveRouteState Invalid { get; } = new EffectiveRouteState(InvalidValue);
        /// <summary> Determines if two <see cref="EffectiveRouteState"/> values are the same. </summary>
        public static bool operator ==(EffectiveRouteState left, EffectiveRouteState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EffectiveRouteState"/> values are not the same. </summary>
        public static bool operator !=(EffectiveRouteState left, EffectiveRouteState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EffectiveRouteState"/>. </summary>
        public static implicit operator EffectiveRouteState(string value) => new EffectiveRouteState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EffectiveRouteState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EffectiveRouteState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
