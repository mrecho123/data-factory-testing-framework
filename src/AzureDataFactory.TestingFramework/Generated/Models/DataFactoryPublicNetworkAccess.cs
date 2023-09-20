// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Whether or not public network access is allowed for the data factory. </summary>
    public readonly partial struct DataFactoryPublicNetworkAccess : IEquatable<DataFactoryPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataFactoryPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFactoryPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static DataFactoryPublicNetworkAccess Enabled { get; } = new DataFactoryPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static DataFactoryPublicNetworkAccess Disabled { get; } = new DataFactoryPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="DataFactoryPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(DataFactoryPublicNetworkAccess left, DataFactoryPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFactoryPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(DataFactoryPublicNetworkAccess left, DataFactoryPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataFactoryPublicNetworkAccess"/>. </summary>
        public static implicit operator DataFactoryPublicNetworkAccess(string value) => new DataFactoryPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFactoryPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFactoryPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}