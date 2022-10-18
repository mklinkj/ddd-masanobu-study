namespace Ex04_02;

public class UserName
{
    private readonly string value;

    public UserName(string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        if (value.Length < 3)
        {
            throw new ArgumentException("사용자명은 3글자 이상이여야 함", nameof(value));
        }
        
        this.value = value;
    }

    // public string Value { get; } 와 동일한 듯..
    public string Value => value;
}