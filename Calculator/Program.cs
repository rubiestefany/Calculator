using System;
using Calculator;

namespace CalculatorRH
{
    class Program
    {
        static void Main(string[] args)
        {
			string operador = "";
			int digitoUno = 0;
			int digitoDos = 0;

			if (args.Length == 3)
			{
				try
				{
					operador = args[0];
					digitoUno = int.Parse(args[1]);
					digitoDos = int.Parse(args[2]);

				}

				catch (Exception e)
				{
					Console.WriteLine("Error en el formato");
					Console.WriteLine(e.Message);
					return;
				}

				switch (operador)
				{
					case "+":
						Console.WriteLine("Se ejecuta operación " + digitoUno + " + " + digitoDos);
						Console.WriteLine("Suma: " + Calculadora.Operacion("+", digitoUno, digitoDos));
						break;

					case "/":
						Console.WriteLine("Se ejecuta operación " + digitoUno + " / " + digitoDos);
						Console.WriteLine("División: " + Calculadora.Operacion("/", digitoUno, digitoDos));
						break;

					case "-":
						Console.WriteLine("Se ejecuta operación " + digitoUno + " - " + digitoDos);
						Console.WriteLine("Resta: " + Calculadora.Operacion("-", digitoUno, digitoDos));
						break;

					case "*":
						Console.WriteLine("Se ejecuta operación " + digitoUno + " * " + digitoDos);
						Console.WriteLine("Multiplicación: " + Calculadora.Operacion("*", digitoUno, digitoDos));
						break;

					default:
						Console.WriteLine("Es cuanto");
						break;
				}
			}

			else
			{

				Console.WriteLine("Digite 2 números separados del signo: [número1] [operador] [número2]");
			}

		}

    }
}
