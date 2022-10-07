namespace Ex03_04;

public class UserId: IEquatable<UserId>
{
    private readonly string value;

    public UserId(string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        this.value = value;
    }

    public override string ToString()
    {
        return "사용자 ID: " + value;
    }

    public bool Equals(UserId? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return value == other.value;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((UserId)obj);
    }

    public override int GetHashCode()
    {
        return value.GetHashCode();
    }
}