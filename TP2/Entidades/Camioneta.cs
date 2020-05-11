using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        public Camioneta(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMIONETA");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(String.Format("TAMAÑO: {0}\r\n", this.Tamanio));
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
