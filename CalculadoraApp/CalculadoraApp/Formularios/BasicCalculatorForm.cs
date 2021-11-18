using AppCore.Interfaces;
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
        IOperacionesServices metodoDeOperaciones;
        IIntegralService integrales;
        public BasicCalculatorForm(IOperacionesServices metodoDeOperaciones ,IIntegralService integrales)
        {
            this.metodoDeOperaciones = metodoDeOperaciones;
            this.integrales = integrales;
           
            InitializeComponent();
        }
        private void ViewNumber(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                string txt = txtView.Text, rtb = rtbOperacion.Text;
                metodoDeOperaciones.ViewNumber(ref txt, ref rtb, button.Tag.ToString());
                txtView.Text = txt;
                rtbOperacion.Text = rtb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = txtView.Text, rtb = rtbOperacion.Text;
                metodoDeOperaciones.MasMenos(ref txt, ref rtb);
                txtView.Text = txt;
                rtbOperacion.Text = rtb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                integrales.Verificar(txtInferior.Text, txtSuperior.Text, rtbOperacion.Text);
                string txt = txtView.Text, rtb = rtbOperacion.Text;
            if (rtbOperacion.Text.IndexOf("∫") <0) {
                metodoDeOperaciones.Igual(ref txt, ref rtb);
            }
            else
            {
                integrales.Igual(ref txt, ref rtb, txtInferior.Text, txtSuperior.Text);
                    btnGraficarArea.Visible = true;
            }

                string cos = btnCos.Text, sen = btnSen.Text, tan = btnTan.Text,
                    cosh=btnCosh.Text,senh=btnSenh.Text,tanh=btnTanh.Text;
                metodoDeOperaciones.ParentesisT(ref cos, ref sen, ref tan, rtbOperacion.Text,ref cosh,ref senh,ref tanh);
                btnCos.Text = cos;
                btnSen.Text = sen;
                btnTan.Text = tan;
                btnCosh.Text = cosh;
                btnSenh.Text = senh;
                btnTanh.Text = tanh;
                txtView.Text = txt;
                rtbOperacion.Text = rtb;
                label1.Visible = false;
                label2.Visible = false;
                txtInferior.Visible = false;
                txtSuperior.Visible = false;
                btnInformation.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string txt = txtView.Text, rtb = rtbOperacion.Text;
            metodoDeOperaciones.Quitar(ref txt, ref rtb);
            txtView.Text = txt;
            rtbOperacion.Text = rtb;
        }
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                string txtIn = txtInferior.Text, txtSu = txtSuperior.Text;
                bool txtI = txtInferior.Visible, txtS = txtSuperior.Visible;
                integrales.Reiniciar(ref txtIn, ref txtSu, ref txtI, ref txtS);
                metodoDeOperaciones.Reiniciar();
                txtInferior.Text = txtIn;
                txtSuperior.Text = txtSu;
                label1.Visible = false;
                label2.Visible = false;
                txtInferior.Visible = txtI;
                txtSuperior.Visible = txtS;
                rtbOperacion.Text = string.Empty;
                txtView.Text = "0";
                string cos = btnCos.Text, sen = btnSen.Text, tan = btnTan.Text,
                    cosh = btnCosh.Text, senh = btnSenh.Text, tanh = btnTanh.Text;
                txtView.Text = "0";
                metodoDeOperaciones.ParentesisT(ref cos, ref sen, ref tan, rtbOperacion.Text, ref cosh, ref senh, ref tanh);
                btnCos.Text = cos;
                btnSen.Text = sen;
                btnTan.Text = tan;
                btnCosh.Text = cosh;
                btnSenh.Text = senh;
                btnTanh.Text = tanh;
                btnVariable.Visible = false;
                btnParentesis.Visible = false;
                btnGraficarArea.Visible = false;
                btnInformation.Visible = false;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtView.Text = "0";
        }
        private void ClickOperaciones(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                string txt = txtView.Text, rtb = rtbOperacion.Text;
                if (rtbOperacion.Text.IndexOf("∫") < 0)
                {
                    metodoDeOperaciones.Operaciones(ref txt, ref rtb, button.Tag.ToString(), txtInferior.Text);
                }
                else
                {
                    integrales.Operaciones(ref txt, ref rtb, button.Tag.ToString(), txtInferior.Text);
                }
                txtView.Text = txt;
                rtbOperacion.Text = rtb;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void ClickTrigonometria(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                string txt = txtView.Text, rtb = rtbOperacion.Text;
                if (rtbOperacion.Text.IndexOf("∫") < 0)
                {
                    metodoDeOperaciones.OperacionesCien(ref txt, ref rtb, button.Text.ToString());
                }
                else
                {
                    integrales.OperacionesCien(ref txt, ref rtb, button.Text.ToString());
                }
                txtView.Text = txt;
                rtbOperacion.Text = rtb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RadGrad(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "Grad")
            {
                lblGrado.Visible = true;
                lblRadians.Visible = false;
                metodoDeOperaciones.Ang('g');
            }
            else
            {
                lblGrado.Visible = false;
                lblRadians.Visible = true;
                metodoDeOperaciones.Ang('r');
            }
        }
        private void btnIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                label1.Visible = true;
                label2.Visible = true;
                txtInferior.Visible = true;
                txtSuperior.Visible = true;
                rtbOperacion.Text = button.Text;
                string cos = btnCos.Text, sen = btnSen.Text, tan = btnTan.Text,
                    cosh = btnCosh.Text, senh = btnSenh.Text, tanh = btnTanh.Text;
                txtView.Text = "0";
                metodoDeOperaciones.ParentesisT(ref cos, ref sen, ref tan, rtbOperacion.Text, ref cosh, ref senh, ref tanh);
                btnCos.Text = cos;
                btnSen.Text = sen;
                btnTan.Text = tan;
                btnCosh.Text = cosh;
                btnSenh.Text = senh;
                btnTanh.Text = tanh;
                btnVariable.Visible = true;
                btnParentesis.Visible = true;
                btnInformation.Visible = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnParentesis_Click(object sender, EventArgs e)
        {
            try
            {
                string rtb = rtbOperacion.Text;
                string txtI = txtInferior.Text;
                string txt = txtView.Text;
                integrales.AddC(ref rtb, txtI, ref txt);
                rtbOperacion.Text = rtb;
                txtView.Text = txt;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
            try
            {
                // string rtb = rtbOperacion.Text;
                //metodoDeOperaciones.Variable(rtb, txtInferior.Text);
                string rtb = rtbOperacion.Text;
                integrales.EscribirVariab(ref rtb);
                rtbOperacion.Text = rtb;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
        private void btnAbrirP_Click(object sender, EventArgs e)
        {
            if (rtbOperacion.Text == string.Empty)
            {
                rtbOperacion.Text = " ";
            }
            string verificar = rtbOperacion.Text.Substring(rtbOperacion.Text.Length - 1);
            if (verificar != "(")
            {
                integrales.AddA(rtbOperacion.Text.Length - 1);
                rtbOperacion.Text += "(";
            }
        }

        private void btnGraficarArea_Click(object sender, EventArgs e)
        {
            try
            {
                double verificar = double.Parse(txtView.Text);
                if (verificar > 10000)
                {
                    verificar = 9000;
                }
                GraphicsForm graphics = new GraphicsForm(integrales.GetValorX(), integrales.GetValorY(), double.Parse(txtInferior.Text), double.Parse(txtSuperior.Text),verificar);
                graphics.ShowDialog();
                integrales.DeleteX();
                integrales.DeleteY();
                btnGraficarArea.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            string info = $"Esta es una calculadora cientifica capaz de calcular y graficar algunos tipos de integrales. " +
                $"Las ecuaciones que puede resolver son solamente de tipo trigonometricas y polinomicas pero no las dos juntas ejemplo :Cos(x)X. " +
                $"Tampoco se puede resolver trigonometricas con potencias ejemplo: Cos(X)², ní exponenciales entre otras.  " +
                $"Otro detalle a considerar es que las ecuaciones trigonometricas se resuleven por medio del metodo del trapecio, " +
                $"el cual tiene un margen de error del 4.4% las mayorias de las veces (dependiendo de la complejidad del calculo).{Environment.NewLine}{Environment.NewLine} " +
                $"La grafica no soporta resultados muy elevados (Se recomienda no colocar potencias arriba de 12). ";
            MessageBox.Show(info, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BasicCalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
