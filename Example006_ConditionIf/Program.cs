Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "алёна")
{
    Console.WriteLine("Привет, человечек!"); 
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}