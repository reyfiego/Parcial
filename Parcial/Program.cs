using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudent;
            Arraylist regristro = new Arraylist;
            string nombre;
            int edad;
            int contador = 0;

            Console.Write("Ingrese el numero de estudiantes: ");
            numberStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (contador < numberStudent) ;
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                nombre = Console.ReadLine();
                Console.Write("ngrese la edad del estudiante: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Students students = new Students() { Nombre = nombre, Edad = edad };
                registro.Add(students);
                contador++;
            }


     public class Students
        {
            private string _nombre;
            private int _edad;

            public string Nombre
            {
                get => _nombre;
                set => _nombre = value;
            }
            public int Edad
            { 
        }
    }
}
