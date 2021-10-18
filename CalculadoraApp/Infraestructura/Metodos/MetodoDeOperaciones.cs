using Domain.OperacionesBasicas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Metodos
{
  public    class MetodoDeOperaciones
    {
        #region MetodosBasicos

        private OperacionesBasicas operacionesBasicas;
        public double  Getsuma()
        {
            double o =0;
            for (int i =0; i < operacionesBasicas.suma .Length ; i++)
            {
                o = o + operacionesBasicas.suma[i];
            }
            return o;
        }
        public double GetResta()
        { double x = 0;
            for(int I =0; I < operacionesBasicas.resta.Length; I++)
            {
                x = x - operacionesBasicas.resta[I];
            }
            return x;
        }
        public double GetMultiplicacion() {

            double emp = 0;
            for (int i=0; i < operacionesBasicas.Multiplicaion.Length; i++)
            {
                emp = emp * operacionesBasicas.Multiplicaion[i];
            }
            return emp;
        }
         
        public double GetDivision()
        {
            double tem = 0;
            for (int i =0; i< operacionesBasicas.division.Length; i++)
            {
                tem = tem / operacionesBasicas.division[i];
            }
            return tem;
        }

        public double GetElevarUnNumero()
        {
            double elv = 0;
            for(int I=0; I < operacionesBasicas.Elevacion.Length; I++)
            {
                elv = Math.Pow(elv, operacionesBasicas.Elevacion[I]);
            }
            return 0;
        }
        #endregion
    }
}
