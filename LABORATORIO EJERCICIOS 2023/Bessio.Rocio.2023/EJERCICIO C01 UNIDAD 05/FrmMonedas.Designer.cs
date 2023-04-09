namespace EJERCICIO_C01_UNIDAD_05
{
    partial class FrmMonedas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonedas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbCotizacionEuro = new TextBox();
            tbCotizacionDolar = new TextBox();
            tbCotizacionPeso = new TextBox();
            btnCotizarEuro = new Button();
            btnCotizarDolar = new Button();
            btnCotizarPesos = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbCotizarEuroaEuro = new TextBox();
            tbCotEuroADolar = new TextBox();
            tbCotEuroAPesos = new TextBox();
            tbCotDolarAEuro = new TextBox();
            tbCotDolarADolar = new TextBox();
            tbCotDolarAPeso = new TextBox();
            tbCotPesoAEuro = new TextBox();
            tbCotPesoADolar = new TextBox();
            tbCotPesoAPeso = new TextBox();
            tbEuro = new TextBox();
            tbDolar = new TextBox();
            tbPeso = new TextBox();
            btnImageLock = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 36);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 0;
            label1.Text = "Cotización";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 173);
            label2.Name = "label2";
            label2.Size = new Size(72, 26);
            label2.TabIndex = 1;
            label2.Text = "Dólar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 111);
            label3.Name = "label3";
            label3.Size = new Size(60, 26);
            label3.TabIndex = 2;
            label3.Text = "Euro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 237);
            label4.Name = "label4";
            label4.Size = new Size(60, 26);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            // 
            // tbCotizacionEuro
            // 
            tbCotizacionEuro.Location = new Point(143, 108);
            tbCotizacionEuro.Name = "tbCotizacionEuro";
            tbCotizacionEuro.Size = new Size(150, 31);
            tbCotizacionEuro.TabIndex = 4;
            tbCotizacionEuro.TextChanged += tbCotizacionEuro_TextChanged;
            // 
            // tbCotizacionDolar
            // 
            tbCotizacionDolar.Location = new Point(143, 170);
            tbCotizacionDolar.Name = "tbCotizacionDolar";
            tbCotizacionDolar.Size = new Size(150, 31);
            tbCotizacionDolar.TabIndex = 5;
            tbCotizacionDolar.TextChanged += tbCotizacionDolar_TextChanged;
            // 
            // tbCotizacionPeso
            // 
            tbCotizacionPeso.Location = new Point(143, 234);
            tbCotizacionPeso.Name = "tbCotizacionPeso";
            tbCotizacionPeso.Size = new Size(150, 31);
            tbCotizacionPeso.TabIndex = 6;
            tbCotizacionPeso.TextChanged += tbCotizacionPeso_TextChanged;
            // 
            // btnCotizarEuro
            // 
            btnCotizarEuro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCotizarEuro.Location = new Point(325, 102);
            btnCotizarEuro.Name = "btnCotizarEuro";
            btnCotizarEuro.Size = new Size(112, 40);
            btnCotizarEuro.TabIndex = 7;
            btnCotizarEuro.Text = "->";
            btnCotizarEuro.UseVisualStyleBackColor = true;
            btnCotizarEuro.Click += btnCotizarEuro_Click;
            // 
            // btnCotizarDolar
            // 
            btnCotizarDolar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCotizarDolar.Location = new Point(325, 164);
            btnCotizarDolar.Name = "btnCotizarDolar";
            btnCotizarDolar.Size = new Size(112, 40);
            btnCotizarDolar.TabIndex = 8;
            btnCotizarDolar.Text = "->";
            btnCotizarDolar.UseVisualStyleBackColor = true;
            btnCotizarDolar.Click += btnCotizarDolar_Click;
            // 
            // btnCotizarPesos
            // 
            btnCotizarPesos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCotizarPesos.Location = new Point(325, 228);
            btnCotizarPesos.Name = "btnCotizarPesos";
            btnCotizarPesos.Size = new Size(112, 40);
            btnCotizarPesos.TabIndex = 9;
            btnCotizarPesos.Text = "->";
            btnCotizarPesos.UseVisualStyleBackColor = true;
            btnCotizarPesos.Click += btnCotizarPesos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(503, 70);
            label5.Name = "label5";
            label5.Size = new Size(60, 26);
            label5.TabIndex = 10;
            label5.Text = "Euro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(670, 70);
            label6.Name = "label6";
            label6.Size = new Size(72, 26);
            label6.TabIndex = 11;
            label6.Text = "Dólar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(838, 70);
            label7.Name = "label7";
            label7.Size = new Size(60, 26);
            label7.TabIndex = 12;
            label7.Text = "Peso";
            // 
            // tbCotizarEuroaEuro
            // 
            tbCotizarEuroaEuro.Location = new Point(466, 108);
            tbCotizarEuroaEuro.Name = "tbCotizarEuroaEuro";
            tbCotizarEuroaEuro.Size = new Size(150, 31);
            tbCotizarEuroaEuro.TabIndex = 13;
            // 
            // tbCotEuroADolar
            // 
            tbCotEuroADolar.Location = new Point(633, 108);
            tbCotEuroADolar.Name = "tbCotEuroADolar";
            tbCotEuroADolar.Size = new Size(150, 31);
            tbCotEuroADolar.TabIndex = 14;
            // 
            // tbCotEuroAPesos
            // 
            tbCotEuroAPesos.Location = new Point(798, 108);
            tbCotEuroAPesos.Name = "tbCotEuroAPesos";
            tbCotEuroAPesos.Size = new Size(150, 31);
            tbCotEuroAPesos.TabIndex = 15;
            // 
            // tbCotDolarAEuro
            // 
            tbCotDolarAEuro.Location = new Point(466, 170);
            tbCotDolarAEuro.Name = "tbCotDolarAEuro";
            tbCotDolarAEuro.Size = new Size(150, 31);
            tbCotDolarAEuro.TabIndex = 16;
            // 
            // tbCotDolarADolar
            // 
            tbCotDolarADolar.Location = new Point(633, 170);
            tbCotDolarADolar.Name = "tbCotDolarADolar";
            tbCotDolarADolar.Size = new Size(150, 31);
            tbCotDolarADolar.TabIndex = 17;
            // 
            // tbCotDolarAPeso
            // 
            tbCotDolarAPeso.Location = new Point(798, 173);
            tbCotDolarAPeso.Name = "tbCotDolarAPeso";
            tbCotDolarAPeso.Size = new Size(150, 31);
            tbCotDolarAPeso.TabIndex = 18;
            // 
            // tbCotPesoAEuro
            // 
            tbCotPesoAEuro.Location = new Point(466, 232);
            tbCotPesoAEuro.Name = "tbCotPesoAEuro";
            tbCotPesoAEuro.Size = new Size(150, 31);
            tbCotPesoAEuro.TabIndex = 19;
            // 
            // tbCotPesoADolar
            // 
            tbCotPesoADolar.Location = new Point(633, 232);
            tbCotPesoADolar.Name = "tbCotPesoADolar";
            tbCotPesoADolar.Size = new Size(150, 31);
            tbCotPesoADolar.TabIndex = 20;
            // 
            // tbCotPesoAPeso
            // 
            tbCotPesoAPeso.Location = new Point(798, 232);
            tbCotPesoAPeso.Name = "tbCotPesoAPeso";
            tbCotPesoAPeso.Size = new Size(150, 31);
            tbCotPesoAPeso.TabIndex = 21;
            // 
            // tbEuro
            // 
            tbEuro.Location = new Point(466, 23);
            tbEuro.Name = "tbEuro";
            tbEuro.Size = new Size(150, 31);
            tbEuro.TabIndex = 22;
            // 
            // tbDolar
            // 
            tbDolar.Location = new Point(633, 23);
            tbDolar.Name = "tbDolar";
            tbDolar.Size = new Size(150, 31);
            tbDolar.TabIndex = 23;
            // 
            // tbPeso
            // 
            tbPeso.Location = new Point(798, 23);
            tbPeso.Name = "tbPeso";
            tbPeso.Size = new Size(150, 31);
            tbPeso.TabIndex = 24;
            // 
            // btnImageLock
            // 
            btnImageLock.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnImageLock.Location = new Point(325, 23);
            btnImageLock.Name = "btnImageLock";
            btnImageLock.Size = new Size(112, 41);
            btnImageLock.TabIndex = 25;
            btnImageLock.Text = "UNLOCKED";
            btnImageLock.UseVisualStyleBackColor = true;
            btnImageLock.Click += btnImageLock_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // FrmMonedas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 303);
            Controls.Add(pictureBox1);
            Controls.Add(btnImageLock);
            Controls.Add(tbPeso);
            Controls.Add(tbDolar);
            Controls.Add(tbEuro);
            Controls.Add(tbCotPesoAPeso);
            Controls.Add(tbCotPesoADolar);
            Controls.Add(tbCotPesoAEuro);
            Controls.Add(tbCotDolarAPeso);
            Controls.Add(tbCotDolarADolar);
            Controls.Add(tbCotDolarAEuro);
            Controls.Add(tbCotEuroAPesos);
            Controls.Add(tbCotEuroADolar);
            Controls.Add(tbCotizarEuroaEuro);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCotizarPesos);
            Controls.Add(btnCotizarDolar);
            Controls.Add(btnCotizarEuro);
            Controls.Add(tbCotizacionPeso);
            Controls.Add(tbCotizacionDolar);
            Controls.Add(tbCotizacionEuro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMonedas";
            Text = "Form1";
            Load += FrmMonedas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbCotizacionEuro;
        private TextBox tbCotizacionDolar;
        private TextBox tbCotizacionPeso;
        private Button btnCotizarEuro;
        private Button btnCotizarDolar;
        private Button btnCotizarPesos;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbCotizarEuroaEuro;
        private TextBox tbCotEuroADolar;
        private TextBox tbCotEuroAPesos;
        private TextBox tbCotDolarAEuro;
        private TextBox tbCotDolarADolar;
        private TextBox tbCotDolarAPeso;
        private TextBox tbCotPesoAEuro;
        private TextBox tbCotPesoADolar;
        private TextBox tbCotPesoAPeso;
        private TextBox tbEuro;
        private TextBox tbDolar;
        private TextBox tbPeso;
        private Button btnImageLock;
        private PictureBox pictureBox1;
    }
}