using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infraestructura.Metodos;

namespace CalculadoraApp.Formularios
{
    public partial class FormIntegrales : Form
    {
        MetodoDeOperaciones metodo;
        public FormIntegrales()
        {
            InitializeComponent();
            metodo = new MetodoDeOperaciones();
        }
        int N = 2000, exten = 0;
        double[] numeros = new double[0];
        private void ViewNumber(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                string rtb = rtbMostrar.Text,txt=txtView.Text;
                metodo.ViewNumber(ref txt, ref rtb, button.Tag.ToString());
                rtbMostrar.Text = rtb;
                txtView.Text = txt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
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
                            /*if (j == 2)
                            {
                                double b= a[j];
                                j = j;
                            }*/
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
        int contador2 = 0;
        Char Fun;
        string Trig = "";
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

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("La respuesta es: " + metodo.Integral(Fun, double.Parse(txtInferior.Text), double.Parse(txtSuperior.Text)));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rtbMostrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInferior_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
            string a = rtbMostrar.Text;
            string verificar = a.Substring(a.Length - 2, a.Length-1);
            if (!double.TryParse(verificar, out double b))
            {

            }
            rtbMostrar.Text += "x";
        }
        private void Operadores1(object sender, EventArgs e)
        {
            string verificar = rtbMostrar.Text.Substring(rtbMostrar.Text.Length-1);
            if (double.TryParse(verificar, out double a))
            {
                rtbMostrar.Text += ")";
            }

        }
        private void FormIntegrales_Load(object sender, EventArgs e)
        {

        }
    }
}
