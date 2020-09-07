using System;
using System.Globalization;

namespace URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a =0; b =0; c=0;

            string [] vet = Console.ReadLine().Split(' '); 
            double valor1 = float.Parse(vet[0],CultureInfo.InvariantCulture);
            double valor2 = float.Parse(vet[1],CultureInfo.InvariantCulture);
            double valor3 = float.Parse(vet[2],CultureInfo.InvariantCulture);

            if (valor1 > valor2 && valor1 > valor3){
                a = valor1;
                if (valor2 > valor3){
                    b = valor2;
                    c = valor3;
                } else {
                    b = valor3;
                    c = valor2;
                }                
            }
            else if (valor2 > valor1 && valor2 > valor3){
                a = valor2;
                if ( valor1 > valor3){
                b = valor1;
                c = valor3;
                } else {
                    b = valor3;
                    c = valor1;
                }
            }
            else {
                a = valor3;
                if (valor1 > valor2){
                b = valor1;
                c = valor2;
                } else {
                    b = valor2;
                    c = valor1;
                }
            }            
            if (a >= b + c ){
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else {
                if (a * a == b * b + c * c){
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if ((a *a) > (b * b) + (c * c)){
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else //if ((a * a) < (b * b) + (c * c)){
                {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            }
             if (a == b && a == c){
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
                else if (a == b || b == c || a == c){
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
