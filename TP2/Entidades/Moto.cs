﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public Moto(EMarca marca, string codigo, ConsoleColor color)
            :base (codigo, marca, color)
        {
        }

        /// <summary>
        /// Las motos son chicas
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(String.Format("TAMAÑO: {0}\r\n", this.Tamanio));
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
    }
}
