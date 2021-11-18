using Domain.OperacionesBasicas;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;
using Domain.Interfaces;


namespace Infraestructura.Metodos
{
    public class MetodoDeOperaciones : IOperaciones
    {
        private int a1 = 0, b = 0, a;
        private char operador = 'v';
        private double numero1 = 0, numero2 = 0;
        private string operadorT = "";
        private char AngPlano = 'r';
        private double r = 0;
        public void Ang(char an)
        {
            AngPlano = an;
        }
        public void Guardarnum(double num)
        {
            if (a == 0)
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

            switch (operadorT)
            {
                case "Cos":

                    if (AngPlano == 'r')
                    {
                        r = Math.Cos(numero2);
                        Guardarnum(r);
                        //numero1 = 0;
                        operadorT = "";
                        //operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        Guardarnum(Math.Cos(n));
                        r = Math.Cos(n);
                        //numero1 = 0;
                        operadorT = "";
                        //operador = 'v';
                    }

                    break;
                case "Sen":
                    if (AngPlano == 'r')
                    {
                        r = Math.Sin(numero2);
                        Guardarnum(r);
                        
                        operadorT = "";
                        //operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        Guardarnum(Math.Sin(n));
                        r = Math.Sin(n);
                        operadorT = "";
                        //operador = 'v';
                    }
                    break;
                case "Tan":
                    if (AngPlano == 'r')
                    {
                        r = Math.Tan(numero2);
                        Guardarnum(r);
                        
                        operadorT = "";
                        //operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        Guardarnum(Math.Tan(n));
                        r = Math.Tan(n);
                        operadorT = "";
                        //operador = 'v';
                    }
                    break;
                case "Cosh":

                    if (AngPlano == 'r')
                    {
                        r = Math.Cosh(numero2);
                        Guardarnum(r);
                        
                        operadorT = "";
                        //operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        Guardarnum(Math.Cosh(n));
                        r = Math.Cosh(n);
                        operadorT = "";
                        //operador = 'v';
                    }

                    break;
                case "Senh":

                    if (AngPlano == 'r')
                    {
                        r = Math.Sinh(numero2);
                        Guardarnum(r);
                        
                        operadorT = "";
                        //operador = 'v';
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        Guardarnum(Math.Sinh(n));
                        r = Math.Sinh(n);
                        operadorT = "";
                        //operador = 'v';
                    }
                    break;
                case "Tanh":

                    if (AngPlano == 'r')
                    {
                        r = Math.Tanh(numero2);
                        Guardarnum(r);
                        
                        operadorT = "";
                    }
                    else
                    {
                        double n = numero2 * (Math.PI / 180);
                        Guardarnum(Math.Tanh(n));
                        r = Math.Tanh(n);
                        operadorT = "";
                    }

                    break;
            }
            switch (operador)
            {
                case '+':
                    r = numero1 + numero2;
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
                    r = numero1 * numero2;
                    numero1 = r;
                    numero2 = 0;
                    break;
                case '÷':
                    if (numero2 == 0)
                    {
                        throw new ArgumentException("Error Matematico: (a/0 no existe)");
                    }
                    r = numero1 / numero2;
                    numero1 = r;
                    numero2 = 0;
                    break;
                case '^':
                    r = Math.Pow(numero1, numero2);
                    numero1 = r;
                    numero2 = 0;
                    break;
                case '√':
                    if (numero1 != 0)
                    {
                        r = Math.Sqrt(numero1);
                        numero1 = r;
                        numero2 = 0;
                    }
                    else
                    {
                        r = Math.Sqrt(numero2);
                        numero1 = r;
                        numero2 = 0;
                    }
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
                case 'i':
                    if (numero1==0)
                    {
                        r = Math.Pow(numero2, -1);
                        numero1 = r;
                        numero2 = 0;
                    }
                    else
                    {
                        r = Math.Pow(numero1, -1);
                        numero1 = r;
                        numero2 = 0;
                    }
                    break;
            }
            return r;
        }

        public void MasMenos(ref string txt, ref string rtb)
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
                }
                else
                {

                    c = txt.Substring(1);
                    txt = c;
                }
            }
        }
        public void OperacionesCien(ref string txt, ref string rtb, string btn)
        {
            string verificar = "v";
            if (rtb != string.Empty)
            {
                verificar = rtb.Substring(rtb.Length - 1);
            }
            if (double.TryParse(verificar, out double h))
            {
                return;
            }
            if (btn == "Log")
            {
                operador = 'l';
            }
            else if (btn == "Ln")
            {
                operador = 'n';
            }
            {
                string op = operador.ToString();
                Guardarnum(double.Parse(txt));
                if (double.TryParse(verificar, out double f))
                {
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
                else if (verificar == op)
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
                       // a = 0;
                    }
                }
                else
                {
                    Guardarnum(double.Parse(txt));
                    rtb += txt;
                    txt = Resultado().ToString();
                    rtb += " = " + txt;
                    //a = 0;
                }
            }
        }
        public void Quitar(ref string txt, ref string rtb)
        {
            string c = txt.Substring(0, txt.Length - 1);
            txt = c;
            /*if (operador == 'v')
            {
                rtb = c;
            }*/
            if (txt == string.Empty)
            {
                txt = "0";
            }
        }
        
       // List<int> GradoPol = new List<int>();
        
        public void Operaciones(ref string txt, ref string rtb, string button, string txtI)
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
            if (button == "i")
            {
                Guardarnum(double.Parse(txt));
                operador = 'i';
                txt = Resultado().ToString();
                rtb = txt;
                return;
                
            }
                if (button != "√")
                {
                    rtb = txt;
                }
                else
                {
                Guardarnum(double.Parse(txt));
                operador = '√';
                txt = Resultado().ToString();
                rtb = txt;
                return;
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
            if (txt == "0"&&button!=".")
            {
                txt = string.Empty;
            }
            if (button == "π")
            {

                txt = Math.PI.ToString();
                return;
            }
            else if (button == "e")
            {
                txt = Math.E.ToString();
            }
            else
            {
                txt += button;
            }
        }
        public void ParentesisT(ref string cos,ref string sen, ref string tan,string rtb,ref string cosh, ref string senh, ref string tanh)
        {
            string verificar = cos.Substring(cos.Length - 1);
            if (verificar=="("&& rtb.IndexOf("∫") < 0)
            {
                cos = cos.Substring(0,3);
                sen = sen.Substring(0,3);
                tan = tan.Substring(0,3);
                cosh = cosh.Substring(0, 4);
                senh = senh.Substring(0,4);
                tanh = tanh.Substring(0, 4);
            }
            else if(rtb.IndexOf("∫")>=0&& verificar != "(")
            {
                cos += "(";
                sen += "(";
                tan += "(";
                cosh += "(";
                senh += "(";
                tanh += "(";

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
        public int GradoPolin(string rtb)
        {
            int poten = rtb.IndexOf("^");
            int posit = rtb.IndexOf("+");
            string verificar = rtb.Substring(poten + 1);
            if (posit > 0 || double.TryParse(verificar, out double h))
            {
                int num = 0;
                int GradoT = 0;
                if (posit > 0 && poten > 0)
                {
                    num = int.Parse(rtb.Substring(poten + 1, posit - (poten + 1)));
                }
                else
                if (posit < 0)
                {
                    GradoT = int.Parse(rtb.Substring(poten + 1));
                }
                for (int i = 0; i < rtb.Length - 1; i++)
                {
                    if (num > GradoT)
                    {
                        GradoT = num;
                        poten = rtb.IndexOf("^", posit);
                        posit = rtb.IndexOf("+", posit + 1);
                        if (posit > 0 && poten > 0)
                        {
                            num = int.Parse(rtb.Substring(poten + 1, posit - (poten + 1)));
                        }
                    }
                }
                return GradoT;
            }
            else
            {
                return 0;
            }
        }

        public char GetOperador()
        {
            return operador;
        }
    }
}
