﻿class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        Tachies tack = new Tachies(calculator.Min);
        tack = new Tachies(calculator.Plus);
        Tachies tacs = new Tachies(calculator.Del);
        tacs = new Tachies(calculator.Ymn);
        Console.WriteLine("Вычитание - :"+tack(10, 2));
        Console.WriteLine("Вычитание - :"+tack(10,2));
        Console.WriteLine("Деление / :"+tacs(10,2));
        Console.WriteLine("Деление / :"+tacs(10, 2));
    }
}

public delegate int Tachies(int x, int y); 

public class Calculator {

        public int Plus(int x, int y)
    {
        return x + y;
    }

        public int Min(int x, int y)
    {
        return x - y;
    }

        public int Ymn(int x, int y)
    {
        return x * y;
    }

        public int Del(int x, int y)
    {
        return x / y;
    }


}