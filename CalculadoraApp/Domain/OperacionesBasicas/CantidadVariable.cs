using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.OperacionesBasicas
{
    public class CantidadVariable
    {
        public int NParentesis { get; set; }
        public double Valor { get; set; }
        public int Posic { get; set; }
        public char signoDetras { get; set; }
        public char signoAdelante { get; set; }
        public Tipo tipo { get; set; }
    }
}
