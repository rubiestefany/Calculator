using System;


namespace Calculator
{
    public class Calculadora
    {
        public Calculadora()
        { }

		public static int Operacion(string operador, int valor1, int valor2)
		{
			switch (operador)
			{
				case "+":
					{
						var resultante = valor1 + valor2;
						return resultante;
					}

				case "-":
					{
						var resultante = valor1 - valor2;
						return resultante;
					}

				case "/":
					{
						var resultante = valor1 / valor2;
						return resultante;
					}

				case "*":
					{
						var resultante = valor1 * valor2;
						return resultante;
					}

				default:
					{
						return 0;
					}
			}
		}

	}
}
