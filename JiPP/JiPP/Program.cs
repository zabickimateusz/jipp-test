using System;
using System.Runtime.InteropServices.JavaScript;

class Program
{
    static void Main(string[] args)
    {

        //Operatory
        Console.WriteLine("Operatory\n");

        //ZADANIE 1

        Console.WriteLine("ZADANIE 1");

        int number = 77;                  
        float money = 21.50f;            
        string text = "Hello World";      
        bool isLogged = true;            
        char myChar = 'A';               
        decimal price = 200.10m;         

        Console.WriteLine($"number = {number}");
        Console.WriteLine($"money = {money}");
        Console.WriteLine($"text = {text}");
        Console.WriteLine($"isLogged = {isLogged}");
        Console.WriteLine($"myChar = {myChar}");
        Console.WriteLine($"price = {price}");
        Console.WriteLine("\n ");







        //ZADANIE 2

        Console.WriteLine("ZADANIE 2");

        string myAge = "Age:";
        int wifeAge = 18;
        string result = myAge + wifeAge;
        Console.WriteLine(result);
        Console.WriteLine("\n ");
        // Wnioski:
        // Operator + przy łączeniu string i int wykonuje niejawną konwersję
        // liczby całkowitej na string i łączy oba teksty





        //ZADANIE 3

        Console.WriteLine("ZADANIE 3");

        // 1.
        bool True1 = true;
        bool False1 = false;
        bool True2 = true;

        // 2. 
        bool and = True1 && False1;
        bool or = True1 || True2;
        bool negative = !False1;

        // 3. 
        Console.WriteLine($"and = {and}");
        Console.WriteLine($"or = {or}");
        Console.WriteLine($"negative = {negative}");
        Console.WriteLine("\n");


        //ZADANIE 4

        Console.WriteLine("ZADANIE 4");

        // 1.
        int a = 5;
        int b = 12;

        // 2.
        int add = a + b; 
        int sub = a - b;
        int div = a / b;
        int mul = a * b;
        int mod = a % b;     // Modulo (reszta z dzielenia)

        // 3.
        Console.WriteLine($"add = {add}");
        Console.WriteLine($"sub = {sub}");
        Console.WriteLine($"div = {div}");
        Console.WriteLine($"mul = {mul}");
        Console.WriteLine($"mod = {mod}");

        Console.WriteLine("\n");


        //ZADANIE 5

        Console.WriteLine("ZADANIE 5");

        // 1.
        string a5 = "Ala";
        string b5 = "ma";
        string c5 = "kota.";

        // 2.
        string result5 = a5 + b5 + c5;

        // 3.
        Console.WriteLine(result5);

        // 4. Spostrzeżenia:
        // Operator + dla zmiennych typu string łączy je bezpośrednio, bez dodawania spacji
        // Wynikiem jest ciąg "Alamakota." - brakuje spacji między słowami
        // Aby otrzymać czytelny tekst, należałoby dodać spacje: a5 + " " + b5 + " " + c5
        Console.WriteLine("\n");




        //Instrukcje sterujące i pętle
        Console.WriteLine("Instrukcje sterujące i pętle\n");

        //Zadanie 1
        Console.WriteLine("ZADANIE 1");

        // 1.
        int n1 = 10;
        int n2 = 28;

        // 2.
        if (n1 > n2)
        {
            Console.WriteLine("n1 jest większe od n2");
        }
        else if (n1 == n2)
        {
            Console.WriteLine("n1 jest równe n2");
        }
        else
        {
            Console.WriteLine("n1 jest mniejsze od n2");
        }
        Console.WriteLine("\n");



        //Zadanie 2
        Console.WriteLine("ZADANIE 2");

        // Pętla for
        Console.WriteLine("Wynik pętli for:");
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(i+". C#");
        }

        // Pętla while
        Console.WriteLine("\nWynik pętli while:");
        int counter = 1;
        while (counter < 11)
        {
            Console.WriteLine(counter+". C#");
            counter++;
        }
        Console.WriteLine("\n");


        //Zadanie 3
        Console.WriteLine("ZADANIE 3");

        // 1. 
        int n = 10;

        // 2. 
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} - Parzysta");
            }
            else
            {
                Console.WriteLine($"{i} - Nieparzysta");
            }
        }

        Console.WriteLine("\n");


        
        //Zadanie 4
        Console.WriteLine("ZADANIE 4");
        // 1.
        n = 3;

        // 2.
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }


        Console.WriteLine("\n");



        //ZADANIE 6
        Console.WriteLine("ZADANIE 6");

        // 1.
        
        int exam = 57; 

        // 2.

        if (exam < 0 || exam > 100)
        {
            Console.WriteLine("Wartość poza zakresem");
        }
        else if (exam <= 39)
        {
            Console.WriteLine("Ocena Niedostateczna");
        }
        else if (exam <= 49)
        {
            Console.WriteLine("Ocena Dopuszczająca");
        }
        else if (exam <= 69)
        {
            Console.WriteLine("Ocena Dostateczna");
        }
        else if (exam <= 84)
        {
            Console.WriteLine("Ocena Dobra");
        }
        else if (exam <= 99)
        {
            Console.WriteLine("Ocena Bardzo Dobra");
        }
        else // exam == 100
        {
            Console.WriteLine("Ocena Celująca");
        }

        Console.WriteLine("\n");

    }
}