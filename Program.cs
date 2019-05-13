using System;


namespace holam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Linea de codigo antes de subirlo al gitHub");


            Console.WriteLine("Linea de cambio para probar funcionalidad");


            Console.WriteLine("Linea de cambio en el estado");
            Console.WriteLine("Linea de cambio en las variables globales");

            Console.WriteLine("Linea de cambio en las variables staticas");
            Console.WriteLine("Linea de cambio en los sub modulos principales");


            //personal
            Persona clsper = new Persona(); 
            Console.WriteLine(clsper.Mensaje() + " Carlos");


        }
    }
}
