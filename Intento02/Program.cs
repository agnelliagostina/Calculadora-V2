using System.ComponentModel.Design;

namespace Intento02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CALCULADORA";
          //Ingresa el tipo de operación que va a resolver la calculadora
            Console.WriteLine("Ingrese tipo de operación a realizar: +,-,* ó /");
            string operacion;
            operacion = Console.ReadLine();

            //Introduce el primer valor y segundo valor
            Console.WriteLine("Ingrese un valor, presione enter e ingrese el segundo valor:");
            string valorUno;
            valorUno = Console.ReadLine();
            int valorIngresado1 = int.Parse(valorUno);

            string valorDos;
            valorDos = Console.ReadLine();
            int valorIngresado2 = int.Parse(valorDos);

            //Realiza la operación indicada y muestra el resultado en pantalla
            Console.WriteLine("Resultado:");

            if (operacion == "+")
            {
                Console.WriteLine(valorIngresado1 + valorIngresado2);
            }
            else if (operacion == "-")
            {
                Console.WriteLine(valorIngresado1 - valorIngresado2);
            }
           else  if (operacion == "*")
            {
                Console.WriteLine(valorIngresado1 * valorIngresado2);
            }
           else  if (operacion == "/")
            {
                if (valorIngresado2 > 0)
                    Console.WriteLine(valorIngresado1 / valorIngresado2);
                else
                {
                    Console.WriteLine("Error: el segundo valor ingresado debe ser mayor a 0");
                }
            }
            else
            {
                Console.WriteLine("Operación no válida");
            }









            //char suma = "+";
            //char resta = "-";
            //char multiplicacion = "*";
            //char division = "/";
            //Console.ReadLine();

            //Introduce el primer valor
            //Console.WriteLine("Ingrese un valor:");
            //string valorUno;
            //valorUno = Console.ReadLine();
            //int valorIngresado1 = int.Parse(valorUno);

            ////Introduce el segundo valor
            //Console.WriteLine("Ingrese el segundo valor:");
            //string valorDos;
            //valorDos = Console.ReadLine();
            //int valorIngresado2 = int.Parse(valorDos);

        }
    }
}
