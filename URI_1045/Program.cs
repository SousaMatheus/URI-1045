using System;
using System.Globalization;

namespace URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            string [] vet = Console.ReadLine().Split(' '); 
            a = float.Parse(vet[0],CultureInfo.InvariantCulture);
            b = float.Parse(vet[1],CultureInfo.InvariantCulture);
            c = float.Parse(vet[2],CultureInfo.InvariantCulture);
            
        }
    }
}
