using System;
using System.Runtime.CompilerServices;

namespace HowToMediatR.Core.Kernel
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        protected abstract ITuple AsTuple();

        public bool Equals(ValueObject? other)
        {
            if (other is null)
            {
                return false;
            }

            if (GetType() != other.GetType())
            {
                return false;
            };

            return AsTuple().Equals(other.AsTuple());
        }

        public override bool Equals(object obj) => Equals(obj as ValueObject);

        public override int GetHashCode() => AsTuple().GetHashCode();

        public static bool operator ==(ValueObject? left, ValueObject? right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(ValueObject? left, ValueObject? right) => !(left == right);
    }
}
