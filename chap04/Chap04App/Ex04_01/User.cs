namespace Ex04_01;

public class User
{
    private readonly UserId id;
    private UserName name;

    public User(UserId id, UserName name)
    {
        if (id == null)
        {
            throw new ArgumentNullException(nameof(id));
        }

        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        this.id = id;
        this.name = name;
    }

    // 사용자명 중복 여부 확인 코드 추가 - 엔티티에 넣기에는 어색한 코드
    public bool Exists(User user)
    {
        // 사용자명 중복을 확인하는 코드
        // ... 
        return false;
    }
}