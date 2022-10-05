namespace ex02;

/**
 * 이름을 나타내기위한 FullName 클래스
 */
public class FullName
{
    public FullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; }
    public string LastName { get; }
}