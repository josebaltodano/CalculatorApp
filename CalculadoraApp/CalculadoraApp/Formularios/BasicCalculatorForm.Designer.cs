
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicCalculatorForm));
            this.txtView = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
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
            this.btnSen = new System.Windows.Forms.Button();
            this.btnSenh = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_e = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnRad = new System.Windows.Forms.Button();
            this.btnGrad = new System.Windows.Forms.Button();
            this.lblRadians = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.btnIntegral = new System.Windows.Forms.Button();
            this.txtSuperior = new System.Windows.Forms.TextBox();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParentesis = new System.Windows.Forms.Button();
            this.btnVariable = new System.Windows.Forms.Button();
            this.btnAbrirP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtView
            // 
            this.txtView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtView.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView.Location = new System.Drawing.Point(12, 81);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ReadOnly = true;
            this.txtView.Size = new System.Drawing.Size(427, 37);
            this.txtView.TabIndex = 0;
            this.txtView.Text = "0";
            this.txtView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtView.TextChanged += new System.EventHandler(this.txtView_TextChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(198, 130);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(56, 45);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPI
            // 
            this.btnPI.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPI.Location = new System.Drawing.Point(198, 383);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(56, 45);
            this.btnPI.TabIndex = 5;
            this.btnPI.Tag = "π";
            this.btnPI.Text = "π";
            this.btnPI.UseVisualStyleBackColor = false;
            this.btnPI.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(322, 181);
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
            this.btnQuitar.Location = new System.Drawing.Point(321, 130);
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
            this.btnPorcentaje.Location = new System.Drawing.Point(12, 128);
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
            this.btnBorrarTodo.Location = new System.Drawing.Point(260, 130);
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
            this.btnRaizCuadrada.Location = new System.Drawing.Point(136, 177);
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
            this.btnPotencia.Location = new System.Drawing.Point(74, 179);
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
            this.btn4.Location = new System.Drawing.Point(9, 281);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 45);
            this.btn4.TabIndex = 12;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 230);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 45);
            this.btn7.TabIndex = 13;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 334);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 45);
            this.btn1.TabIndex = 14;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btnMasMenos
            // 
            this.btnMasMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasMenos.Location = new System.Drawing.Point(12, 383);
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
            this.btn9.Location = new System.Drawing.Point(136, 230);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 45);
            this.btn9.TabIndex = 16;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(74, 281);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 45);
            this.btn5.TabIndex = 17;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(74, 230);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 45);
            this.btn8.TabIndex = 18;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(321, 232);
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
            this.btn3.Location = new System.Drawing.Point(136, 334);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 45);
            this.btn3.TabIndex = 20;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(74, 334);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 45);
            this.btn2.TabIndex = 21;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(136, 281);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 45);
            this.btn6.TabIndex = 22;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(322, 281);
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
            this.btnSumar.Location = new System.Drawing.Point(322, 334);
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
            this.btnIgual.Location = new System.Drawing.Point(322, 383);
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
            this.btnPunto.Location = new System.Drawing.Point(136, 383);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(56, 45);
            this.btnPunto.TabIndex = 26;
            this.btnPunto.Tag = ".";
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(74, 383);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 45);
            this.btn0.TabIndex = 27;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.ViewNumber);
            // 
            // rtbOperacion
            // 
            this.rtbOperacion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbOperacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOperacion.DetectUrls = false;
            this.rtbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOperacion.Location = new System.Drawing.Point(9, 21);
            this.rtbOperacion.Name = "rtbOperacion";
            this.rtbOperacion.ReadOnly = true;
            this.rtbOperacion.Size = new System.Drawing.Size(430, 30);
            this.rtbOperacion.TabIndex = 28;
            this.rtbOperacion.Text = "";
            this.rtbOperacion.TextChanged += new System.EventHandler(this.rtbOperacion_TextChanged);
            // 
            // btnSen
            // 
            this.btnSen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSen.Location = new System.Drawing.Point(198, 230);
            this.btnSen.Name = "btnSen";
            this.btnSen.Size = new System.Drawing.Size(56, 45);
            this.btnSen.TabIndex = 29;
            this.btnSen.Tag = "sen";
            this.btnSen.Text = "Sen(";
            this.btnSen.UseVisualStyleBackColor = false;
            this.btnSen.Click += new System.EventHandler(this.ClickTrigonometria);
            // 
            // btnSenh
            // 
            this.btnSenh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenh.Location = new System.Drawing.Point(260, 230);
            this.btnSenh.Name = "btnSenh";
            this.btnSenh.Size = new System.Drawing.Size(56, 45);
            this.btnSenh.TabIndex = 30;
            this.btnSenh.Tag = "sh";
            this.btnSenh.Text = "Senh";
            this.btnSenh.UseVisualStyleBackColor = false;
            this.btnSenh.Click += new System.EventHandler(this.ClickTrigonometria);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(198, 180);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(56, 45);
            this.btnCos.TabIndex = 31;
            this.btnCos.Tag = "cos";
            this.btnCos.Text = "Cos(";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.ClickTrigonometria);
            // 
            // btnCosh
            // 
            this.btnCosh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCosh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosh.Location = new System.Drawing.Point(260, 181);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(56, 45);
            this.btnCosh.TabIndex = 32;
            this.btnCosh.Tag = "ch";
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = false;
            this.btnCosh.Click += new System.EventHandler(this.ClickTrigonometria);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.Location = new System.Drawing.Point(260, 334);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(56, 45);
            this.btnLn.TabIndex = 33;
            this.btnLn.Tag = "n";
            this.btnLn.Text = "Ln";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.ClickTrigonometria);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(198, 334);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(56, 45);
            this.btnLog.TabIndex = 34;
            this.btnLog.Tag = "l";
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.ClickTrigonometria);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 179);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 45);
            this.button7.TabIndex = 35;
            this.button7.Tag = "*";
            this.button7.Text = "x^-1";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn_e
            // 
            this.btn_e.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_e.Location = new System.Drawing.Point(260, 384);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(56, 45);
            this.btn_e.TabIndex = 36;
            this.btn_e.Tag = "e";
            this.btn_e.Text = "e";
            this.btn_e.UseVisualStyleBackColor = false;
            this.btn_e.Click += new System.EventHandler(this.ViewNumber);
            // 
            // btnTanh
            // 
            this.btnTanh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanh.Location = new System.Drawing.Point(260, 283);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(56, 45);
            this.btnTanh.TabIndex = 37;
            this.btnTanh.Tag = "th";
            this.btnTanh.Text = "Tanh";
            this.btnTanh.UseVisualStyleBackColor = false;
            this.btnTanh.Click += new System.EventHandler(this.ClickTrigonometria);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(198, 282);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(56, 45);
            this.btnTan.TabIndex = 38;
            this.btnTan.Tag = "tan";
            this.btnTan.Text = "Tan(";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.ClickTrigonometria);
            // 
            // btnRad
            // 
            this.btnRad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRad.Location = new System.Drawing.Point(136, 130);
            this.btnRad.Name = "btnRad";
            this.btnRad.Size = new System.Drawing.Size(56, 45);
            this.btnRad.TabIndex = 39;
            this.btnRad.Tag = "*";
            this.btnRad.Text = "Rad";
            this.btnRad.UseVisualStyleBackColor = false;
            this.btnRad.Click += new System.EventHandler(this.RadGrad);
            // 
            // btnGrad
            // 
            this.btnGrad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrad.Location = new System.Drawing.Point(74, 130);
            this.btnGrad.Name = "btnGrad";
            this.btnGrad.Size = new System.Drawing.Size(56, 45);
            this.btnGrad.TabIndex = 40;
            this.btnGrad.Tag = "*";
            this.btnGrad.Text = "Grad";
            this.btnGrad.UseVisualStyleBackColor = false;
            this.btnGrad.Click += new System.EventHandler(this.RadGrad);
            // 
            // lblRadians
            // 
            this.lblRadians.AutoSize = true;
            this.lblRadians.Location = new System.Drawing.Point(399, 5);
            this.lblRadians.Name = "lblRadians";
            this.lblRadians.Size = new System.Drawing.Size(27, 13);
            this.lblRadians.TabIndex = 41;
            this.lblRadians.Text = "Rad";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(399, 5);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(30, 13);
            this.lblGrado.TabIndex = 42;
            this.lblGrado.Text = "Grad";
            this.lblGrado.Visible = false;
            // 
            // btnIntegral
            // 
            this.btnIntegral.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIntegral.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIntegral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegral.Location = new System.Drawing.Point(383, 130);
            this.btnIntegral.Name = "btnIntegral";
            this.btnIntegral.Size = new System.Drawing.Size(56, 45);
            this.btnIntegral.TabIndex = 43;
            this.btnIntegral.Text = "∫";
            this.btnIntegral.UseVisualStyleBackColor = false;
            this.btnIntegral.Click += new System.EventHandler(this.btnIntegral_Click);
            // 
            // txtSuperior
            // 
            this.txtSuperior.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtSuperior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuperior.Location = new System.Drawing.Point(9, 2);
            this.txtSuperior.Name = "txtSuperior";
            this.txtSuperior.Size = new System.Drawing.Size(10, 13);
            this.txtSuperior.TabIndex = 44;
            this.txtSuperior.Visible = false;
            // 
            // txtInferior
            // 
            this.txtInferior.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtInferior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInferior.Location = new System.Drawing.Point(9, 48);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(10, 13);
            this.txtInferior.TabIndex = 45;
            this.txtInferior.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Limite Inferior";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Limite Superior";
            this.label1.Visible = false;
            // 
            // btnParentesis
            // 
            this.btnParentesis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnParentesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParentesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentesis.Location = new System.Drawing.Point(383, 181);
            this.btnParentesis.Name = "btnParentesis";
            this.btnParentesis.Size = new System.Drawing.Size(56, 45);
            this.btnParentesis.TabIndex = 60;
            this.btnParentesis.Tag = ")";
            this.btnParentesis.Text = ")";
            this.btnParentesis.UseVisualStyleBackColor = false;
            this.btnParentesis.Click += new System.EventHandler(this.btnParentesis_Click);
            // 
            // btnVariable
            // 
            this.btnVariable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVariable.Location = new System.Drawing.Point(384, 281);
            this.btnVariable.Name = "btnVariable";
            this.btnVariable.Size = new System.Drawing.Size(56, 45);
            this.btnVariable.TabIndex = 61;
            this.btnVariable.Tag = "x";
            this.btnVariable.Text = "X";
            this.btnVariable.UseVisualStyleBackColor = false;
            this.btnVariable.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // btnAbrirP
            // 
            this.btnAbrirP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAbrirP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirP.Location = new System.Drawing.Point(383, 229);
            this.btnAbrirP.Name = "btnAbrirP";
            this.btnAbrirP.Size = new System.Drawing.Size(56, 45);
            this.btnAbrirP.TabIndex = 62;
            this.btnAbrirP.Tag = "(";
            this.btnAbrirP.Text = "(";
            this.btnAbrirP.UseVisualStyleBackColor = false;
            this.btnAbrirP.Click += new System.EventHandler(this.btnAbrirP_Click);
            // 
            // BasicCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(451, 440);
            this.Controls.Add(this.btnAbrirP);
            this.Controls.Add(this.btnVariable);
            this.Controls.Add(this.btnParentesis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInferior);
            this.Controls.Add(this.txtSuperior);
            this.Controls.Add(this.btnIntegral);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblRadians);
            this.Controls.Add(this.btnGrad);
            this.Controls.Add(this.btnRad);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btn_e);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSenh);
            this.Controls.Add(this.btnSen);
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
            this.Controls.Add(this.btnPI);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BasicCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasicCalculatorForm";
            this.Load += new System.EventHandler(this.BasicCalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPI;
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
        private System.Windows.Forms.Button btnSen;
        private System.Windows.Forms.Button btnSenh;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnRad;
        private System.Windows.Forms.Button btnGrad;
        private System.Windows.Forms.Label lblRadians;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Button btnIntegral;
        private System.Windows.Forms.TextBox txtSuperior;
        private System.Windows.Forms.TextBox txtInferior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParentesis;
        private System.Windows.Forms.Button btnVariable;
        private System.Windows.Forms.Button btnAbrirP;
    }
}