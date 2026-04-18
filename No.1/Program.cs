using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            this.Nombre = nombre;
            this.Edad = edad;
            this.Dpi = dpi;
            this.Telefono = telefono;
        }
        public void MostrarPaciente()
        {
            Console.WriteLine($"Nombre: {nombre}, DPI: {dpi}, Telefono: {telefono}, Edad: {edad}");
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre");
            string nombre = Console.ReadLine();
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
            } while (!edadValida||edad<0||edad>120);
            string dpi;
            do
            {
                Console.WriteLine("Ingrese el DPI");
                dpi = Console.ReadLine();
                if (dpi.Length != 13)
                {
                    Console.WriteLine("Error, el DPI debe tener 13 dígitos.");
                }
            } while (dpi.ToString().Length!=13);
            int telefono; bool telefonoValido;
            do
            {
                Console.WriteLine("Ingrese el numero de telefono");
                telefonoValido=int.TryParse(Console.ReadLine(),out telefono);
                if(!telefonoValido)
                    Console.WriteLine("Error, ingrese un nuvero valido");
            } while (!telefonoValido||telefono.ToString().Length != 8);

            Pacientes p = new Pacientes(nombre, edad, dpi, telefono);
            p.MostrarPaciente();
        }
    }
}