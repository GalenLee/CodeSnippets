using System;

public struct CompositeKey<T, TU> : IEquatable<CompositeKey<T, TU>>
{
    public readonly T Value1;
    public readonly TU Value2;

    public CompositeKey(T value1, TU value2)
    {
        this.Value1 = value1;
        this.Value2 = value2;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        if (this.GetType() != obj.GetType())
            return false;
        return AreEqual(this, (CompositeKey<T, TU>)obj);
    }

    public bool Equals(CompositeKey<T, TU> other)
    {
        return AreEqual(this, other);
    }

    private static bool AreEqual(CompositeKey<T, TU> a, CompositeKey<T, TU> b)
    {
        if (!a.Value1.Equals(b.Value1))
            return false;
        if (!a.Value2.Equals(b.Value2))
            return false;
        return true;
    }

    public static bool operator ==(CompositeKey<T, TU> a, CompositeKey<T, TU> b)
    {
        return AreEqual(a, b);
    }

    public static bool operator !=(CompositeKey<T, TU> a, CompositeKey<T, TU> b)
    {
        return !AreEqual(a, b);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + this.Value1.GetHashCode();
            hash = hash * 23 + this.Value2.GetHashCode();
            return hash;
        }
    }
}