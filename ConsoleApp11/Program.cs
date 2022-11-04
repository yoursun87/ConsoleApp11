// See https://aka.ms/new-console-template for more information
Console.WriteLine("Опрбуйте калькулятор");
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(@"Выберите действие: 
1- умножить 
2- сложить
3- делить
4- вычесть");
string action = Console.ReadLine();
switch (action)
{
    case "1":
        Console.WriteLine($"{a * b}");
        break;
    case "2":
        Console.WriteLine(a + b);
        break;
    case "3":
        if (b == 0)
        {
            Console.WriteLine("Дурак! На ноль делить нельзя");

        }
        else 
        {
            Console.WriteLine(a / b);
            

        }
        break;

        case "4":
        Console.WriteLine(a - b);
        break;
        
            

}



