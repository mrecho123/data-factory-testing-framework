// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Spark configuration reference type. </summary>
    public readonly partial struct SparkConfigurationReferenceType : IEquatable<SparkConfigurationReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SparkConfigurationReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SparkConfigurationReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SparkConfigurationReferenceValue = "SparkConfigurationReference";

        /// <summary> SparkConfigurationReference. </summary>
        public static SparkConfigurationReferenceType SparkConfigurationReference { get; } = new SparkConfigurationReferenceType(SparkConfigurationReferenceValue);
        /// <summary> Determines if two <see cref="SparkConfigurationReferenceType"/> values are the same. </summary>
        public static bool operator ==(SparkConfigurationReferenceType left, SparkConfigurationReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkConfigurationReferenceType"/> values are not the same. </summary>
        public static bool operator !=(SparkConfigurationReferenceType left, SparkConfigurationReferenceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkConfigurationReferenceType"/>. </summary>
        public static implicit operator SparkConfigurationReferenceType(string value) => new SparkConfigurationReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkConfigurationReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkConfigurationReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
