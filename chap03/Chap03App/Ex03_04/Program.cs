// See https://aka.ms/new-console-template for more information

using Ex03_04;

void Check(User leftUser, User rightUser)
{
    if (leftUser.Equals(rightUser))
    {
        Console.WriteLine("동일한 사용자임");
    }
    else
    {
        Console.WriteLine("동일한 사용자가 아님");
    }
}

var user1 = new User(new UserId("mklinkj"), "정션링크1");
var user2 = new User(new UserId("mklinkj"), "정션링크2");


Check(user1, user2);