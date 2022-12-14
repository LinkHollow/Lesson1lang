Console.Write("Введи Имя Пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "егор")
{
    Console.WriteLine("Ура, это Егор!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}