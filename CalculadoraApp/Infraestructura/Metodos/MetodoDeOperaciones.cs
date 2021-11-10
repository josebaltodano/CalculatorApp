using Domain.OperacionesBasicas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Metodos
{
    public class MetodoDeOperaciones
    {

        #region MetodosBasicos

        private OperacionesBasicas operacionesBasicas = new OperacionesBasicas();
        public double[] numeros;
        int a1 = 0, b = 0, a;
        public int y = 0;
        public char operador = 'v';
        public double numero1 = 0, numero2 = 0;
        string operadorT = "";
        char AngPlano = 'r';
        public void Ang(char an)
        {
            AngPlano = an;
        }
        public void Add(double n)
        {
            if (numeros == null)
            {
                numeros = new double[1];
                numeros[numeros.Length - 1] = n;
                return;
            }
            double[] tmp = new double[numeros.Length + 1];
            Array.Copy(numeros, tmp, numeros.Length);
            tmp[tmp.Length - 1] = n;
            numeros = tmp;


        }
        public double GetNumber(string txt, char op)
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
            }
            else
            {
                int b = f.IndexOf(op, y - 1);
                y = txt.Length;
                a++;
                numero2 = double.Parse(f.Substring(b + 1));
                return double.Parse(f.Substring(b + 1));
            }
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
        int NP = 0;
        public void GuardarnumInteg(string txt, string button, string rtb)
        {
            /*posici = 0;
            string cont = rtbOperacion.Substring(abrirP[abrirP.Count - 1]);
            int encontrar = cont.IndexOf("X", posici);
            posici += encontrar;*/
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
                // encontrar = cont.IndexOf("X", posici);
            }
            // posici = posici - 1;
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
                        double n = numero2 * (Math.PI / 180);
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
        int op = 0;
        public void OperacionesCien(ref string txt, ref string rtb, string btn)
        {
            if (string.IsNullOrEmpty(rtb))
            {
                rtb = "0";
            }
            if (btn == "Log")
            {
                operador = 'l';
            }
            else if (btn == "Ln")
            {
                operador = 'n';
            }
            if (rtb.IndexOf("∫", 0) >= 0)
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
                        default:
                            Trig += "t";
                            break;
                    }
                }
                op = op + 1;
            }
            else
            {
                string op = operador.ToString();
                string verificar = rtb.Substring(rtb.Length - 1);
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
        char fun;
        public void Igual(ref string txt, ref string rtb, string txtI, string txtS)
        {
            if (!string.IsNullOrEmpty(txtI))
            {
                valor(txtI);
            }
            string verificar = rtb.Substring(rtb.Length - 1);
            if (rtb.IndexOf("∫") >= 0)
            {
                if (rtb.IndexOf("(") < 0)
                {
                    ObtenerNume(rtb);
                    rtb += txt;
                    NPolin.Add(double.Parse(txt));
                    txt = IntegralesPolin(NPolin, GradoPolin(rtb), double.Parse(txtI), double.Parse(txtS)).ToString();
                }
                else
                {
                    txt = Integral(fun, double.Parse(txtI), double.Parse(txtS)).ToString();
                    Guardarnum(double.Parse(txt));
                }

            }
            else
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
            /*if (operador == 'v')
            {
                rtb = c;
            }*/
            if (txt == string.Empty)
            {
                txt = "0";
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
                    }
                }
            }
        }
        List<double> NPolin = new List<double>();
       // List<int> GradoPol = new List<int>();
        public int GradoPolin(string rtb)
        {
            int poten = rtb.IndexOf("^");
            int posit = rtb.IndexOf("+");
            int num = 0;
            if (posit>0&&poten>0) {
                num = int.Parse(rtb.Substring(poten+1, posit-(poten+1)));
            }
            int GradoT = 0;
            for (int i = 0;i<rtb.Length-1;i++)
            {
                if (num > GradoT)
                {
                    GradoT = num;
                    poten = rtb.IndexOf("^",posit);
                    posit = rtb.IndexOf("+",posit+1);
                    if (posit > 0 && poten > 0)
                    {
                        num = int.Parse(rtb.Substring(poten+1, posit - (poten + 1)));
                    }
                }
            }
            return GradoT;
        }
        public void Operaciones(ref string txt, ref string rtb, string button, string txtI)
        {
            int si = 0;
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
                if (!double.TryParse(verificar, out double a) && rtb.IndexOf("∫") < 0)
                {
                    return;
                }
            }
            if (rtb.IndexOf("∫") >= 0)
            {
                string verificar = rtb.Substring(rtb.Length - 1);
                if (rtb.IndexOf("(") < 0)
                {
                    if (button == "*")
                    {
                        if (verificar=="X")
                        {
                            return;
                        }
                        if (rtb.Length!=1) {
                            rtb += txt + button;
                           // NPolin.Add(double.Parse(txt));
                            txt = "0";
                        }
                        else 
                        {
                            rtb +=txt + button;
                           // NPolin.Add(double.Parse(txt));
                            txt = "0";
                        }
                    }
                    else if(verificar=="^")
                    {
                        rtb += txt+button;
                        txt = "0";
                    }else
                    {
                        rtb += button;
                    }

                    
                }else
                if (txt != "0")
                {
                    rtb += txt;
                    rtb += button;

                    GuardarnumInteg(txt, button, rtb);

                }
                else //if(verificar ==")")
                {
                    rtb += button;
                    if (rtb.Substring(rtb.Length - 1) != "X")
                    {
                        Variable(rtb, txtI);
                    }
                    NP++;
                }
            }
            else
            {
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
            else if (button == "e")
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
        //*******Metodo de integrales********
        int N = 2000;

        string Trig = "";
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
                NP++;
                txt = "0";
            }
            else
            {
                if (rtb.IndexOf("∫", 0) >= 0)
                {
                    rtb += ")";
                    cerrarP.Add(rtb.Length - 1);
                    Variable(rtb, txtI);
                    NP++;
                    txt = "0";
                }
            }
        }
        List<char> Simb = new List<char>();
        public void ObtenerSimb(string rtb)
        {
            if (rtb.IndexOf("∫") >= 0)
            {
                string simb = rtb.Substring(rtb.Length - 1);
                Simb.Add(char.Parse(simb));
            }

        }
        public void AddA(int p)
        {
            abrirP.Add(p);
        }
        public void Obtener()
        {

        }
        public double Integral(char fun, double limI, double limS)
        {

            char verificar;
            int np = 1;
            double a1 = (limS - limI) / N;
            double b = OperarDentroParen(limI, limS, np);
            double c = b;
            int v = Trig.Length;
            double[] fx = new double[N];
            for (int i = 0; i < N; i++)
            {
                fx[i] = 1;
            }
            for (int l = 0; l <= v; l++)
            {
                b = c;
                switch (fun)
                {
                    case 'c':
                        if (l != 0)
                        {
                            np = np + 1;
                        }
                        for (int i = 0; i < N; i++)
                        {

                            if (i == 0)
                            {
                                fx[i] = fx[i] * Math.Cos(b);
                            }
                            else
                            {
                                fx[i] = fx[i] * Math.Cos(b);
                            }
                            b = OperarDentroParen(limI, limS, np);

                        }
                        break;
                    case 't':
                        if (l != 0)
                        {
                            np = np + 1;
                        }
                        for (int i = 0; i < N; i++)
                        {
                            if (i == 0)
                            {
                                fx[i] = fx[i] * Math.Tan(b);
                            }
                            else
                            {
                                fx[i] = fx[i] * Math.Tan(b);
                            }
                            
                            b = OperarDentroParen(limI, limS, np);
                        }
                        break;
                    case 's':
                        if (l != 0)
                        {
                            np = np + 1;
                        }
                        for (int i = 0; i < N; i++)
                        {
                            if (i == 0)
                            {
                                fx[i] = fx[i] * Math.Sin(b);
                            }
                            else
                            {
                                fx[i] = fx[i] * Math.Sin(b);
                            }
                            b = OperarDentroParen(limI, limS, np);
                            
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
                else
                {
                    fun = 'v';
                }
                Limit = limI;
            }
            double Total = 0;
            double a2 = a1 / 3;
            return a1 * Total;
        }

        double Limit;
        List<int> cerrarP = new List<int>();
        List<int> abrirP = new List<int>();
        List<CantidadVariable> variables = new List<CantidadVariable>();
        public void valor(string txtI)
        {
            Limit = double.Parse(txtI);
        }
        int salir = 0;
        public double OperarDentroParen(double Inferior, double Superior, int np)
        {
            //  throw new ArgumentException($"cerrarP {cerrarP.Count},variables {variables.Count}");
            double Aumentar = 0;
            Aumentar = (Superior - Inferior) / N;
            //throw new ArgumentException(""+Aumentar+"  "+Limit);
            double GuardarN = 0;
            double GuardarS = 0;
            int s = 0;
            List<double> Valordentro = new List<double>();

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
                        variables.Remove(variables[i + 1]);
                    }
                    if (variables[i].signoDetras == '√')
                    {
                        variables[i].Valor = Math.Sqrt(variables[i].Valor);
                        if (i != 0)
                        {
                            variables[i].signoDetras = variables[i - 1].signoAdelante;
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
                    else if (variables[i].signoDetras == '/')
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
            if (GuardarN >= Superior-0.5)
            {
                for (int i = 0; i < s; i++)
                {
                    variables.Remove(variables[0]);
                    
                }
            }
            /*if (GuardarN>=7)
            {
                np = np;
            }*/
            s = 0;
            Limit += Aumentar;
            return GuardarN;
        }
        public double IntegralesPolin(List<double> a, int n, double limitInf, double limitSup)
        {
            double fx;
            double suma = 0, x = limitInf;
            int c;
            a.Reverse();
            /*if ((limitSup + limitInf) == 0)
            {
                return 0;
            }*/
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
                suma = suma + c * Math.Abs(fx);
                x = x + ((limitSup - limitInf) / N);
            }
            double r = (((limitSup - limitInf) / (3 * N)) * suma);
            a = new List<double>();
            return r;
        }
        int posici = 0;
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
                if (num > GradoT)
                {
                    GradoT = num;
                    NPolin.Add(GradoT);
                    posit = rtb.IndexOf("+", mult);
                    neg = rtb.IndexOf("-",mult);
                    mult = rtb.IndexOf("*", mult + 1);

                    if (mult > 0)
                    {
                        if (neg < posit && neg > 0)
                        {
                            num = int.Parse(rtb.Substring(neg, mult - (neg + 1)));
                        }
                        else if(posit>0)
                        {
                            num = int.Parse(rtb.Substring(posit + 1, mult - (posit + 1)));
                        }
                    }
                }
            }
        }
        public char Signos(string cont, char direcc)
        {
            char ch = 'v';
            if (direcc == 'a')
            {

                ch = char.Parse(cont.Substring(posici, 1));

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

        public void Variable(string rtbOperacion, string txtInferior)
        {
            posici = 0;
            string cont = "";
            if (abrirP != null||abrirP.Count!=0)
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
        #endregion
    }
    public class Numeros
    {
        public double Valor { get; set; }
        public int posc { get; set; }
    }
    public enum Tipo
    {
        Variable,
        Operador,
        Numero
    }
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
