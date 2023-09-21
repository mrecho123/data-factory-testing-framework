// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> AuthenticationType to be used for connection. It is mutually exclusive with connectionString property. </summary>
    public readonly partial struct Db2AuthenticationType : IEquatable<Db2AuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Db2AuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Db2AuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";

        /// <summary> Basic. </summary>
        public static Db2AuthenticationType Basic { get; } = new Db2AuthenticationType(BasicValue);
        /// <summary> Determines if two <see cref="Db2AuthenticationType"/> values are the same. </summary>
        public static bool operator ==(Db2AuthenticationType left, Db2AuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Db2AuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(Db2AuthenticationType left, Db2AuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Db2AuthenticationType"/>. </summary>
        public static implicit operator Db2AuthenticationType(string value) => new Db2AuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Db2AuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Db2AuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
