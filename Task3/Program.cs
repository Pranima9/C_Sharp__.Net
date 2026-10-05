using System;
class  Program
{
    static void Main()
    {
        // declare and initialize different data types
        byte b = 10;
        short s = 200;
        int i = 42;
        long l = 400000L;
        float f = 5.01f;
        double db = 6;
        decimal dec = 7;
        char ch = 'h';
        bool bo = true;
        
        // convert integer 42 to string
        string iTOs = i.ToString();
        
        // convert string "3.14" to a double
        double sTOd = double.Parse("3.14");
        
        Console.WriteLine("byte: " + b);
        Console.WriteLine("short: " + s);
        Console.WriteLine("int: " + i);
        Console.WriteLine("long: " + l);
        Console.WriteLine("float: " + f);
        Console.WriteLine("double: " + db);
        Console.WriteLine("decimal: " + dec);
        Console.WriteLine("char: " + ch);
        Console.WriteLine("bool: " + bo);
        Console.WriteLine("int to string: " + iTOs);
        Console.WriteLine("string to double: " + sTOd);
    }
} 