namespace App2._11;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите габариты участка через пробел: ");
        string[] siteDimensions = Console.ReadLine().Split(" ");
        int a = int.Parse(siteDimensions[0]);
        int b = int.Parse(siteDimensions[1]);

        Console.Write("Введите габариты первого дома через пробел: ");
        string[] firstHouseDimensions = Console.ReadLine().Split(" ");
        int p = int.Parse(firstHouseDimensions[0]);
        int q = int.Parse(firstHouseDimensions[1]);

        Console.Write("Введите габариты второго дома через пробел: ");
        string[] secondHouseDimensions = Console.ReadLine().Split(" ");
        int r = int.Parse(secondHouseDimensions[0]);
        int s = int.Parse(secondHouseDimensions[1]);

        bool canPlace = CanPlaceHouses(a, b, p, q, r, s);
        
        Console.WriteLine(canPlace ? "Дома можно разместить" : "Дома нельзя разместить");
    }

    static bool CanPlaceHouses(int a, int b, int p, int q, int r, int s)
    {
        // Проверяем все возможные варианты размещения:
        // 1. Оба дома горизонтально
        // 2. Оба дома вертикально
        // 3. Первый горизонтально, второй вертикально
        // 4. Первый вертикально, второй горизонтально
        
        // Для каждого варианта проверяем два способа размещения:
        // а) Дома рядом по горизонтали
        // б) Дома рядом по вертикали
        
        return CheckPlacement(a, b, p, q, r, s) || 
               CheckPlacement(a, b, q, p, r, s) ||  // Поворот первого дома
               CheckPlacement(a, b, p, q, s, r) ||  // Поворот второго дома
               CheckPlacement(a, b, q, p, s, r);    // Поворот обоих домов
    }
    
    static bool CheckPlacement(int a, int b, int p, int q, int r, int s)
    {
        // Вариант 1: Дома рядом по горизонтали
        // Проверяем, влезают ли дома по ширине и высоте
        if (Math.Max(p, r) <= a && q + s <= b)
            return true;
        
        // Вариант 2: Дома рядом по вертикали
        if (p + r <= a && Math.Max(q, s) <= b)
            return true;
        
        // Вариант 3: Дома могут быть размещены в углах
        if (p <= a && q <= b && r <= a - p && s <= b)
            return true;
            
        if (p <= a && q <= b && r <= a && s <= b - q)
            return true;
            
        if (p <= a - r && q <= b && r <= a && s <= b)
            return true;
            
        if (p <= a && q <= b - s && r <= a && s <= b)
            return true;
        
        return false;
    }
}
