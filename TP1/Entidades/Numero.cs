using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;
        
    
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.SetNumero = numero.ToString();
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
       
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public string BinarioDecimal(string binario)
        {
            double resultado = 0;
            int cantidad = binario.Length;
            double numero;
            string aux = string.Empty;
            bool esBinario = true;

            for (int i = 0; i < cantidad; i++)
            {
                aux = binario.Substring(i, 1);
                if (aux != "0" && aux != "1")
                {
                    esBinario = false;
                    break;
                }
            }
            if (esBinario)
            {
                aux = string.Empty;
                for (int i = 0; i < cantidad; i++)
                {
                    numero = double.Parse(binario.Substring(i, 1));
                    resultado += numero * Math.Pow(2, cantidad - (i + 1));
                }
                return resultado.ToString();
            }
            return "Valor inválido";
        }

        public static string DecimalBinario(double numero)
        {
            string binario = string.Empty;
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    numero = (int)numero / 2;
                }
            }
            else if (numero == 0)
            {
                binario = "0";
            }
            else
            {
                binario = "Valor invalido";
            }
            return binario;
        }

        public string DecimalBinario(string numero)
        {
            double aux;
            if (double.TryParse(numero, out aux))
            {
                return DecimalBinario(aux);
            }
            else
            {
                return "Valor inválido";
            }   
            
        }

        private static double ValidarNumero(string strNumero)
        {
            double numero = 0;

            if (double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
                
        }
        
        public string SetNumero
        {
            set
            {
                this.numero = Numero.ValidarNumero(value);
            }
        }     
    }	
}