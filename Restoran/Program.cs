using Restoran;

MenuRestoran menuRestoran = new MenuRestoran();

void Menu()
{
    Console.WriteLine();
    Console.WriteLine("Меню ресторана");
    Console.WriteLine();
    Console.WriteLine("1. Burger");
    Console.WriteLine("2. Fries");
    Console.WriteLine("3. Chiken");
    Console.WriteLine("4. Pizza");
    Console.WriteLine("5. Sandwich");
    Console.WriteLine("6. Onionrings");
    Console.WriteLine("7. Milkshake");
    Console.WriteLine("8. Coke");
}
void funcMenu()
{
    List<string> list = new List<string>()
    {
        "burger","fries","chiken","pizza","sandwich","onionrings","milkshake","coke",
    };
    string enter = Console.ReadLine();
   menuRestoran.Comparison(list,enter);
    enter.ToUpper();
}
while (true)
{
Menu();
funcMenu();
}