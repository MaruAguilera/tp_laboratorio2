using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        static string ValidarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                return operador;
            else
                return "+";
        }

        public static double operar(Numero num1, Numero num2, string operador)
        {
            double numero = 0;

            switch (Calculadora.ValidarOperador(operador))
            {
                case "+":
                    numero = num1 + num2;
                    break;
                case "-":
                    numero = num1 - num2;
                    break;
                case "*":
                    numero = num1 * num2;
                    break;
                case "/":
                    numero = num1 / num2;
                    break;
            }
            return numero;
        }
    }
}
