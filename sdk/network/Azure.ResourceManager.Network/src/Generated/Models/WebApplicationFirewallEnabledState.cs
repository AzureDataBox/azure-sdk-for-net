// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The state of the policy. </summary>
    public readonly partial struct WebApplicationFirewallEnabledState : IEquatable<WebApplicationFirewallEnabledState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="WebApplicationFirewallEnabledState"/> values are the same. </summary>
        public WebApplicationFirewallEnabledState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static WebApplicationFirewallEnabledState Disabled { get; } = new WebApplicationFirewallEnabledState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static WebApplicationFirewallEnabledState Enabled { get; } = new WebApplicationFirewallEnabledState(EnabledValue);
        /// <summary> Determines if two <see cref="WebApplicationFirewallEnabledState"/> values are the same. </summary>
        public static bool operator ==(WebApplicationFirewallEnabledState left, WebApplicationFirewallEnabledState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebApplicationFirewallEnabledState"/> values are not the same. </summary>
        public static bool operator !=(WebApplicationFirewallEnabledState left, WebApplicationFirewallEnabledState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebApplicationFirewallEnabledState"/>. </summary>
        public static implicit operator WebApplicationFirewallEnabledState(string value) => new WebApplicationFirewallEnabledState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebApplicationFirewallEnabledState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebApplicationFirewallEnabledState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
