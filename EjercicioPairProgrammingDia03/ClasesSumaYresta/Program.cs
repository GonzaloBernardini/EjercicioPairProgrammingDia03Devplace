using System;

namespace ClasesSumaYresta
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma sm = new Suma();
            int r = 0;
            sm.Operar(2,5,r);
            Resta res1 = new Resta();
            res1.Operar(10,5,r);
           
        }
        public class Operacion 
        {
         protected int valor1 { get; set; }
         protected int valor2 { get; set; }

         protected int resultado;
            public void  Operar(int valor1, int valor2, int resultado) 
            {
                
            }
        }
        public class Suma : Operacion 
        { 
            public new void Operar(int valor1, int valor2, int resultado) 
            { 
                this.valor1 = valor1;
                this.valor2 = valor2;
                this.resultado = resultado;
                resultado = valor1 + valor2;
                Console.WriteLine($"El resultado es : {resultado}");
                
            }
        }
        public class Resta : Operacion 
        { 
            public new void Operar(int valor1, int valor2, int resultado) {
                this.valor1 = valor1;
                this.valor2 = valor2;
                this.resultado = resultado;
                resultado = valor1 - valor2;
                Console.WriteLine($"El resultado es : {resultado}");

            }
        }
    }
}
