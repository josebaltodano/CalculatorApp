using Infraestructura.Metodos;
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
    public partial class BasicCalculatorForm : Form
    {
        MetodoDeOperaciones metodoDeOperaciones;
        int a = 0, b = 0;
        public BasicCalculatorForm()
        {
            metodoDeOperaciones = new MetodoDeOperaciones();
            InitializeComponent();
        }
        private void ViewNumber(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (b >= 1)
            {
                txtView.Text = string.Empty;
                b--;
            }
            if (txtView.Text == "0")
            {
                txtView.Text = string.Empty;
            }
            if (button.Text == "π")
            {

                txtView.Text = Math.PI.ToString();
                return;
            }
            else
            {
                txtView.Text += button.Text;
            }
            //txtOperacion.Text += button.Text;

        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            if (txtView.Text=="0")
            {
                return;
            }
            string c="";
            double v = double.Parse(txtView.Text);
            if (rtbOperacion.Text.Length == v.ToString().Length)
            {
                if (v > 0)
                {
                    c = "-" + txtView.Text;
                    txtView.Text = c;
                    rtbOperacion.Text = c;
                }
                else
                {
                    c = txtView.Text.Substring(1);
                    txtView.Text = c;
                    c = rtbOperacion.Text.Substring(0, rtbOperacion.Text.Length - 2);
                    rtbOperacion.Text = c + txtView.Text;
                }
            }
            else
            {
                if (v > 0)
                {
                    c = "-" + txtView.Text;
                    txtView.Text = c;
                    //c = txtOperacion.Text.Substring(0, txtOperacion.Text.Length - 2);
                    //txtOperacion.Text = c + txtView.Text;
                }
                else
                {
                    c = txtView.Text.Substring(1);
                    txtView.Text = c;
                    //c = txtOperacion.Text.Substring(0, txtOperacion.Text.Length - 2);
                    //txtOperacion.Text = c + txtView.Text;
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string verificar = rtbOperacion.Text.Substring(rtbOperacion.Text.Length - 1);
            
            if (metodoDeOperaciones.operador == '%')
            {
                metodoDeOperaciones.Guardarnum(double.Parse(txtView.Text));
                rtbOperacion.Text += txtView.Text;
                txtView.Text = metodoDeOperaciones.Resultado().ToString();
                a = 0;
            }
            else
            {
                if (double.TryParse(verificar, out double a))
                {
                    metodoDeOperaciones.Guardarnum(double.Parse(txtView.Text));
                    rtbOperacion.Text +=$"{metodoDeOperaciones.operador}"+ txtView.Text;
                    txtView.Text = metodoDeOperaciones.Resultado().ToString();
                    rtbOperacion.Text += " = " + txtView.Text;
                    a = 0;
                }
                else
                {
                    metodoDeOperaciones.Guardarnum(double.Parse(txtView.Text));
                    rtbOperacion.Text += txtView.Text;
                    txtView.Text = metodoDeOperaciones.Resultado().ToString();
                    rtbOperacion.Text += " = " + txtView.Text;
                    a = 0;
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string c = txtView.Text.Substring(0,txtView.Text.Length-1);
            txtView.Text=c;
            if (metodoDeOperaciones.operador=='v') {
                rtbOperacion.Text = c;
            }
            if (txtView.Text == string.Empty)
            {
                txtView.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            metodoDeOperaciones.Reiniciar();
            rtbOperacion.Text = string.Empty;
            txtView.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtView.Text = "0";
            if (metodoDeOperaciones.operador == 'v')
            {
                rtbOperacion.Text = string.Empty;
            }
        }


        private void ClickOperaciones(object sender, EventArgs e)
        {
            //txtOperacion.Text = "";
            var button = (Button)sender;
            if (rtbOperacion.Text != string.Empty)
            {
                string verificar = rtbOperacion.Text.Substring(rtbOperacion.Text.Length - 1);
                if(button.Text== "%")
                {
                    metodoDeOperaciones.Guardarnum(double.Parse(txtView.Text));
                    metodoDeOperaciones.operador = '%';
                    rtbOperacion.Text = string.Empty;
                    txtView.Text = metodoDeOperaciones.Resultado().ToString();
                    return;
                }
                else
                if (!double.TryParse(verificar, out double a))
                {
                    return;
                }
            }
            if (button.Tag.ToString() != "√")
            {
                if (txtView.Text == "0")
                {
                    return;
                }
                rtbOperacion.Text = txtView.Text;
            }
            else
            {
                rtbOperacion.Text = string.Empty;
            }
            if (a >= 1)
            {
                metodoDeOperaciones.Guardarnum(double.Parse(txtView.Text));
                rtbOperacion.Text += button.Tag;
                //txtView.Text = metodoDeOperaciones.Resultado().ToString();
                b = 1;
                rtbOperacion.Text = txtView.Text + button.Tag;
                if (button.Text == "%")
                {
                    metodoDeOperaciones.operador = '+';
                    

                }
                else
                {
                    metodoDeOperaciones.operador = Convert.ToChar(button.Tag);
                }
            }
            else
            {
                metodoDeOperaciones.Guardarnum(double.Parse(txtView.Text));
                txtView.Text = "0";
                //txtView.Text = metodoDeOperaciones.Resultado().ToString();
                metodoDeOperaciones.operador = Convert.ToChar(button.Tag);
                if (button.Text == "%")
                {
                    metodoDeOperaciones.operador = '%';
                    rtbOperacion.Text = string.Empty;
                    txtView.Text = metodoDeOperaciones.Resultado().ToString();
                }
                else
                {
                    rtbOperacion.Text += button.Tag;
                }
            }
            a++;
        }
    }
}
