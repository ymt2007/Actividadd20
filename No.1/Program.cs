using System;
using System.Collections.Generic;
namespace No._1
{
    class Pacientes
    {
        private string nombre;
        private int edad;
        private string dpi;
        private int telefono;

        public string Nombre
        {
            get { return nombre; }
            set { 
                if(value.Length<3)
                {
                    Console.WriteLine("El nombre debe tener al menos 3 caracteres.");
                }
                else
                nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { 
                if(value>=0&&value<=120)
                edad = value;
                else
                {
                    Console.WriteLine("Error, edad fuera del rango");
                }
            }
        }

        public string Dpi
        {
            get { return dpi; }
            set { 
                if(value.ToString().Length==13)
                dpi = value;
                else
                {
                    Console.WriteLine("Error, el DPI debe tener 13 dígitos.");
                }
            }
        }

        public int Telefono
        {
            get { return telefono; }
            set { 
                if(value.ToString().Length == 8)
                telefono = value;
                else
                {
                    Console.WriteLine("Error, el número de teléfono debe tener 8 dígitos.");
                }
            }
        }


    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("si");
        }
    }
}
