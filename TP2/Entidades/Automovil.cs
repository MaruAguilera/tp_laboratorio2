using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        public enum ETipo { Monovolumen, Sedan }
        private ETipo tipo;


        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Automovil(EMarca marca, string codigo,  ConsoleColor color,ETipo tipo )
            : base(codigo, marca, color)
        {
            tipo = ETipo.Monovolumen;
        }

        public Automovil(EMarca marca, string codigo,  ConsoleColor color)
            : base(codigo, marca,  color)
        {
           
        }


        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        public override ETamanio Tamanio 
        {
                get
                {
                    return ETamanio.Mediano;
                }
         }
        


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(String.Format("Tipo:  {0}\r\n", this.tipo));
            sb.AppendLine(String.Format("TAMAÑO: {0}\r\n", this.Tamanio));
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
    }
}
