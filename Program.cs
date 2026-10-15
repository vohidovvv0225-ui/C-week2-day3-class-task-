// User[] users = new User[3];

// users[0] = new User("Ali", "vali", "dali", "ali1234");
// users[1] = new User("Muhammadjon", "Vohidzoda", "MV2009", "1234");
// users[2] = new User("Hamza", "usuf", "aaa111", "2332");

// Console.Write("Username: ");
// string userName = Console.ReadLine()!;

// Console.Write("Pasword: ");
// string password = Console.ReadLine()!;

// bool fff = false;

// for (int i = 0; i < users.Length; i++)
// {
//     if (users[i].UserName == userName)
//     {
//         users[i].Login(userName, password);
//         fff = true;
//         break;
//     }
// }

// if (!fff)
// {
//     Console.WriteLine("Login failed!");
// }




// taski 3

Student student=new Student();
student.Id=1;
student.Name="Muhammad Vohidov";
student.Age=17;
student.Avarage=10;
student.GetInfo();
if (student.IsExcellentStudent())
{
    System.Console.WriteLine("harowiy uchenec");

}
else
{
    System.Console.WriteLine("nado uchitsya");
}