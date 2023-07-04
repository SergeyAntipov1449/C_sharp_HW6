// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


    void Intersection()
    {
        double k1;
        double k2;
        double b1;
        double b2;
        Console.WriteLine("Введите значение для k1:");
        k1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите значение для k2:");
        k2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите значение для b1:");
        b1= double.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите значение для b2:");
        b2 = double.Parse(Console.ReadLine()!);


        if (k1 == k2)
        {
            System.Console.WriteLine("Точки пересечения не существует");
        }
        else
        {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения: ({x}, {y})");
        }


    }

Intersection();
