namespace Ex03_03;

public class User
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
}