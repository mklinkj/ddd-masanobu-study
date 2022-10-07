namespace Ex03_01;

public class User
{
    private readonly string _name;

    public User(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (name.Length < 3)
        {
            throw new ArgumentException("사용자명은 3글자 이상이여야함", nameof(name));
        }

        this._name = name;
    }

    public override string ToString()
    {
        return "사용자명: " + _name;
    }
}