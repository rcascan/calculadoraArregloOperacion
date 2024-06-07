using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraArregloOperacion
{
    internal class Program
    {
        public static float num1, num2;
        public static string agregarOperacion;

        public static string[] operacion = new string[0];
        public static string[] nuevaOperacion = new string[operacion.Length + 1];

        static void Main(string[] args)
        {


            Menu();


        }//fin del main


        static void Menu()
        {

            bool exit = true;

            while (exit)
            {


                Console.Clear();
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Dividir");
                Console.WriteLine("4. potencia");
                Console.WriteLine("5. Area de un Triangulo ");
                Console.WriteLine("6. Area de un Cuadrado ");
                Console.WriteLine("7. Visualizar registros ");
                Console.WriteLine("8. Salir ");
                Console.Write("Selecciona una opción: ");

                String opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "sumar":

                        sumar();
                        break;

                    case "restar":

                        restar();
                        break;

                    case "dividir":

                        dividir();
                        break;

                    case "salir":
                        Console.Clear();
                        exit = false;
                        Console.WriteLine("Saliendo del programa...");

                        break;

                    case "potencia":

                        potencia();
                        break;


                    case "area de un triangulo":

                        areaTriangulo();
                        break;

                    case "area de un cuadrado":

                        areaCuadrado();
                        break;

                    case "visualizar registros":

                        foreach (var item in operacion)
                        {
                            Console.WriteLine(item + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }




            }




        } // fin menu

        static void solicitar_Numeros()

        {
            Console.Clear();
            Console.WriteLine("Digite el primer numero: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite el segundo numero: ");
            num2 = float.Parse(Console.ReadLine());


        }


        static void sumar()
        {
            solicitar_Numeros();
            float suma = num1 + num2;
            Console.WriteLine("EL resultado de la suma es: " + suma);
            Console.WriteLine("");
            agregarOperacion = ($"{num1} + {num2} : {suma}");
            operacion = AgregarOperacion(operacion, agregarOperacion);
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void restar()
        {
            solicitar_Numeros();
            float resta = num1 - num2;
            Console.WriteLine("EL resultado de la resta es: " + resta);
            Console.WriteLine("");

            agregarOperacion = ($"{num1} - {num2} : {resta}");
            operacion = AgregarOperacion(operacion, agregarOperacion);

            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void dividir()
        {
            solicitar_Numeros();

            if (num2 == 0)
            {
                Console.WriteLine("Error: División por cero no es posible.");
            }
            else
            {
                float division = num1 / num2;
                Console.WriteLine("El resultado de la división es: " + division);

                agregarOperacion = ($"{num1} + {num2} : {division}");
                operacion = AgregarOperacion(operacion, agregarOperacion);
            }

            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }


        static void potencia()
        {
            solicitar_Numeros();

            double resultado = Math.Pow(num1, num2);
            Console.WriteLine($"El resultado de {num1} elevado a la potencia de {num2} es: {resultado}");

            agregarOperacion = ($"{num1} ^ {num2} : {resultado}");
            operacion = AgregarOperacion(operacion, agregarOperacion);

            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }


        static void areaTriangulo()
        {
            Console.Clear();
            Console.WriteLine("Digite la base del triángulo: ");
            float baseTriangulo = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite la altura del triángulo: ");
            float alturaTriangulo = float.Parse(Console.ReadLine());

            float area = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine($"El área del triángulo es: {area}");

            agregarOperacion = ($"{baseTriangulo} ▲ {alturaTriangulo} : {area}");
            operacion = AgregarOperacion(operacion, agregarOperacion);

            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void areaCuadrado()
        {
            Console.Clear();
            Console.WriteLine("Digite el lado del cuadrado: ");
            float lado = float.Parse(Console.ReadLine());

            float area = lado * lado;
            Console.WriteLine($"El área del cuadrado es: {area}");

            agregarOperacion = ($"{lado} ■ {lado} : {area}");
            operacion = AgregarOperacion(operacion, agregarOperacion);

            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static string[] AgregarOperacion(string[] arreglo, string NuevaOperacion)
        {
            // Crear un nuevo arreglo con un tamaño mayor en 1
            string[] nuevaOperacion = new string[arreglo.Length + 1];

            // Copiar los elementos del arreglo original al nuevo arreglo
            for (int i = 0; i < arreglo.Length; i++)
            {
                nuevaOperacion[i] = arreglo[i];
            }

            // Agregar la nueva operación al final del nuevo arreglo
            nuevaOperacion[nuevaOperacion.Length - 1] = NuevaOperacion;

            // Retornar el nuevo arreglo
            return nuevaOperacion;
        }


    }
}
