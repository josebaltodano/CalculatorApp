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
        int a1 = 0,b=0,a;
        public int y = 0;
        public char operador='v';
        public double numero1 = 0, numero2 = 0;
        string operadorT = "";
        char AngPlano = 'r';
        public void Ang(char an)
        {
            AngPlano = an;
        }
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
        double r = 0;
        public double Resultado()
        {
            
            switch (operadorT)
            {
                case "Cos":
                    
                     if (AngPlano == 'r')
                     {
                        numero1 = Math.Cos(numero2);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                     }
                     else
                     {
                        double n = numero2*(Math.PI / 180);
                        numero1 = Math.Cos(n);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }
                    
                    break;
                case "Sen":
                    if (AngPlano == 'r')
                    {
                        numero1 = Math.Sin(numero2);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        numero1 = Math.Sin(n);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }
                    break;
                case "Tan":
                    if (AngPlano == 'r')
                    {
                        numero1 = Math.Tan(numero2);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        numero1 = Math.Tan(n);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }
                    break;
                case "Cosh":

                    if (AngPlano == 'r')
                    {
                        numero1 = Math.Cosh(numero2);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        numero1 = Math.Cosh(n);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }

                    break;
                case "Senh":

                    if (AngPlano == 'r')
                    {
                        numero1 = Math.Sinh(numero2);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        numero1 = Math.Sinh(n);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }
                    break;
                case "Tanh":

                    if (AngPlano == 'r')
                    {
                        numero1 = Math.Tanh(numero2);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        numero1 = Math.Tanh(n);
                        r = numero1;
                        numero2 = 0;
                        operadorT = "";
                        operador = 'v';
                    }

                    break;
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
                    if (numero2 == 0)
                    {
                        throw new ArgumentException("Error Matematico: (a/0 no existe)");
                    }
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
                case 'l':
                    r = Math.Log10(numero2);
                    numero1 = r;
                    numero2 = 0;
                    break;
                case 'n':
                    r = Math.Log(numero2, Math.E);
                    numero1 = r;
                    numero2 = 0;
                    break;
            }
            return r;
        }

        public void MasMenos(ref string txt,ref string rtb)
        {
            if (txt == "0")
            {
                return;
            }
            string c = "";
            double v = double.Parse(txt);
            if (rtb.Length == v.ToString().Length)
            {
                if (v > 0)
                {
                    c = "-" + txt;
                    txt = c;
                    rtb = c;
                }
                else
                {
                    c = txt.Substring(1);
                    txt = c;
                    c = rtb.Substring(0, rtb.Length - 2);
                    rtb = c + txt;
                }
            }
            else
            {
                if (v > 0)
                {
                    c = "-" + txt;
                    txt = c;
                    //c = txtOperacion.Text.Substring(0, txtOperacion.Text.Length - 2);
                    //txtOperacion.Text = c + txtView.Text;
                }
                else
                {
                    
                    c = txt.Substring(1);
                    txt = c;
                    //c = txtOperacion.Text.Substring(0, txtOperacion.Text.Length - 2);
                    //txtOperacion.Text = c + txtView.Text;
                }
            }
        }
        public void OperacionesCien(ref string txt,ref string rtb,string btn)
        {
            if (string.IsNullOrEmpty(rtb))
            {
                rtb = "0";
            }
            if (btn == "Log")
            {
                operador ='l';
            }
            else if (btn == "Ln")
            {
                operador = 'n';
            }
            string op = operador.ToString();
            string verificar = rtb.Substring(rtb.Length-1);
            Guardarnum(double.Parse(txt));
            if (double.TryParse(verificar,out double f)) {
                if (a == 1)
                {
                    rtb = btn;
                }
                else
                {
                    rtb += btn;
                }
                operadorT = btn;
                txt = "0";
            }
            else if(verificar==op)
            {
                rtb += btn;
                operadorT = btn;
                txt = "0";
            }
            else
            {
                return;
            }
        }
        public void Igual(ref string txt, ref string rtb)
        {
            string verificar = rtb.Substring(rtb.Length - 1);
            if (operador == '%')
            {
                Guardarnum(double.Parse(txt));
                rtb += txt;
                txt = Resultado().ToString();
                a1 = 0;
            }
            else
            {
                if (double.TryParse(verificar, out double f))
                {
                    Guardarnum(double.Parse(txt));
                    if (operador == 'v')
                    {
                        txt = Resultado().ToString();
                        rtb += " = " + txt;
                        a = 0;
                    }
                    else
                    {
                        rtb += $"{operador}" + txt;
                        txt = Resultado().ToString();
                        rtb += " = " + txt;
                        a = 0;
                    }
                }
                else
                {
                    Guardarnum(double.Parse(txt));
                    rtb += txt;
                    txt = Resultado().ToString();
                    rtb += " = " + txt;
                    a = 0;
                }
            }
        }
        public void Quitar(ref string txt, ref string rtb)
        {
            string c = txt.Substring(0, txt.Length - 1);
            txt = c;
            if (operador == 'v')
            {
                rtb = c;
            }
            if (txt == string.Empty)
            {
                txt = "0";
            }
        }
        public void Operaciones(ref string txt, ref string rtb,string button)
        {
            if (rtb != string.Empty)
            {
                string verificar = rtb.Substring(rtb.Length - 1);
                if (button == "%")
                {
                    Guardarnum(double.Parse(txt));
                    operador = '%';
                    rtb = string.Empty;
                    txt = Resultado().ToString();
                    return;
                }
                else
                if (!double.TryParse(verificar, out double a))
                {
                    return;
                }
            }
            if (button != "√")
            {
                rtb = txt;
            }
            else
            {
                rtb = string.Empty;
            }
            if (a1 >= 1)
            {
                Guardarnum(double.Parse(txt));
                rtb += button;
                b = 1;
                rtb = txt + button;
                if (button == "%")
                {
                    operador = '+';
                }
                else
                {
                    operador = Convert.ToChar(button);   
                }
            }
            else
            {
                Guardarnum(double.Parse(txt));
                txt = "0";
                operador = Convert.ToChar(button);
                if (button == "%")
                {
                    operador = '%';
                    rtb = string.Empty;
                    txt = Resultado().ToString();
                }
                else 
                {
                    if (button == "√")
                    {
                        rtb = button;
                    }
                    else
                    {
                        rtb += button;
                    }
                }
            }
            a1++;
        }
        public void ViewNumber(ref string txt, ref string rtb, string button)
        {
            if (b >= 1)
            {
                txt = string.Empty;
                b--;
            }
            if (txt == "0")
            {
                txt = string.Empty;
            }
            if (button == "π")
            {

                txt = Math.PI.ToString();
                return;
            }
            else if(button=="e")
            {
                txt = Math.E.ToString();
            }
            else
            {
                txt += button;
            }
        }
        public void Reiniciar()
        {
            operadorT = "";
            operador = 'v';
            r = 0;
            b = 0;
            a1 = 0;
            a = 0;
            numero1 = 0;
            numero2 = 0;
        }
        #endregion
    }
}
