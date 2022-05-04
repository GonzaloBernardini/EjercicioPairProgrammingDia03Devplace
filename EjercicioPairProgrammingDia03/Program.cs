using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EjercicioPairProgrammingDia03
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            bool bandera = false;
            do
            {
                try
                {                  
                    Console.WriteLine("Ingrese la marca del vehiculo");
                    a1.MarcaVehiculo = Console.ReadLine();
                    Console.WriteLine("Ingrese tipo de Combustible");
                    a1.TipoCombustible = Console.ReadLine();
                    Console.WriteLine("Ingrese cantidad de ruedas");
                    a1.CantidadRuedas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de pasajeros");
                    a1.CantidadPasajeros = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tiene aire acondicionado?");
                    a1.AireAcondicionado = Convert.ToBoolean(Console.ReadLine());
                    a1.MostrarDatos(a1.MarcaVehiculo, a1.CantidadRuedas, a1.CantidadPasajeros);
                    a1.MostrarDatosAuto(a1.TipoCombustible, a1.AireAcondicionado);
                    a1.QuitarTecho();
                    bandera = false;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message,"Tipo de dato invalido");
                    bandera = true;

                }
            } while(bandera == true);

            
            


           

        }

        class Vehiculo
        {
            
            public string MarcaVehiculo { get; set; }

            public int CantidadRuedas { get; set; }

            public int CantidadPasajeros { get; set; }


            public void MostrarDatos(string m, int cr, int cp)
            {
                Console.WriteLine();
            }
        }
        class Moto : Vehiculo
        {
            public string Cilindrada { get; set; }           

            public void HacerWilly()
            {
                Console.WriteLine("Estoy haciendo willy");
            }
            public  void MostrarDatosMoto(string cl)
            {
                Console.WriteLine("Mi cilindrada es de: ");
            }


        }

        class Auto : Vehiculo
        {
            public string TipoCombustible { get; set; }

            public bool AireAcondicionado { get; set; }

            public void QuitarTecho()
            {
                Console.WriteLine("Me hago descapotable");
            }

            public new void MostrarDatos(string m,int cr,int cp)
            {
                Console.WriteLine($"Marca :  {m} \n Cantidad de Ruedas : {cr} \n Cantidad de Pasajeros : {cp}");
            }

            public void MostrarDatosAuto(string tc,bool aa)
            {
                Console.WriteLine($" Tipo de Combustible : {tc} \n Aire Acondicionado : {aa}");
            }


        }
        
    }
}
