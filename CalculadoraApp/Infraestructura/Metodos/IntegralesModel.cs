using System;
using System.Collections.Generic;
using System.Text;
using Domain.OperacionesBasicas;
using Domain.Enums;
using Domain.Interfaces;

namespace Infraestructura.Metodos
{
    public class IntegralesModel : IIntegral
    {
        public MetodoDeOperaciones metodo;
        private double Limit;
        private int N = 2000;
        private string Trig = "";
        private int op = 0;
        private char fun;
        private List<double> NPolin = new List<double>();
        private List<int> cerrarP = new List<int>();
        private List<int> abrirP = new List<int>();
        private List<CantidadVariable> variables = new List<CantidadVariable>();
        private List<double> ValorX = new List<double>();
        private List<char> SignosT = new List<char>();

        public IntegralesModel()
        {
            metodo = new MetodoDeOperaciones();
        }
        public char Cadena(ref string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                return 'v';
            }
            char c = 'v';
            string R = "";
            if (a.Length == 1)
            {
                c = Char.Parse(a);
                a = "";
                return c;
            }
            else
            {
                R = a.Substring(1);
                string n = a.Substring(0, 1);
                c = Char.Parse(n);
                a = R;
            }
            return c;
        }
        public void AddC(ref string rtb, string txtI, ref string txt)
        {
            if (rtb.Substring(rtb.Length - 1) != "X")
            {
                rtb += txt + ")";

                cerrarP.Add(rtb.Length - 1);
                GuardarnumInteg(txt, ")", rtb);
                txt = "0";
            }
            else
            {
                if (rtb.IndexOf("∫", 0) >= 0)
                {
                    rtb += ")";
                    cerrarP.Add(rtb.Length - 1);
                    Variable(rtb, txtI);
                    txt = "0";
                }
            }
        }
        public void AddA(int p)
        {
            abrirP.Add(p);
        }
        public List<double> ValorY = new List<double>();
        public double Integral(char fun, double limI, double limS)
        {
            if (SignosT.Count==0)
            {
                SignosT.Add('v');
            }
            char verificar;
            int np = 1;
            double a1 = (limS - limI) / N;
            double b = OperarDentroParen(limI, limS, np);
            double c = b;
            int v = 0;
            if (Trig == null)
            {
                v = 0;
            }
            else
            {
                v = Trig.Length;
            }
            double[] fx = new double[N];
            for (int i = 0; i < N; i++)
            {
                fx[i] = 1;
            }
            for (int l = 0; l <= v; l++)
            {
                b = c;
                if (l >= SignosT.Count)
                {
                    for (int g=l;g>=0;g--)
                    {
                        SignosT.Add('v');
                    }
                }
                switch (fun)
                {
                    case 'c':
                        if (l != 0)
                        {
                            np = np + 1;
                            for (int i = 0; i < N; i++)
                            {
                                if (SignosT[l - 1] == '*')
                                {
                                    fx[i] = fx[i] * Math.Cos(b);
                                }
                                else if (SignosT[l - 1] == '÷')
                                {
                                    fx[i] = fx[i] / Math.Cos(b);
                                }
                                else if (SignosT[l - 1] == '+')
                                {
                                    fx[i] = fx[i] + Math.Cos(b);
                                }
                                else if (SignosT[l - 1] == '-')
                                {
                                    fx[i] = fx[i] - Math.Cos(b);
                                }
                                else if (SignosT[l - 1] == '^')
                                {
                                    fx[i] = Math.Pow(fx[i], Math.Cos(b));
                                }
                                else
                                {
                                    fx[i] = fx[i] * Math.Cos(b);
                                }
                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        else
                        {
                            for (int i = 0; i < N; i++)
                            {
                                    fx[i] = fx[i] * Math.Cos(b);

                                b = OperarDentroParen(limI, limS, np);
                            }
                        }
                        break;
                    case 't':
                        if (l != 0)
                        {
                            np = np + 1;
                            for (int i = 0; i < N; i++)
                            {
                                if (SignosT[l - 1] == '*')
                                {
                                    fx[i] = fx[i] * Math.Tan(b);
                                }
                                else if (SignosT[l - 1] == '÷')
                                {
                                    fx[i] = fx[i] / Math.Tan(b);
                                }
                                else if (SignosT[l - 1] == '+')
                                {
                                    fx[i] = fx[i] + Math.Tan(b);
                                }
                                else if (SignosT[l - 1] == '-')
                                {
                                    fx[i] = fx[i] - Math.Tan(b);
                                }
                                else if (SignosT[l - 1] == '^')
                                {
                                    fx[i] = Math.Pow(fx[i], Math.Tan(b));
                                }
                                else
                                {
                                    fx[i] = fx[i] * Math.Tan(b);
                                }
                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        else
                        {
                            for (int i = 0; i < N; i++)
                            {

                                    fx[i] = fx[i] * Math.Tan(b);

                                b = OperarDentroParen(limI, limS, np);
                            }
                        }
                        break;
                    case 's':
                        if (l != 0)
                        {
                            np = np + 1;
                            for (int i = 0; i < N; i++)
                            {
                                if (SignosT[l - 1] == '*')
                                {
                                    fx[i] = fx[i] * Math.Sin(b);
                                }
                                else if (SignosT[l - 1] == '÷')
                                {
                                    fx[i] = fx[i] / Math.Sin(b);
                                }
                                else if (SignosT[l - 1] == '+')
                                {
                                    fx[i] = fx[i] + Math.Sin(b);
                                }
                                else if (SignosT[l - 1] == '-')
                                {
                                    fx[i] = fx[i] - Math.Sin(b);
                                }
                                else if (SignosT[l - 1] == '^')
                                {
                                    fx[i] = Math.Pow(fx[i], Math.Sin(b));
                                }
                                else
                                {
                                    fx[i] = fx[i] * Math.Sin(b);
                                }
                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        else
                        {
                            for (int i = 0; i < N; i++)
                            {

                                    fx[i] = fx[i] * Math.Sin(b);

                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        break;
                    case '1':
                        if (l != 0)
                        {
                            np = np + 1;
                            for (int i = 0; i < N; i++)
                            {
                                if (SignosT[l - 1] == '*')
                                {
                                    fx[i] = fx[i] * Math.Cosh(b);
                                }
                                else if (SignosT[l - 1] == '÷')
                                {
                                    fx[i] = fx[i] / Math.Cosh(b);
                                }
                                else if (SignosT[l - 1] == '+')
                                {
                                    fx[i] = fx[i] + Math.Cosh(b);
                                }
                                else if (SignosT[l - 1] == '-')
                                {
                                    fx[i] = fx[i] - Math.Cosh(b);
                                }
                                else if (SignosT[l - 1] == '^')
                                {
                                    fx[i] = Math.Pow(fx[i], Math.Cosh(b));
                                }
                                else
                                {
                                    fx[i] = fx[i] * Math.Cosh(b);
                                }
                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        else
                        {
                            for (int i = 0; i < N; i++)
                            {

                                    fx[i] = fx[i] * Math.Cosh(b);

                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        break;
                    case '2':
                        if (l != 0)
                        {
                            np = np + 1;
                            for (int i = 0; i < N; i++)
                            {
                                if (SignosT[l - 1] == '*')
                                {
                                    fx[i] = fx[i] * Math.Sinh(b);
                                }
                                else if (SignosT[l - 1] == '÷')
                                {
                                    fx[i] = fx[i] / Math.Sinh(b);
                                }
                                else if (SignosT[l - 1] == '+')
                                {
                                    fx[i] = fx[i] + Math.Sinh(b);
                                }
                                else if (SignosT[l - 1] == '-')
                                {
                                    fx[i] = fx[i] - Math.Sinh(b);
                                }
                                else if (SignosT[l - 1] == '^')
                                {
                                    fx[i] = Math.Pow(fx[i], Math.Sinh(b));
                                }
                                else
                                {
                                    fx[i] = fx[i] * Math.Sinh(b);
                                }
                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        else
                        {
                            for (int i = 0; i < N; i++)
                            {
                                    fx[i] = fx[i] * Math.Sinh(b);

                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        break;
                    case '3':
                        if (l != 0)
                        {
                            np = np + 1;
                            for (int i = 0; i < N; i++)
                            {
                                if (SignosT[l - 1] == '*')
                                {
                                    fx[i] = fx[i] * Math.Tanh(b);
                                }
                                else if (SignosT[l - 1] == '÷')
                                {
                                    fx[i] = fx[i] / Math.Tanh(b);
                                }
                                else if (SignosT[l - 1] == '+')
                                {
                                    fx[i] = fx[i] + Math.Tanh(b);
                                }
                                else if (SignosT[l - 1] == '-')
                                {
                                    fx[i] = fx[i] - Math.Tanh(b);
                                }
                                else if (SignosT[l - 1] == '^')
                                {
                                    fx[i] = Math.Pow(fx[i], Math.Tanh(b));
                                }
                                else
                                {
                                    fx[i] = fx[i] * Math.Tanh(b);
                                }
                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        else
                        {
                            for (int i = 0; i < N; i++)
                            {
                                    fx[i] = fx[i] * Math.Tanh(b);
                                b = OperarDentroParen(limI, limS, np);

                            }
                        }
                        break;
                }
                verificar = Cadena(ref Trig);
                if (verificar == 'c')
                {
                    fun = 'c';
                }
                else if (verificar == 't')
                {
                    fun = 't';

                }
                else if (verificar == 's')
                {
                    fun = 's';
                }
                else if (verificar == '1')
                {
                    fun = '1';
                }
                else if (verificar == '2')
                {
                    fun = '2';
                }
                else if (verificar == '3')
                {
                    fun = '3';
                }
                else
                {
                    fun = 'v';
                }
                Limit = limI;
            }
            double Total = 0;
            double a2 = a1 / 3;
            for (int i = 0; i < fx.Length; i++)
            {
                Total += fx[i];
                ValorY.Add(fx[i]);
            }
            return (a1 * Total);
        }
        public void valor(string txtI)
        {
            Limit = double.Parse(txtI);
        }
        private double OperarDentroParen(double Inferior, double Superior, int np)
        {
            double Aumentar = 0;
            Aumentar = (Superior - Inferior) / (N - 1);
            double GuardarN = 0;
            double GuardarS = 0;
            int s = 0;
            for (int i = 0; i < variables.Count; i++)
            {

                if (np == variables[i].NParentesis)
                {

                    if (variables[i].tipo == Tipo.Variable)
                    {
                        variables[i].Valor = Limit;
                    }
                    else
                    {
                        GuardarS += variables[i].Valor;
                    }
                    if (variables[i].signoAdelante == '^')
                    {
                        variables[i].Valor = Math.Pow(variables[i].Valor, variables[i + 1].Valor);
                        //variables.Remove(variables[i + 1]);
                    }
                    if (variables[i].signoDetras == '√')
                    {
                        variables[i].Valor = Math.Sqrt(variables[i].Valor);
                        if (i != 0)
                        {
                            variables[i].signoDetras = variables[i - 1].signoAdelante;
                        }
                        else
                        {
                            variables[i].signoDetras = '(';
                        }
                    }
                    if (i == 0)
                    {
                        GuardarN += variables[i].Valor;
                    }
                    else
                    if (variables[i].signoDetras == '+')
                    {
                        GuardarN = GuardarN + variables[i].Valor;
                    }
                    else if (variables[i].signoDetras == '-')
                    {
                        GuardarN = GuardarN - variables[i].Valor;
                    }
                    else if (variables[i].signoDetras == '÷')
                    {
                        GuardarN = GuardarN / variables[i].Valor;
                    }
                    else if (variables[i].signoDetras == '*')
                    {
                        GuardarN = GuardarN * variables[i].Valor;
                    }
                    s++;

                }

            }
            if (Limit >= Superior)//-0.5)
            {
                for (int i = 0; i < s; i++)
                {
                    variables.Remove(variables[0]);
                    if (np == 1)
                    {
                        np = 1;
                    }
                }
            }
            ValorX.Add(Limit);
            s = 0;
            Limit += Aumentar;
            return GuardarN;
        }
        public void EscribirVariab(ref string rtb)
        {
            string verificar = rtb.Substring(rtb.Length - 1);
            if (rtb.IndexOf("(") < 0)
            {
                if (verificar == "^")
                {
                    throw new ArgumentException("En este momento no podemos resolver integrales exponenciales");
                }
                if (verificar != "*")
                {
                    rtb += "1*" + "X";
                    //NPolin.Add(1);
                }
                else
                {
                    rtb += "X";
                }
            }
            else
            {
                rtb += "X";
            }
        }
        public double IntegralesPolin(List<double> a, int n, double limitInf, double limitSup)
        {
            double fx;
            if (n < 0)
            {
                throw new ArgumentException("Lo sentimos, no podemos resolver ecuaciones con exponentes negativos;");
            }
            double suma = 0, x = limitInf;
            int c;
            if (a.Count <= n)
            {
                double num = 0;
                if (a.Count != 1)
                {
                    num = a[a.Count - 1];
                    a.RemoveAt(a.Count - 1);
                }
                for (int i = 0; i <= n; i++)
                {
                    if (i >= a.Count)
                    {
                        a.Add(0);
                    }
                }
                a[a.Count - 1] = num;
            }
            a.Reverse();
            for (int i = 0; i <= N; i++)
            {
                fx = 0;
                if (n == 0)
                {
                    fx = a[0];
                }
                else
                {
                    for (int j = 0; j <= n; j++)
                    {
                        if (limitInf == 0 && j == 0)
                        {
                            
                                fx = fx + a[j] * Math.Pow(1, j);
                            
                        }
                        else
                        {

                                fx = fx + a[j] * Math.Pow(x, j);
                        }
                    }
                }
                if (i == 0 || i == N)
                {
                    c = 1;
                }
                else if ((i % 2) == 0)
                {
                    c = 2;
                }
                else
                {
                    c = 4;
                }
                ValorY.Add(fx);
                suma = suma + c * fx;
                ValorX.Add(x);
                x = x + ((limitSup - limitInf) / N);
            }
            double r = (((limitSup - limitInf) / (3 * N)) * suma);
            a = new List<double>();
            return r;
        }
        public int posici = 0;
        public void ObtenerNume(string rtb)
        {
            int posit = rtb.IndexOf("∫");
            int mult = rtb.IndexOf("*");
            int neg = 0;
            double num = 0;
            if (mult > 0 && posit >= 0)
            {
                num = int.Parse(rtb.Substring(posit + 1, mult - (posit + 1)));
            }
            double GradoT = 0;
            for (int i = 0; i < rtb.Length - 1; i++)
            {
                if (mult > 0)
                {
                    GradoT = num;
                    NPolin.Add(GradoT);
                    posit = rtb.IndexOf("+", mult);
                    neg = rtb.IndexOf("-", mult);
                    mult = rtb.IndexOf("*", mult + 1);

                    if (mult > 0)
                    {
                        if (neg < posit && neg > 0)
                        {
                            num = int.Parse(rtb.Substring(neg, mult - (neg + 1)));
                        }
                        else if (posit > 0)
                        {
                            num = int.Parse(rtb.Substring(posit + 1, mult - (posit + 1)));
                        }
                    }
                }

            }
            int h = NPolin.Count;
        }
        public char Signos(string cont, char direcc)
        {
            char ch = 'v';
            if (direcc == 'a')
            {

                ch = char.Parse(cont.Substring(posici + 1, 1));

            }
            else
            {
                if (posici == 0)
                {
                    ch = char.Parse(cont.Substring(0, 1));
                }
                else
                {
                    ch = char.Parse(cont.Substring(posici - 1, 1));
                }

            }
            return ch;
        }
        public void Reiniciar(ref string txtIn, ref string txtSu, ref bool txtI, ref bool txtS)
        {
            NPolin = new List<double>();
            variables = new List<CantidadVariable>();
            Trig = "";
            cerrarP = new List<int>();
            abrirP = new List<int>();
            Limit = 0;
            txtIn = string.Empty;
            txtSu = string.Empty;
            txtI = false;
            txtS = false;
        }

        public void Variable(string rtbOperacion, string txtInferior)
        {
            posici = 0;
            string cont = "";
            if (abrirP != null || abrirP.Count != 0)
            {
                cont = rtbOperacion.Substring(abrirP[abrirP.Count - 1]);
                int encontrar = cont.IndexOf("X", posici);
                posici += encontrar;
                if (encontrar > 0)
                {
                    CantidadVariable c = new CantidadVariable()
                    {
                        NParentesis = abrirP.Count,
                        Valor = double.Parse(txtInferior),
                        Posic = posici,
                        signoAdelante = Signos(cont, 'a'),
                        signoDetras = Signos(cont, 'd'),
                        tipo = Tipo.Variable
                    };
                    variables.Add(c);
                }
                encontrar = cont.IndexOf("X", posici);
            }
            else
            {

            }

        }
        public void GuardarnumInteg(string txt, string button, string rtb)
        {
            posici = 0;
            string cont = rtb.Substring(abrirP[abrirP.Count - 1]);
            int encontrar = cont.IndexOf(txt);
            posici += encontrar;
            if (encontrar > 0)
            {
                CantidadVariable c = new CantidadVariable()
                {
                    NParentesis = abrirP.Count,
                    Valor = double.Parse(txt),
                    Posic = posici,
                    signoAdelante = char.Parse(button),
                    signoDetras = Signos(cont, 'd'),
                    tipo = Tipo.Numero
                };
                variables.Add(c);
            }
        }
        public void Igual(ref string txt, ref string rtb, string txtI, string txtS)
        {
            if (!string.IsNullOrEmpty(txtI))
            {
                valor(txtI);
            }
            string verificar = rtb.Substring(rtb.Length - 1);

            if (rtb.IndexOf("(") < 0)
            {
                ObtenerNume(rtb);
                if (rtb.Substring(rtb.Length - 1) == "^" && double.Parse(txt) < 0)
                {
                    throw new ArgumentException("Lo sentimos, no podemos resolver ecuaciones con exponentes negativos;");
                }
                rtb += txt;
                if (verificar != "^")
                {
                    NPolin.Add(double.Parse(txt));
                }
                txt = IntegralesPolin(NPolin, GradoPolin(rtb), double.Parse(txtI), double.Parse(txtS)).ToString();
                metodo.Guardarnum(double.Parse(txt));
                rtb = txt;
                NPolin = new List<double>();
                variables = new List<CantidadVariable>();
                Trig = "";
                cerrarP = new List<int>();
                abrirP = new List<int>();
                Limit = 0;
                op = 0;
                fun = 'v';

            }
            else
            {
                if (verificar!=")")
                {
                    throw new ArgumentException("Favor de cerrar la expresion con un )");
                }
                txt = Integral(fun, double.Parse(txtI), double.Parse(txtS)).ToString();
                metodo.Guardarnum(double.Parse(txt));
                rtb = txt;
                NPolin = new List<double>();
                variables = new List<CantidadVariable>();
                Trig = null;
                cerrarP = new List<int>();
                abrirP = new List<int>();
                Limit = 0;
                op = 0;
                fun = 'v';


            }

        }
        private int GradoPolin(string rtb)
        {
            int poten = rtb.IndexOf("^");
            int posit = rtb.IndexOf("+");
            string verificar = "";
            if (poten > 0)
            {
                verificar = rtb.Substring(poten + 1);
                string vr = rtb.Substring(poten+1);
                if(double.TryParse(vr, out double h1))
                {
                    if (double.Parse(vr)<0)
                    {
                        throw new ArgumentException("Lo sentimos, no podemos resolver ecuaciones con exponentes negativos;");
                    }
                }
            }
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
                if (GradoT < 0 || num < 0)
                {
                    throw new ArgumentException("Lo sentimos, no podemos resolver ecuaciones con exponentes negativos;");
                }
                for (int i = 0; i < rtb.Length - 1; i++)
                {
                    if (num > GradoT)
                    {
                        if (GradoT < 0 || num < 0)
                        {
                            throw new ArgumentException("Lo sentimos, no podemos resolver ecuaciones con exponentes negativos;");
                        }
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
                return int.MaxValue;
            }
        }
        public void Operaciones(ref string txt, ref string rtb, string button, string txtI)
        {
            string verificar = rtb.Substring(rtb.Length - 1);
            if (verificar == ")")
            {
                rtb += button;
                SignosT.Add(char.Parse(button));
                return;
            }
            if (rtb.IndexOf("(") < 0)
            {
                if (button == "*")
                {
                    if (verificar == "X")
                    {
                        return;
                    }
                    else
                    {
                        rtb += txt + button;
                        // NPolin.Add(double.Parse(txt));
                        txt = "0";
                    }
                }
                else if (verificar == "^")
                {
                    if (GradoPolin(rtb) <= double.Parse(txt))
                    {
                        throw new ArgumentException("Favor de escribir el polinomio en orden: aX^n + bX^n-1 + cX^n-2 + ...");
                    }
                    if (double.Parse(txt) < 0)
                    {
                        throw new ArgumentException("Lo sentimos, no podemos resolver ecuaciones con exponentes negativos;");
                    }
                    rtb += txt + button;
                    txt = "0";
                }
                else
                {
                    rtb += button;
                }


            }
            else
            if (button == "√")
            {
                rtb += button;
            }else
            if (txt != "0")
            {
                rtb += txt;
                rtb += button;

                GuardarnumInteg(txt, button, rtb);

            }else
                if (rtb.Substring(rtb.Length - 1) == "X" && button != "√")
                {
                rtb += button;
                Variable(rtb, txtI);
            }
        }
        public void OperacionesCien(ref string txt, ref string rtb, string btn)
        {
            string verificar = rtb.Substring(rtb.Length-1);
            string comprobar = ")";
            if (rtb.Length - 2 >= 0)
            {
                comprobar = rtb.Substring(rtb.Length - 2);
            }
            if (verificar != "("&&comprobar.IndexOf(")")>=0)
            {
                rtb += btn;
                AddA(rtb.Length - 1);
                if (op == 0)
                {
                    switch (btn)
                    {
                        case "Cos(":
                            fun = 'c';
                            break;
                        case "Sen(":
                            fun = 's';
                            break;
                        case "Tan(":
                            fun = 't';
                            break;
                        case "Cosh(":
                            fun = '1';
                            break;
                        case "Senh(":
                            fun = '2';
                            break;
                        case "Tanh(":
                            fun = '3';
                            break;
                    }
                    op = op + 1;
                }
                else
                {
                    switch (btn)
                    {
                        case "Cos(":
                            Trig += "c";
                            break;
                        case "Sen(":
                            Trig += "s";
                            break;
                        case "Tan(":
                            Trig += "t";
                            break;
                        case "Cosh(":
                            Trig += "1";
                            break;
                        case "Senh(":
                            Trig += "2";
                            break;
                        case "Tanh(":
                            Trig += "3";
                            break;
                        default:
                            Trig += "t";
                            break;
                    }
                }
                op = op + 1;
            }
        }
        public void Verificar(string txtI, string txtS, string rtb)
        {
            if (rtb.IndexOf("∫") >= 0)
            {
                if (string.IsNullOrEmpty(txtI) && string.IsNullOrEmpty(txtS))
                {
                    throw new ArgumentException("Introduzca ambos limites");
                }
                else
                {
                    if (!double.TryParse(txtI, out double a))
                    {
                        throw new ArgumentException($"Esto: {txtI} no es un numero (Limite Inferior)");
                    }
                    else
                    if (!double.TryParse(txtS, out double b))
                    {
                        throw new ArgumentException($"Esto: {txtS} no es un numero (Limite Superior)");
                    }
                    else if (double.Parse(txtI) > double.Parse(txtS))
                    {
                        throw new ArgumentException($"El limite inferior no puede ser mayor{Environment.NewLine}que el limite superior");
                    }else if (double.Parse(txtS) > 10000)
                    {
                        throw new ArgumentException($"El limite Superior es un numero demasiado grande");
                    }else if (double.Parse(txtI) < -10000)
                    {
                        throw new ArgumentException($"El limite Inferiror es un numero demasiado pequeño");
                    }
                }
            }
        }

        public List<double> GetValorX()
        {

            return ValorX;
        }

        public List<double> GetValorY()
        {

            return ValorY;
        }

        public List<double> DeleteX()
        {
            return ValorX = new List<double>();
        }

        public List<double> DeleteY()
        {
            return ValorY = new List<double>();
        }
    }
}
