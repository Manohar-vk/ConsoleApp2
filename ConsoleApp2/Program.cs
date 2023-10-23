// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");





        int a, b;

        char c, d;

        a = 10;

        b = 20;

        c = 'I';

        d = 'V';



        //display values before swap:

        Console.WriteLine("Int values before calling swap:");

        Console.WriteLine("a = {0}, b = {1}", a, b);

        Console.WriteLine("Char values before calling swap:");

        Console.WriteLine("c = {0}, d = {1}", c, d);



        //call swap

        Class2.Swap(ref a, ref b);

        Class2.Swap(ref c, ref d);



        //display values after swap:

        Console.WriteLine("Int values after calling swap:");

        Console.WriteLine("a = {0}, b = {1}", a, b);

        Console.WriteLine("Char values after calling swap:");

        Console.WriteLine("c = {0}, d = {1}", c, d);
    }
}

public class Class2

{

    public static void Swap<T>(ref T lhs, ref T rhs)

    {

        T temp;

        temp = lhs;

        lhs = rhs;

        rhs = temp;

    }

}