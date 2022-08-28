Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "яна")
{
    Console.WriteLine("Ура, Привет тебе Яночка!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}