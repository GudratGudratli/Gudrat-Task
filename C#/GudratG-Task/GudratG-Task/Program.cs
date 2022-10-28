using System.Text;

void Task1()
{
    //1. Verilmiş 4 rəqəmli ədədin mərtəbələrinin cəmini
    //(Məsələn: input 1234, output 10) tapan alqoritmi yazın.
    int Num1, Num2, Num3, Num4, NumTotal;
    int Number = Convert.ToInt32(Console.ReadLine());

    if (Number >= 1000 && Number < 10000)
    {
        Num1 = Number / 1000;
        Num2 = Number / 100 % 10;
        Num3 = Number / 10 % 10;
        Num4 = Number % 10;
        NumTotal = Num1 + Num2 + Num3 + Num4;

        Console.WriteLine(NumTotal);
    }
    else
    {
        Console.WriteLine("Wrong Input!");
    }
}

void Task2()
{
    //2.Verilmiş 3 rəqəmli ədədin bütün rəqəmlərinin bi-birindən fərqli olub olmadığını tapan alqoritmi yazın.
    //(Məsələn: input 223, output "bütün rəqəmlər bərabər deyil " (false)).
    int Number = Convert.ToInt32(Console.ReadLine());

    if (Number >= 100 && Number < 1000)
    {

        int Num1 = Number / 100 % 10;
        int Num2 = Number / 10 % 10;
        int Num3 = Number % 10;

        Console.WriteLine(Num1 != Num2 && Num2 != Num3);
    }
    else
    {
        Console.WriteLine("Wrong Input!");
    }
}

void Task3()
{
    //3.İstifadəçi char tipindən dəyər daxil edib (input) char 'a' hərfinə bərabərdirsə
    //ekrana "Azərbaycan dili seçildi" yazısı gəlsin(output), 'r' hərfinə bərabərdirsə
    //"Rus dili seçildi" yazısı gəlsin (output). Digər bütün hallarda  "Yanlış sorğu" yazısı gəlsin(output).
    var InputPrefix = Console.ReadLine();
    var Prefix = Convert.ToChar(InputPrefix);
    Prefix = char.ToLower(Prefix);
    switch (Prefix)
    {
        case 'a':
            Console.WriteLine("Azərbaycan dili seçildi");
            break;
        case 'r':
            Console.WriteLine("Rus dili seçildi");
            break;
        default:
            Console.WriteLine("Yanlış sorğu");
            break;
    }
}


void Task4()
{
    string InputMonth = Console.ReadLine();
    string Month = InputMonth.ToLower();

    switch (Month)
    {
        case "january":
        case "march":
        case "may":
        case "july":
        case "auqust":
        case "october":
        case "december":
            Console.WriteLine("31");
            break;
        case "april":
        case "june":
        case "september":
        case "november":
            Console.WriteLine("30");
            break;
        case "febrary":
            Console.WriteLine("28");
            break;
    }
}

Task1();
Task2();
Task3();
Task4();


