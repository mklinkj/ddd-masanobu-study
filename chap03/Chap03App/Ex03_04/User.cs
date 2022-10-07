namespace Ex03_04;

public class User : IEquatable<User>
{
    private readonly UserId id; // 식별자
    private string name;

    public User(UserId id, string name)
    {
        if (id == null)
        {
            throw new ArgumentNullException(nameof(id));
        }

        this.id = id;
        ChangeName(name);
    }

    public void ChangeName(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (name.Length < 3)
        {
            throw new ArgumentException("사용자명은 3글자 이상이여야함", nameof(name));
        }

        this.name = name;
    }

    public override string ToString()
    {
        return "사용자명: " + name;
    }

    // Equals, GetHashCode 는 Rider IDE가 자동생성해주는 코드를 사용했다.
    // id 기준으로만 설정하여 생성


    public bool Equals(User? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return id.Equals(other.id);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((User)obj);
    }

    public override int GetHashCode()
    {
        return id.GetHashCode();
    }
}