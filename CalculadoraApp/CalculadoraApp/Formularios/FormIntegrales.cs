using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraApp.Formularios
{
    public partial class FormIntegrales : Form
    {
        public FormIntegrales()
        {
            InitializeComponent();
        }
        int N = 2000;
        public double IntegralesPolin(double[] a,int n,float limitInf,float limitSup)
        {
            double fx;
            double suma=0, x=limitInf;
            int c;
            /*if ((limitSup + limitInf) == 0)
            {
                return 0;
            }*/
            for(int i = 0; i <= N; i++)
            {
                fx = 0;
                if (n == 0)
                {
                    fx = a[0];
                }
                else
                {
                    for (int j=0;j<=n;j++)
                    {
                        if (limitInf == 0 && j==0)
                        {
                            fx = fx + a[j] * Math.Pow(1,j);
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
                }else if ((i%2)==0)
                {
                    c = 2;
                }
                else
                {
                    c = 4;
                }
                suma = suma + c * Math.Abs(fx);
                x = x + ((limitSup - limitInf)/N);
            }
            double r= (((limitSup - limitInf) / (3 * N)) * suma);
            return Math.Round(r);
        }
        public char Cadena(ref string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                throw new ArgumentException("Error");
            }
            char c='v';
            string R = "";
            if (a.Length == 1)
            {
                c= Char.Parse(a);
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
        Char Fun;
        string Trig="";
        public Double Integral(Char fun, double limI, double limS)
        {
            int v = Trig.Length;
            double a = (limS - limI) / N;
            double b = 0;
            double[] fx = new double[N + 1];
            char verificar = Cadena(ref Trig);
            for (int i = 0; i <= N; i++)
            {
                fx[i] = 1;
            }
            for (int l = 0; l <= v; l++)
            {
                switch (fun)
                {
                    case 'c':
                        b = limI;
                        for (int i = 0; i <= N; i++)
                        {
                            if (i == 0)
                            {
                                fx[i] = fx[i] * Math.Cos(b);
                            }
                            else
                            {
                                b = b + a;
                                fx[i] = fx[i] * Math.Cos(b);
                            }
                        }
                        break;
                    case 't':
                        b = limI;
                        for (int i = 0; i <= N; i++)
                        {
                            if (i == 0)
                            {
                                fx[i] = fx[i] * Math.Tan(b);
                            }
                            else
                            {
                                b = b + a;
                                fx[i] = fx[i] * Math.Tan(b);
                            }
                        }
                        break;
                    case 's':
                        b = limI;
                        for (int i = 0; i <= N; i++)
                        {
                            if (i == 0)
                            {
                                fx[i] = fx[i] * Math.Sin(b);
                            }
                            else
                            {
                                b = b + a;
                                fx[i] = fx[i] * Math.Sin(b);
                            }
                        }
                        
                        break;
                }
                if (verificar == 'c')
                {
                    MessageBox.Show("1", verificar.ToString());
                    fun = 'c';
                    verificar = Cadena(ref Trig);
                }
                else if (verificar == 't')
                {
                    fun = 't';

                }
                else if (verificar == 's')
                {
                    fun = 's';

                }
                if (Trig.Length!=0)
                {
                    verificar = Cadena(ref Trig);
                }
            }
            double Total=0;
            for (int i = 0; i <= N; i++)
            {
                Total =Total+(a * fx[i]);
            }
            return Total;
        }
        public double IntegTodas(Char fx, float limitInf, float limitSup)
        {
            double BaseRectan = (limitSup - limitInf)/N;
            double FX = 0;
            double si = limitInf;
            if (fx=='s')
            {
                for (int i=0;i<=N;i++)
                {
                    if (i == 0)
                    {
                        FX = FX + (BaseRectan * (Math.Sin(si)*Math.Tan(si)));
                    }
                    else
                    {
                        si = si + BaseRectan;
                        FX = FX + (BaseRectan * (Math.Sin(si) * Math.Tan(si)));
                    }
                }
            }
            return FX;
        }
        int i1 = 0;
        int contador2 = 0;
        private void ClickTrigonometria(object sender, EventArgs e)
        {
            try
            {
                if (contador2 == 0)
                {
                    var button = (Button)sender;
                    rtbMostrar.Text += button.Text;
                    Fun = char.Parse(button.Tag.ToString());
                    contador2++;
                }
                else
                {
                    var button = (Button)sender;
                    rtbMostrar.Text += button.Text;
                    Trig += button.Tag.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClickOperaciones(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("La respuesta es: " + Integral(Fun, double.Parse(txtInferior.Text), double.Parse(txtSuperior.Text)));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
