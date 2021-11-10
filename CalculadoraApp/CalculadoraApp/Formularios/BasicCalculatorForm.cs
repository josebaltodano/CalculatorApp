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
        public BasicCalculatorForm()
        {
            metodoDeOperaciones = new MetodoDeOperaciones();
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
            /*try
            {*/
                metodoDeOperaciones.Verificar(txtInferior.Text, txtSuperior.Text, rtbOperacion.Text);
                string txt = txtView.Text, rtb = rtbOperacion.Text;
                metodoDeOperaciones.Igual(ref txt, ref rtb, txtInferior.Text, txtSuperior.Text);
                txtView.Text = txt;
                rtbOperacion.Text = rtb;
            /*}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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
            /*try
            {*/
                var button = (Button)sender;
                string txt = txtView.Text, rtb = rtbOperacion.Text;
                metodoDeOperaciones.Operaciones(ref txt, ref rtb, button.Tag.ToString(),txtInferior.Text);
                txtView.Text = txt;
                rtbOperacion.Text = rtb;
            /*}catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
        }
        private void ClickTrigonometria(object sender, EventArgs e)
        {
            try
            {
                metodoDeOperaciones.ObtenerSimb(rtbOperacion.Text);
                var button = (Button)sender;
                string txt = txtView.Text, rtb = rtbOperacion.Text;
                metodoDeOperaciones.OperacionesCien(ref txt, ref rtb, button.Text.ToString());
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
        }
        private void btnParentesis_Click(object sender, EventArgs e)
        {
            string rtb= rtbOperacion.Text;
            string txtI = txtInferior.Text;
            string txt = txtView.Text;
            metodoDeOperaciones.AddC(ref rtb ,txtI,ref txt);
            rtbOperacion.Text = rtb;
            txtView.Text = txt;
        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
           // string rtb = rtbOperacion.Text;
            //metodoDeOperaciones.Variable(rtb, txtInferior.Text);
            rtbOperacion.Text += "X";
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
                metodoDeOperaciones.AddA(rtbOperacion.Text.Length - 1);
                rtbOperacion.Text += "(";
            }
        }
    }
    
}
