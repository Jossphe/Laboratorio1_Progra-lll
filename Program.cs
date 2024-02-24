using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_JoseRigobertoMednozaRivas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             CALCULADORA: Cálculo de áreas y volúmenes
            1. Área de un rectángulo.
            2. Área de un triángulo.
            3. Área de un círculo. 
            4. Volumen de un cilindro.
            5. Volumen de una esfera.
            6. SALIR.
             */
         

            int opcion;

            do
            {
                Console.WriteLine("|-----------WELCOME TO MY CALCULATOR----------|");
                Console.WriteLine("|-------UNIVERSIDAD DOCTOR ANDRES BELLO-------|");
                Console.WriteLine("|-----FACULTAD DE TECNOLOGIA E IMNOVACION-----|");
                Console.WriteLine("|----------PROGRAMACION lll, LAB 1------------|");
                Console.WriteLine("|---------JOSE RIGOBERTO MENDOZA RIVAS--------|");
                Console.WriteLine(" ");
                Console.WriteLine("Por favor, ingrese el número de opcion, segun el cálculo que desea realizar");
                Console.WriteLine(" ");
                Console.WriteLine("1. Calcular el Área de un rectángulo");
                Console.WriteLine("2. Calcular el Área de un triángulo");
                Console.WriteLine("3. Calcular el Área de un círculo");
                Console.WriteLine("4. Calcular el Volumen de un cilindro");
                Console.WriteLine("5. Calcular el Volumen de una esfera");
                Console.WriteLine("6. SALIR");
                Console.WriteLine(" ");
                Console.Write("Opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CalcularAreaRectangulo();
                        break;
                    case 2:
                        CalcularAreaTriangulo();
                        break;
                    case 3:
                        CalcularAreaCirculo();
                        break;
                    case 4:
                        CalcularVolumenCilindro();
                        break;
                    case 5:
                        CalcularVolumenEsfera();
                        break;
                    case 6:
                        Console.WriteLine("CERRANDO :(");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 6);
        }

        static void CalcularAreaRectangulo()
        {
            Console.Write("Ingrese la base del rectángulo: ");
            if (!double.TryParse(Console.ReadLine(), out double baseRectangulo))
            {
                Console.WriteLine("Por favor, ingrese un valor numérico.");
                return;
            }

            Console.Write("Ingrese la altura del rectángulo: ");
            if (!double.TryParse(Console.ReadLine(), out double alturaRectangulo))
            {
                Console.WriteLine("Por favor, ingrese un valor numérico.");
                return;
            }

            double area = baseRectangulo * alturaRectangulo;
            Console.WriteLine($"El área del rectángulo es: {area:#.##}");
        }

        static void CalcularAreaTriangulo()
        {
            Console.Write("Ingrese la base del triángulo: ");
            if (!double.TryParse(Console.ReadLine(), out double baseTriangulo))
            {
                Console.WriteLine("Por favor, ingrese un valor numérico.");
                return;
            }

            Console.Write("Ingrese la altura del triángulo: ");
            if (!double.TryParse(Console.ReadLine(), out double alturaTriangulo))
            {
                Console.WriteLine("Por favor, ingrese un valor numérico.");
                return;
            }

            double area = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine($"El área del triángulo es: {area:#.##}");
        }

        static void CalcularAreaCirculo()
        {
            Console.Write("Ingrese el radio del círculo: ");
            if (!double.TryParse(Console.ReadLine(), out double radioCirculo))
            {
                Console.WriteLine("Por favor, ingrese un valor numérico.");
                return;
            }

            double area = Math.PI * Math.Pow(radioCirculo, 2);
            Console.WriteLine($"El área del círculo es: {area:#.##}");
        }

        static void CalcularVolumenCilindro()
        {
            Console.Write("Ingrese el radio del cilindro: ");
            if (!double.TryParse(Console.ReadLine(), out double radioCilindro))
            {
                Console.WriteLine("Por favor, ingrese un valor numérico.");
                return;
            }

            Console.Write("Ingrese la altura del cilindro: ");
            if (!double.TryParse(Console.ReadLine(), out double alturaCilindro))
            {
                Console.WriteLine("Por favor, ingrese un valor numérico.");
                return;
            }

            double volumen = Math.PI * Math.Pow(radioCilindro, 2) * alturaCilindro;
            Console.WriteLine($"El volumen del cilindro es: {volumen:#.##}");
        }

        static void CalcularVolumenEsfera()
        {
            Console.Write("Ingrese el radio de la esfera: ");
            if (!double.TryParse(Console.ReadLine(), out double radioEsfera))
            {
                Console.WriteLine("Por favor, ingrese un valor numérico.");
                return;
            }

            double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);
            Console.WriteLine($"El volumen de la esfera es: {volumen:#.##}");
        }
    }
}
