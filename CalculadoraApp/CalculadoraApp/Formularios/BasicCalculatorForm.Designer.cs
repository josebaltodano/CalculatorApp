
namespace CalculadoraApp.Formularios
{
    partial class BasicCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtView = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnInverso = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMasMenos = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.rtbOperacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtView
            // 
            this.txtView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtView.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView.Location = new System.Drawing.Point(9, 38);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ReadOnly = true;
            this.txtView.Size = new System.Drawing.Size(242, 37);
            this.txtView.TabIndex = 0;
            this.txtView.Text = "0";
            this.txtView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(74, 81);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(56, 45);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnInverso
            // 
            this.btnInverso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInverso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverso.Location = new System.Drawing.Point(12, 132);
            this.btnInverso.Name = "btnInverso";
            this.btnInverso.Size = new System.Drawing.Size(56, 45);
            this.btnInverso.TabIndex = 5;
            this.btnInverso.Tag = "π";
            this.btnInverso.Text = "π";
            this.btnInverso.UseVisualStyleBackColor = false;
            this.btnInverso.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(198, 132);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(56, 45);
            this.btnDividir.TabIndex = 6;
            this.btnDividir.Tag = "÷";
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.ClickOperaciones);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(198, 81);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(56, 45);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "<-";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.Location = new System.Drawing.Point(12, 81);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(56, 45);
            this.btnPorcentaje.TabIndex = 8;
            this.btnPorcentaje.Tag = "%";
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = false;
            this.btnPorcentaje.Click += new System.EventHandler(this.ClickOperaciones);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Location = new System.Drawing.Point(136, 81);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(56, 45);
            this.btnBorrarTodo.TabIndex = 9;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRaizCuadrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizCuadrada.Location = new System.Drawing.Point(136, 132);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(56, 45);
            this.btnRaizCuadrada.TabIndex = 10;
            this.btnRaizCuadrada.Tag = "√";
            this.btnRaizCuadrada.Text = "√";
            this.btnRaizCuadrada.UseVisualStyleBackColor = false;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.ClickOperaciones);
            // 
            // btnPotencia
            // 
            this.btnPotencia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(74, 132);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(56, 45);
            this.btnPotencia.TabIndex = 11;
            this.btnPotencia.Tag = "^";
            this.btnPotencia.Text = "x^";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.ClickOperaciones);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 230);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 45);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 183);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 45);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 281);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 45);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btnMasMenos
            // 
            this.btnMasMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasMenos.Location = new System.Drawing.Point(12, 332);
            this.btnMasMenos.Name = "btnMasMenos";
            this.btnMasMenos.Size = new System.Drawing.Size(56, 45);
            this.btnMasMenos.TabIndex = 15;
            this.btnMasMenos.Text = "+/-";
            this.btnMasMenos.UseVisualStyleBackColor = true;
            this.btnMasMenos.Click += new System.EventHandler(this.btnMasMenos_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(136, 183);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 45);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(74, 230);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 45);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(74, 183);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 45);
            this.btn8.TabIndex = 18;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(198, 183);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(56, 45);
            this.btnMultiplicar.TabIndex = 19;
            this.btnMultiplicar.Tag = "*";
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.ClickOperaciones);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(136, 281);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 45);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(74, 281);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 45);
            this.btn2.TabIndex = 21;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(136, 230);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 45);
            this.btn6.TabIndex = 22;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(198, 230);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(56, 45);
            this.btnRestar.TabIndex = 23;
            this.btnRestar.Tag = "-";
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.ClickOperaciones);
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(198, 281);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(56, 45);
            this.btnSumar.TabIndex = 24;
            this.btnSumar.Tag = "+";
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.ClickOperaciones);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(198, 332);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(56, 45);
            this.btnIgual.TabIndex = 25;
            this.btnIgual.Tag = "=";
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(136, 332);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(56, 45);
            this.btnPunto.TabIndex = 26;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(74, 332);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 45);
            this.btn0.TabIndex = 27;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.ViewNumber);
            // 
            // rtbOperacion
            // 
            this.rtbOperacion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbOperacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOperacion.Location = new System.Drawing.Point(9, 2);
            this.rtbOperacion.Name = "rtbOperacion";
            this.rtbOperacion.Size = new System.Drawing.Size(245, 30);
            this.rtbOperacion.TabIndex = 28;
            this.rtbOperacion.Text = "";
            // 
            // BasicCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(263, 389);
            this.Controls.Add(this.rtbOperacion);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnMasMenos);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnInverso);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtView);
            this.MaximizeBox = false;
            this.Name = "BasicCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasicCalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnInverso;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMasMenos;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.RichTextBox rtbOperacion;
    }
}