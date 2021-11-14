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
        IntegralesModel integrales;
        public BasicCalculatorForm()
        {
            metodoDeOperaciones = new MetodoDeOperaciones();
            integrales = new IntegralesModel(metodoDeOperaciones);
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
            }
                string cos = btnCos.Text, sen = btnSen.Text, tan = btnTan.Text;
                metodoDeOperaciones.ParentesisT(ref cos, ref sen, ref tan, rtbOperacion.Text);
                btnCos.Text = cos;
                btnSen.Text = sen;
                btnTan.Text = tan;
                txtView.Text = txt;
                rtbOperacion.Text = rtb;
                label1.Visible = false;
                label2.Visible = false;
                txtInferior.Visible = false;
                txtSuperior.Visible = false;
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
            string txtIn = txtInferior.Text, txtSu = txtSuperior.Text;
            bool txtI = txtInferior.Visible, txtS = txtSuperior.Visible;
            integrales.Reiniciar(ref txtIn,ref txtSu,ref txtI,ref txtS);
            metodoDeOperaciones.Reiniciar();
            txtInferior.Text = txtIn;
            txtSuperior.Text=txtSu;
            label1.Visible = false;
            label2.Visible = false;
            txtInferior.Visible = txtI;
            txtSuperior.Visible = txtS;
            string cos = btnCos.Text, sen = btnSen.Text, tan = btnTan.Text;
            metodoDeOperaciones.ParentesisT(ref cos, ref sen, ref tan,rtbOperacion.Text);
            btnCos.Text = cos;
            btnSen.Text = sen;
            btnTan.Text = tan;
            btnVariable.Visible = false;
            btnParentesis.Visible = false;
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
                integrales.ObtenerSimb(rtbOperacion.Text);
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

        private void txtView_TextChanged(object sender, EventArgs e)
        {

        }

        private void BasicCalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void rtbOperacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            label1.Visible = true;
            label2.Visible = true;
            txtInferior.Visible = true;
            txtSuperior.Visible = true;
            rtbOperacion.Text = button.Text;
            string cos = btnCos.Text, sen = btnSen.Text, tan = btnTan.Text;
            txtView.Text = "0";
            metodoDeOperaciones.ParentesisT(ref cos,ref sen,ref tan,rtbOperacion.Text);
            btnCos.Text = cos;
            btnSen.Text = sen;
            btnTan.Text = tan;
            btnVariable.Visible = true;
            btnParentesis.Visible = true;
        }
        private void btnParentesis_Click(object sender, EventArgs e)
        {
            string rtb= rtbOperacion.Text;
            string txtI = txtInferior.Text;
            string txt = txtView.Text;
            integrales.AddC(ref rtb ,txtI,ref txt);
            rtbOperacion.Text = rtb;
            txtView.Text = txt;
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
                GraphicsForm graphics = new GraphicsForm(integrales.ValorX, integrales.ValorY, double.Parse(txtInferior.Text), double.Parse(txtSuperior.Text), double.Parse(txtView.Text));
                graphics.ShowDialog();
                integrales.ValorX = new List<double>();
                integrales.ValorY = new List<double>();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
}
