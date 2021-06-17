using System;

namespace Inicial
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, signo, cedula, telefono, FechaNacimiento, carrera;
            byte edad, MiembrosFamilia;
            bool EstadoCivil;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su signo:");
            signo = Console.ReadLine();
            Console.WriteLine("Ingrese su cedula:");
            cedula = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono:");
            telefono = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Fecha de nacimiento:");
            FechaNacimiento = Console.ReadLine();
            Console.WriteLine("¿Cual es su estado civil?:");
            EstadoCivil = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("¿Qué estudia?:");
            carrera = Console.ReadLine();
            Console.WriteLine("Miembros de su familia:");
            MiembrosFamilia = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Su nombre es: {nombre}");
            Console.WriteLine($"Su apellido es: {apellido}");
            Console.WriteLine($"Su signo es: {signo}");
            Console.WriteLine($"Su cedula es: {cedula}");
            Console.WriteLine($"Su télefono es: {telefono}");
            Console.WriteLine($"Su edad es: {edad}");
            Console.WriteLine($"Su fecha de nacimiento es : {FechaNacimiento}");
            Console.WriteLine($"¿Está casado?: {EstadoCivil}");
            Console.WriteLine($"Usted estudia: {carrera}");
            Console.WriteLine($"Miembros de su familia : {MiembrosFamilia}");

        }
    }
}
