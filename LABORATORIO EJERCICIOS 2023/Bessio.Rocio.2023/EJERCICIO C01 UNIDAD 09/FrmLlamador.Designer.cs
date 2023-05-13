namespace EJERCICIO_C01_UNIDAD_09
{
    partial class FrmLlamador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLlamador));
            btnNumUno = new Button();
            groupBox1 = new GroupBox();
            btnNumeral = new Button();
            btnNumCero = new Button();
            btnPunto = new Button();
            btnNumNueve = new Button();
            btnNumOcho = new Button();
            btnNumSiete = new Button();
            btnNumSeis = new Button();
            btnNumCinco = new Button();
            btnNumCuatro = new Button();
            btnNumTres = new Button();
            btnNumDos = new Button();
            txtNroDestino = new TextBox();
            txtNroOrigen = new TextBox();
            btnSalir = new Button();
            btnLlamar = new Button();
            btnLimpiar = new Button();
            cbFranja = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNumUno
            // 
            btnNumUno.FlatAppearance.BorderSize = 0;
            btnNumUno.FlatStyle = FlatStyle.Popup;
            btnNumUno.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumUno.Location = new Point(6, 30);
            btnNumUno.Name = "btnNumUno";
            btnNumUno.Size = new Size(67, 63);
            btnNumUno.TabIndex = 1;
            btnNumUno.Text = "1";
            btnNumUno.UseVisualStyleBackColor = true;
            btnNumUno.Click += btnNumUno_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNumeral);
            groupBox1.Controls.Add(btnNumCero);
            groupBox1.Controls.Add(btnPunto);
            groupBox1.Controls.Add(btnNumNueve);
            groupBox1.Controls.Add(btnNumOcho);
            groupBox1.Controls.Add(btnNumSiete);
            groupBox1.Controls.Add(btnNumSeis);
            groupBox1.Controls.Add(btnNumCinco);
            groupBox1.Controls.Add(btnNumCuatro);
            groupBox1.Controls.Add(btnNumTres);
            groupBox1.Controls.Add(btnNumDos);
            groupBox1.Controls.Add(btnNumUno);
            groupBox1.Location = new Point(12, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 380);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Panel";
            // 
            // btnNumeral
            // 
            btnNumeral.FlatAppearance.BorderSize = 0;
            btnNumeral.FlatStyle = FlatStyle.Popup;
            btnNumeral.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumeral.Location = new Point(201, 289);
            btnNumeral.Name = "btnNumeral";
            btnNumeral.Size = new Size(67, 63);
            btnNumeral.TabIndex = 12;
            btnNumeral.Text = "#";
            btnNumeral.UseVisualStyleBackColor = true;
            btnNumeral.Click += btnNumeral_Click;
            // 
            // btnNumCero
            // 
            btnNumCero.FlatAppearance.BorderSize = 0;
            btnNumCero.FlatStyle = FlatStyle.Popup;
            btnNumCero.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumCero.Location = new Point(107, 289);
            btnNumCero.Name = "btnNumCero";
            btnNumCero.Size = new Size(67, 63);
            btnNumCero.TabIndex = 11;
            btnNumCero.Text = "0";
            btnNumCero.UseVisualStyleBackColor = true;
            btnNumCero.Click += btnNumCero_Click;
            // 
            // btnPunto
            // 
            btnPunto.FlatAppearance.BorderSize = 0;
            btnPunto.FlatStyle = FlatStyle.Popup;
            btnPunto.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPunto.Location = new Point(6, 289);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(67, 63);
            btnPunto.TabIndex = 10;
            btnPunto.Text = "*";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnNumNueve
            // 
            btnNumNueve.FlatAppearance.BorderSize = 0;
            btnNumNueve.FlatStyle = FlatStyle.Popup;
            btnNumNueve.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumNueve.Location = new Point(201, 202);
            btnNumNueve.Name = "btnNumNueve";
            btnNumNueve.Size = new Size(67, 63);
            btnNumNueve.TabIndex = 9;
            btnNumNueve.Text = "9";
            btnNumNueve.UseVisualStyleBackColor = true;
            btnNumNueve.Click += btnNumNueve_Click;
            // 
            // btnNumOcho
            // 
            btnNumOcho.FlatAppearance.BorderSize = 0;
            btnNumOcho.FlatStyle = FlatStyle.Popup;
            btnNumOcho.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumOcho.Location = new Point(107, 202);
            btnNumOcho.Name = "btnNumOcho";
            btnNumOcho.Size = new Size(67, 63);
            btnNumOcho.TabIndex = 8;
            btnNumOcho.Text = "8";
            btnNumOcho.UseVisualStyleBackColor = true;
            btnNumOcho.Click += btnNumOcho_Click;
            // 
            // btnNumSiete
            // 
            btnNumSiete.FlatAppearance.BorderSize = 0;
            btnNumSiete.FlatStyle = FlatStyle.Popup;
            btnNumSiete.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumSiete.Location = new Point(6, 202);
            btnNumSiete.Name = "btnNumSiete";
            btnNumSiete.Size = new Size(67, 63);
            btnNumSiete.TabIndex = 7;
            btnNumSiete.Text = "7";
            btnNumSiete.UseVisualStyleBackColor = true;
            btnNumSiete.Click += btnNumSiete_Click;
            // 
            // btnNumSeis
            // 
            btnNumSeis.FlatAppearance.BorderSize = 0;
            btnNumSeis.FlatStyle = FlatStyle.Popup;
            btnNumSeis.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumSeis.Location = new Point(201, 118);
            btnNumSeis.Name = "btnNumSeis";
            btnNumSeis.Size = new Size(67, 63);
            btnNumSeis.TabIndex = 6;
            btnNumSeis.Text = "6";
            btnNumSeis.UseVisualStyleBackColor = true;
            btnNumSeis.Click += btnNumSeis_Click;
            // 
            // btnNumCinco
            // 
            btnNumCinco.FlatAppearance.BorderSize = 0;
            btnNumCinco.FlatStyle = FlatStyle.Popup;
            btnNumCinco.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumCinco.Location = new Point(107, 118);
            btnNumCinco.Name = "btnNumCinco";
            btnNumCinco.Size = new Size(67, 63);
            btnNumCinco.TabIndex = 5;
            btnNumCinco.Text = "5";
            btnNumCinco.UseVisualStyleBackColor = true;
            btnNumCinco.Click += btnNumCinco_Click;
            // 
            // btnNumCuatro
            // 
            btnNumCuatro.FlatAppearance.BorderSize = 0;
            btnNumCuatro.FlatStyle = FlatStyle.Popup;
            btnNumCuatro.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumCuatro.Location = new Point(6, 118);
            btnNumCuatro.Name = "btnNumCuatro";
            btnNumCuatro.Size = new Size(67, 63);
            btnNumCuatro.TabIndex = 4;
            btnNumCuatro.Text = "4";
            btnNumCuatro.UseVisualStyleBackColor = true;
            btnNumCuatro.Click += btnNumCuatro_Click;
            // 
            // btnNumTres
            // 
            btnNumTres.FlatAppearance.BorderSize = 0;
            btnNumTres.FlatStyle = FlatStyle.Popup;
            btnNumTres.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumTres.Location = new Point(201, 30);
            btnNumTres.Name = "btnNumTres";
            btnNumTres.Size = new Size(67, 63);
            btnNumTres.TabIndex = 3;
            btnNumTres.Text = "3";
            btnNumTres.UseVisualStyleBackColor = true;
            btnNumTres.Click += btnNumTres_Click;
            // 
            // btnNumDos
            // 
            btnNumDos.FlatAppearance.BorderSize = 0;
            btnNumDos.FlatStyle = FlatStyle.Popup;
            btnNumDos.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumDos.Location = new Point(107, 30);
            btnNumDos.Name = "btnNumDos";
            btnNumDos.Size = new Size(67, 63);
            btnNumDos.TabIndex = 2;
            btnNumDos.Text = "2";
            btnNumDos.UseVisualStyleBackColor = true;
            btnNumDos.Click += btnNumDos_Click;
            // 
            // txtNroDestino
            // 
            txtNroDestino.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNroDestino.Location = new Point(18, 35);
            txtNroDestino.Name = "txtNroDestino";
            txtNroDestino.Size = new Size(656, 45);
            txtNroDestino.TabIndex = 3;
            txtNroDestino.TextChanged += txtNroDestino_TextChanged;
            // 
            // txtNroOrigen
            // 
            txtNroOrigen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNroOrigen.Location = new Point(333, 363);
            txtNroOrigen.Name = "txtNroOrigen";
            txtNroOrigen.Size = new Size(341, 45);
            txtNroOrigen.TabIndex = 4;
            txtNroOrigen.TextChanged += txtNroOrigen_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(333, 437);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(341, 60);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLlamar
            // 
            btnLlamar.FlatAppearance.BorderSize = 0;
            btnLlamar.FlatStyle = FlatStyle.Popup;
            btnLlamar.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLlamar.Location = new Point(333, 150);
            btnLlamar.Name = "btnLlamar";
            btnLlamar.Size = new Size(341, 60);
            btnLlamar.TabIndex = 6;
            btnLlamar.Text = "Llamar";
            btnLlamar.UseVisualStyleBackColor = true;
            btnLlamar.Click += btnLlamar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(333, 252);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(341, 60);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cbFranja
            // 
            cbFranja.FormattingEnabled = true;
            cbFranja.Location = new Point(18, 547);
            cbFranja.Name = "cbFranja";
            cbFranja.Size = new Size(656, 33);
            cbFranja.TabIndex = 8;
            // 
            // FrmLlamador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(703, 626);
            Controls.Add(cbFranja);
            Controls.Add(btnLimpiar);
            Controls.Add(btnLlamar);
            Controls.Add(btnSalir);
            Controls.Add(txtNroOrigen);
            Controls.Add(txtNroDestino);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLlamador";
            Text = "FrmLlamador";
            Load += FrmLlamador_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNumUno;
        private GroupBox groupBox1;
        private Button btnNumeral;
        private Button btnNumCero;
        private Button btnPunto;
        private Button btnNumNueve;
        private Button btnNumOcho;
        private Button btnNumSiete;
        private Button btnNumSeis;
        private Button btnNumCinco;
        private Button btnNumCuatro;
        private Button btnNumTres;
        private Button btnNumDos;
        private TextBox txtNroDestino;
        private TextBox txtNroOrigen;
        private Button btnSalir;
        private Button btnLlamar;
        private Button btnLimpiar;
        private ComboBox cbFranja;
    }
}