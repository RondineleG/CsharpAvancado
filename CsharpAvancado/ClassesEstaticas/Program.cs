using System;

namespace ClassesEstaticas
{
    //Classe statica
    public static class ConversorStatic
    {
        public static double CelsiusToFah(double temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }
        public static double FahToCelsius(double temperatura)
        {
            return (temperatura - 32) * 5 / 9;
        }
    }

    //Membros staticos
    public class ConversorInstancia
    {
        public static double temperatura;

        public double CelsiusToFah()
        {
            return (temperatura * 9 / 5) + 32;
        }
        public double FahToCelsius()
        {
            return (temperatura - 32) * 5 / 9;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var conversor1 = new ConversorInstancia();
            var conversor2 = new ConversorInstancia();
            ConversorInstancia.temperatura = 30;

            var celsius = conversor1.CelsiusToFah();

            ConversorInstancia.temperatura = 70;
            var fah = conversor1.FahToCelsius();

            Console.WriteLine("Celsius = " + celsius);
            Console.WriteLine("Fah = " + fah);

            var temperaturaCelsius = 35.0;
            temperaturaCelsius = ConversorStatic.CelsiusToFah(temperaturaCelsius);
            Console.WriteLine(temperaturaCelsius);

            var temperaturaFah = 95.0;
            temperaturaFah = ConversorStatic.FahToCelsius(temperaturaFah);
            Console.WriteLine(temperaturaFah);

            Console.ReadLine();
        }
                
    }
}
