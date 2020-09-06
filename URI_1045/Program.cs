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
            
            if (a >= b +c){
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (a * a == b * b + c * c){
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if ((a *a) > (b * b) + (c * c)){
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if ((a * a) < (b * b) + (c * c)){
                Console.WriteLine(" TRIANGULO ACUTANGULO");
            }
            else if (a == b && a == c){
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || b == c || a == c){
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
