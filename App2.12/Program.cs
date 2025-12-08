namespace App2._12;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        // Проверка, что число трехзначное
        if(number / 1000 != 0 || number / 100 == 0)
        {
            Console.WriteLine("Исходное число должно быть трехзначным");
        }
        else
        {
            int hungreds = number / 100;
            int dozens = number % 100 / 10;
            int units = number % 10;

            string hungredStr = "";
            string dozenStr = "";
            string unitStr = "";

            switch(units)
            {
                case 1:
                    unitStr = "один";
                    break;
                case 2:
                    unitStr = "два";
                    break;
                case 3:
                    unitStr = "три";
                    break;
                case 4:
                    unitStr = "яетыре";
                    break;
                case 5:
                    unitStr = "пять";
                    break;
                case 6:
                    unitStr = "шесть";
                    break;
                case 7:
                    unitStr = "семь";
                    break;
                case 8:
                    unitStr = "восемь";
                    break;
                case 9:
                    unitStr = "девять";
                    break;
            } 

            switch(dozens)
            {
                case 1:
                    if(units == 1)
                    {
                        dozenStr = "одиннадцать";
                    }
                    if(units == 2)
                    {
                        dozenStr = "двенадцать";
                    }
                    if(units == 3)
                    {
                        dozenStr = "тринадцать";
                    }
                    if(units == 4)
                    {
                        dozenStr = "четырнадцать";
                    }
                    if(units == 5)
                    {
                        dozenStr = "пятьнадцать";
                    }
                    if(units == 6)
                    {
                        dozenStr = "шестьнадцать";
                    }
                    if(units == 7)
                    {
                        dozenStr = "семьнадцать";
                    }
                    if(units == 8)
                    {
                        dozenStr = "восемьнадцать";
                    }
                    if(units == 1)
                    {
                        dozenStr = "девятнадцать";
                    }
                    unitStr = "";
                    break;
                case 2:
                    dozenStr = "двадцать";
                    break;
                case 3:
                    dozenStr = "тридцать";
                    break;
                case 4:
                    dozenStr = "сорок";
                    break;
                case 5:
                    dozenStr = "пятьдесят";
                    break;
                case 6:
                    dozenStr = "шестьдесят";
                    break;
                case 7:
                    dozenStr = "семьдесят";
                    break;
                case 8:
                    dozenStr = "восемьдесят";
                    break;
                case 9:
                    dozenStr = "девяноста";
                    break;
            } 

            switch(hungreds)
            {
                case 1:
                    hungredStr = "сто";
                    break;
                case 2:
                    hungredStr = "двести";
                    break;
                case 3:
                    hungredStr = "триста";
                    break;
                case 4:
                    hungredStr = "четыреста";
                    break;
                case 5:
                    hungredStr = "пятьсот";
                    break;
                case 6:
                    hungredStr = "шестьсот";
                    break;
                case 7:
                    hungredStr = "семьсот";
                    break;
                case 8:
                    hungredStr = "восемьсот";
                    break;
                case 9:
                    hungredStr = "девятьсот";
                    break;
            }            
            
            Console.WriteLine($"{hungredStr} {dozenStr} {unitStr}");
        }
    }
}
