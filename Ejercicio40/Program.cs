using System;

namespace Ejercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Antiguedad de empleado";
                Console.Write("Ingrese el nombre del empleado:");
                var nombre = Convert.ToString(Console.ReadLine());
                Console.Write($"Ingrese el sueldo de {nombre}:");
                var sueldo = float.Parse(Console.ReadLine());
                Console.Write($"Ingrese la antigüedad de {nombre}: ");
                var antiguedad = float.Parse(Console.ReadLine());
                var sueldoAntiguedad = 0f;
                float CobrarXAntig = 0f;
                if (antiguedad >= 0 && antiguedad < 3)
                {
                    sueldoAntiguedad = (5 * sueldo / 100);
                    CobrarXAntig = sueldo + sueldoAntiguedad;
                    Console.WriteLine($"{nombre} cobra por su antigüedad {sueldoAntiguedad}$. Y deberia de" +
                        $" cobrar {CobrarXAntig}$.");
                }
                else if (antiguedad >= 3 && antiguedad <= 5)
                {
                    sueldoAntiguedad = (10 * sueldo / 100);
                    CobrarXAntig = sueldo + sueldoAntiguedad;
                    Console.WriteLine($"{nombre} cobra por su antigüedad {sueldoAntiguedad}$. Y deberia de" +
                        $" cobrar {CobrarXAntig}$.");
                }
                else if (antiguedad > 5 && antiguedad <= 8)
                {
                    sueldoAntiguedad = (15 * sueldo / 100);
                    CobrarXAntig = sueldo + sueldoAntiguedad;
                    Console.WriteLine($"{nombre} cobra por su antigüedad {sueldoAntiguedad}$. Y deberia de" +
                        $" cobrar {CobrarXAntig}$.");
                }
                else
                {
                    sueldoAntiguedad = (sueldo * 2 / 100) * antiguedad;
                    CobrarXAntig = sueldo + sueldoAntiguedad;
                    Console.WriteLine($"{nombre} cobra por su antigüedad {sueldoAntiguedad}$. Y deberia de" +
                        $" cobrar {CobrarXAntig}$.");
                }

                Console.WriteLine(SalarioNeto(CobrarXAntig));
               
            }
            catch (Exception)
            {

                Console.WriteLine("Datos mal ingresados.");
            }
            Console.ReadKey();
        }

        private static float SalarioNeto(float num1)
        {
            var reultado = (num1 - (num1 * 15.5f / 100));

            return (reultado);
        }
    }
}
