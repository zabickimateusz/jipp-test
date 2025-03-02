using System;

class Program
{
    static void Main(string[] args)
    {

        //Operatory

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


    }
}