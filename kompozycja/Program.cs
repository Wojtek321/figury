using System;
using System.Threading.Channels;

namespace program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Obraz obraz = new Obraz();
            int x, y;

            while (true)
            {
                Console.WriteLine("Co chcesz zrobic?");
                Console.WriteLine("1. Dodaj trojkat.");
                Console.WriteLine("2. Dodaj czworokat.");
                Console.WriteLine("3. Przesun figury.");
                Console.WriteLine("4. Wypisz figury");
                Console.WriteLine("5. Zakoncz prace.");
                Console.Write("Wprowadz numer: ");
                int wybor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                switch (wybor)
                {
                    case 1:
                    {
                        Console.WriteLine("Wprowadz wspolrzedne pierwszego punktu:");
                        Console.Write("x = ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("y = ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Punkt p1 = new Punkt(x, y);
                        Console.Clear();
                        
                        Console.WriteLine("Wprowadz wspolrzedne drugiego punktu:");
                        Console.Write("x = ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("y = ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Punkt p2 = new Punkt(x, y);
                        Console.Clear();
                        
                        Console.WriteLine("Wprowadz wspolrzedne trzeciego punktu:");
                        Console.Write("x = ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("y = ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Punkt p3 = new Punkt(x, y);
                        Console.Clear();

                        Trojkat trojkat = new Trojkat(p1, p2, p3);
                        obraz.dodajTrojkat(trojkat);
                        
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Wprowadz wspolrzedne pierwszego punktu:");
                        Console.Write("x = ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("y = ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Punkt p1 = new Punkt(x, y);
                        Console.Clear();
                        
                        Console.WriteLine("Wprowadz wspolrzedne drugiego punktu:");
                        Console.Write("x = ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("y = ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Punkt p2 = new Punkt(x, y);
                        Console.Clear();
                        
                        Console.WriteLine("Wprowadz wspolrzedne trzeciego punktu:");
                        Console.Write("x = ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("y = ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Punkt p3 = new Punkt(x, y);
                        Console.Clear();
                        
                        Console.WriteLine("Wprowadz wspolrzedne czwartego punktu:");
                        Console.Write("x = ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("y = ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Punkt p4 = new Punkt(x, y);
                        Console.Clear();

                        Czworokat czworokat = new Czworokat(p1, p2, p3, p4);
                        obraz.dodajCzworokat(czworokat);
                        
                        break;
                    }
                    case 3:
                    {
                        Console.Write("Wprowadz wspolrzedna x: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Wprowadz wspolrzedna y: ");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        obraz.przesun(x, y);
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine(obraz);
                        break;
                    }
                    case 5:
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                }
            }
        }
    }
}