// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The authentication mechanism to use to connect to the HBase server. </summary>
    public readonly partial struct HBaseAuthenticationType : IEquatable<HBaseAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HBaseAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HBaseAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnonymousValue = "Anonymous";
        private const string BasicValue = "Basic";

        /// <summary> Anonymous. </summary>
        public static HBaseAuthenticationType Anonymous { get; } = new HBaseAuthenticationType(AnonymousValue);
        /// <summary> Basic. </summary>
        public static HBaseAuthenticationType Basic { get; } = new HBaseAuthenticationType(BasicValue);
        /// <summary> Determines if two <see cref="HBaseAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(HBaseAuthenticationType left, HBaseAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HBaseAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(HBaseAuthenticationType left, HBaseAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HBaseAuthenticationType"/>. </summary>
        public static implicit operator HBaseAuthenticationType(string value) => new HBaseAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HBaseAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HBaseAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
