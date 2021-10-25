using Domain.OperacionesBasicas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Metodos
{
  public class MetodoDeOperaciones
    {

        #region MetodosBasicos

        private OperacionesBasicas operacionesBasicas=new OperacionesBasicas();
        public double[] numeros;
        int a = 0;
        public int y = 0;
        public char operador='v';
        public double numero1 = 0, numero2 = 0;
        public void Add(double n)
        {
            if (numeros==null)
            {
                numeros = new double[1];
                numeros[numeros.Length - 1] = n;
                return;
            }
            double[] tmp = new double[numeros.Length + 1];
            Array.Copy(numeros,tmp,numeros.Length);
            tmp[tmp.Length - 1] = n;
            numeros = tmp;


        }
        public void ViewNumber(string txt)
        {

        }
        public double GetNumber(string txt,char op)
        {
            if (string.IsNullOrEmpty(txt))
            {
                throw new ArgumentException("Error, no ha escrito nada");
            }
            double x = 0;
            string f = txt;
            operador = op;
            if (a == 0)
            {
                x = double.Parse(txt);
                y = txt.Length;
                a++;
               numero1 = double.Parse(txt);
                return double.Parse(txt);
            }else
            {
                int b = f.IndexOf(op, y-1);
                y = txt.Length;
                a++;
                numero2 = double.Parse(f.Substring(b + 1));
                return double.Parse(f.Substring(b + 1));
            }
        }
        public void Guardarnum(double num)
        {
            if (a==0)
            {
                numero1 = num;
                a++;
            }
            else
            {
                numero2 = num;
                a++;
            }
        }
        public double Resultado()
        {
            double r=0;
            if (operador=='v')
            {
                return numero1;
            }
            switch (operador)
            {
                case '+':
                    r= numero1 + numero2;
                    numero1 = r;
                    numero2 = 0;
                    break;
                case '-':
                    if (numero2 > 0)
                    {
                        numero2 = numero2 * -1;
                        r = numero1 + numero2;
                        numero1 = r;
                        numero2 = 0;
                    }
                    else
                    {
                        r = numero1 - numero2;
                        numero1 = r;
                        numero2 = 0;
                    }
                    break;
                case '*':
                    r= numero1 * numero2;
                    numero1 = r;
                    numero2 = 0;
                    break;
                case '÷':
                    r= numero1 / numero2;
                    numero1 = r;
                    numero2 = 0;
                    break;
                case '^':
                    r=Math.Pow(numero1,numero2);
                    numero1 = r;
                    numero2 = 0;
                    break;
                case '√':
                    r = Math.Sqrt(numero2);
                    numero1 = r;
                    numero2 = 0;
                    break;
                case '%':
                    r = (numero1 * numero2) / 100;
                    numero1 = r;
                    numero2 = 0;
                    break;
               
            }
            
            return r;
        }
        public void Reiniciar()
        {
            a = 0;
            numero1 = 0;
            numero2 = 0;
        }
        public double  Getsuma()
        {
            return a;
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
