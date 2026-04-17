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
        public Pacientes(string nombre, int edad, string dpi, int telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dpi = dpi;
            this.telefono = telefono;
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            bool edadValida;
            int edad;
            do
            {
                Console.WriteLine("Ingrese la edad");
                edadValida=int.TryParse(Console.ReadLine(), out edad);
                if(!edadValida)
                {
                    Console.WriteLine("Error, ingrese un número válido.");
                }
            } while (!edadValida||edad<0);
        }
    }
}
