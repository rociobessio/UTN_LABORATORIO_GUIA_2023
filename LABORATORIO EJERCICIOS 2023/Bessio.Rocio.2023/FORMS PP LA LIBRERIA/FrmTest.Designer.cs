namespace FORMS_PP_LA_LIBRERIA
{
    partial class FrmTest
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
            rtbInforme = new RichTextBox();
            lstStock = new ListBox();
            btnVender = new Button();
            btnVerInforme = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // rtbInforme
            // 
            rtbInforme.Location = new Point(466, 12);
            rtbInforme.Name = "rtbInforme";
            rtbInforme.Size = new Size(322, 533);
            rtbInforme.TabIndex = 0;
            rtbInforme.Text = "";
            // 
            // lstStock
            // 
            lstStock.FormattingEnabled = true;
            lstStock.ItemHeight = 25;
            lstStock.Location = new Point(12, 12);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(406, 354);
            lstStock.TabIndex = 1;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(12, 388);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(406, 40);
            btnVender.TabIndex = 2;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnVerInforme
            // 
            btnVerInforme.Location = new Point(12, 446);
            btnVerInforme.Name = "btnVerInforme";
            btnVerInforme.Size = new Size(406, 40);
            btnVerInforme.TabIndex = 3;
            btnVerInforme.Text = "Ver Informe";
            btnVerInforme.UseVisualStyleBackColor = true;
            btnVerInforme.Click += btnVerInforme_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 505);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(406, 40);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(btnSalir);
            Controls.Add(btnVerInforme);
            Controls.Add(btnVender);
            Controls.Add(lstStock);
            Controls.Add(rtbInforme);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tester App de Rocio Bessio (2A)";
            FormClosing += FrmTest_FormClosing;
            Load += FrmTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbInforme;
        private ListBox lstStock;
        private Button btnVender;
        private Button btnVerInforme;
        private Button btnSalir;
    }
}