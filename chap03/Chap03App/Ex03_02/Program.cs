// See https://aka.ms/new-console-template for more information

using Ex03_02;

var user = new User("mklinkj");

Console.WriteLine(user);

user.ChangeName("naruse");

Console.WriteLine(user);

user.ChangeName("Na"); // 2자 이름이여서 예외 발생

Console.WriteLine(user);