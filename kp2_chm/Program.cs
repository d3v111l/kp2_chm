using System;


static void fx()
    {
        double accuracy;
        double a = 0; // Нижняя граница диапазона
        double b = 0.5; // Верхняя граница диапазона
        double x0 = (a + b) / 2; // Начальное приближение
        double x1 = 0; // Следующее приближение
        double f, df; // Значение функции и ее производной

        Console.WriteLine("Выберите точность:\n1 - 10^-4\n2 - 10^-5\n3 - 10^-6");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                accuracy = 1e-4;
                break;
            case 2:
                accuracy = 1e-5;
                break;
            case 3:
                accuracy = 1e-6;
                break;
            default:
                Console.WriteLine("Неверный выбор");
                return;
        }

        // Метод Ньютона
        do
        {
            f = Math.Pow(Math.Sin(x0), 2) + 1.0 / 30 * Math.Sin(x0) - 1.0 / 30;
            df = 2 * Math.Sin(x0) * Math.Cos(x0) + 1.0 / 30 * Math.Cos(x0);
            x1 = x0 - f / df;
            x0 = x1;
        } while (Math.Abs(f) > accuracy);

        Console.WriteLine($"Метод Ньютона: {x1}");

        // Упрощенный метод Ньютона
        x0 = (a + b) / 2;
        do
        {
            f = Math.Pow(Math.Sin(x0), 2) + 1.0 / 30 * Math.Sin(x0) - 1.0 / 30;
            df = 2 * Math.Sin(x0) * Math.Cos(x0) + 1.0 / 30 * Math.Cos(x0);
            x1 = x0 - f / df;
            x0 = x1;
        } while (Math.Abs(f) > accuracy && Math.Abs(x1 - x0) > accuracy);

        Console.WriteLine($"Упрощенный метод Ньютона: {x1}");
}


static void gx()
{
    double accuracy;
    double a = -0.5; // Нижняя граница диапазона
    double b = 0; // Верхняя граница диапазона
    double x0 = (a + b) / 2; // Начальное приближение
    double x1 = 0; // Следующее приближение
    double f, df; // Значение функции и ее производной

    Console.WriteLine("Выберите точность:\n1 - 10^-4\n2 - 10^-5\n3 - 10^-6");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            accuracy = 1e-4;
            break;
        case 2:
            accuracy = 1e-5;
            break;
        case 3:
            accuracy = 1e-6;
            break;
        default:
            Console.WriteLine("Неверный выбор");
            return;
    }

    // Метод Ньютона
    do
    {
        f = Math.Pow(Math.Sin(x0), 2) + 1.0 / 3 * Math.Sin(x0) - 1.0 / 36;
        df = 2 * Math.Sin(x0) * Math.Cos(x0) + 1.0 / 3 * Math.Cos(x0);
        x1 = x0 - f / df;
        x0 = x1;
    } while (Math.Abs(f) > accuracy);

    Console.WriteLine($"Метод Ньютона: {x1}");

    // Упрощенный метод Ньютона
    x0 = (a + b) / 2;
    do
    {
        f = Math.Pow(Math.Sin(x0), 2) + 1.0 / 3 * Math.Sin(x0) - 1.0 / 36;
        df = 2 * Math.Sin(x0) * Math.Cos(x0) + 1.0 / 3 * Math.Cos(x0);
        x1 = x0 - f / df;
        x0 = x1;
    } while (Math.Abs(f) > accuracy && Math.Abs(x1 - x0) > accuracy);

    Console.WriteLine($"Упрощенный метод Ньютона: {x1}");
}


static void px()
{
    static double f(double x)
    {
        return Math.Pow(x, 3) - Math.Sin(x);
    }

    static double df(double x)
    {
        return 3 * Math.Pow(x, 2) - Math.Cos(x);
    }

    static double simpleIteration(double x0, double epsilon)
    {
        double xi = x0;
        double xi1 = 0;

        do
        {
            xi1 = xi - f(xi) / df(xi);
            xi = xi1;
        } while (Math.Abs(xi1 - xi) > epsilon);

        return xi1;
    }


        double epsilon1 = 1e-4;
        double epsilon2 = 1e-5;
        double epsilon3 = 1e-6;

        Console.WriteLine($"Epsilon = {epsilon1}: x = {simpleIteration(1, epsilon1)}");
        Console.WriteLine($"Epsilon = {epsilon2}: x = {simpleIteration(1, epsilon2)}");
        Console.WriteLine($"Epsilon = {epsilon3}: x = {simpleIteration(1, epsilon3)}");

        Console.ReadLine();
    }


static void qx()
{
    static double f(double x)
    {
        return Math.Pow(x, 3) + 0.1 * Math.Pow(x, 2) + 0.4 * x - 1.2;
    }

    static double df(double x)
    {
        return 3 * Math.Pow(x, 2) + 0.2 * x + 0.4;
    }

    static double simpleIteration(double x0, double epsilon)
    {
        double xi = x0;
        double xi1 = 0;

        do
        {
            xi1 = xi - f(xi) / df(xi);
            xi = xi1;
        } while (Math.Abs(xi1 - xi) > epsilon);

        return xi1;
    }
        double epsilon1 = 1e-4;
        double epsilon2 = 1e-5;
        double epsilon3 = 1e-6;

        Console.WriteLine($"Epsilon = {epsilon1}: x = {simpleIteration(1, epsilon1)}");
        Console.WriteLine($"Epsilon = {epsilon2}: x = {simpleIteration(1, epsilon2)}");
        Console.WriteLine($"Epsilon = {epsilon3}: x = {simpleIteration(1, epsilon3)}");

        Console.ReadLine();
    }

Console.WriteLine("choose: \n 1.f \n 2.g \n 3.p \n 4.q");
string vars = "0";
vars = Console.ReadLine();
switch (vars)
{
    case "f":
        fx();
        break;

    case "g":
        gx();
        break;
    case "p":
        px();
        break;
    case "q":
        qx();
        break;
}