namespace EJERCICIO_C03_UNIDAD_05
{
    partial class FrmConversorNumerico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConversorNumerico));
            label1 = new Label();
            label2 = new Label();
            btnBinADecimal = new Button();
            btnDecABin = new Button();
            tbBin = new TextBox();
            tbDec = new TextBox();
            tbConvertBinADec = new TextBox();
            tbConvertDecABin = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(180, 22);
            label1.TabIndex = 0;
            label1.Text = "Binario a Decimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(180, 22);
            label2.TabIndex = 1;
            label2.Text = "Decimal a Binario";
            // 
            // btnBinADecimal
            // 
            btnBinADecimal.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBinADecimal.Location = new Point(402, 65);
            btnBinADecimal.Name = "btnBinADecimal";
            btnBinADecimal.Size = new Size(112, 34);
            btnBinADecimal.TabIndex = 2;
            btnBinADecimal.Text = "->";
            btnBinADecimal.UseVisualStyleBackColor = true;
            btnBinADecimal.Click += btnBinADecimal_Click;
            // 
            // btnDecABin
            // 
            btnDecABin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecABin.Location = new Point(402, 133);
            btnDecABin.Name = "btnDecABin";
            btnDecABin.Size = new Size(112, 34);
            btnDecABin.TabIndex = 3;
            btnDecABin.Text = "->";
            btnDecABin.UseVisualStyleBackColor = true;
            btnDecABin.Click += btnDecABin_Click;
            // 
            // tbBin
            // 
            tbBin.Location = new Point(211, 67);
            tbBin.Name = "tbBin";
            tbBin.Size = new Size(150, 31);
            tbBin.TabIndex = 4;
            tbBin.TextChanged += tbBin_TextChanged;
            // 
            // tbDec
            // 
            tbDec.Location = new Point(211, 136);
            tbDec.Name = "tbDec";
            tbDec.Size = new Size(150, 31);
            tbDec.TabIndex = 5;
            tbDec.TextChanged += tbDec_TextChanged;
            // 
            // tbConvertBinADec
            // 
            tbConvertBinADec.Location = new Point(563, 67);
            tbConvertBinADec.Name = "tbConvertBinADec";
            tbConvertBinADec.Size = new Size(150, 31);
            tbConvertBinADec.TabIndex = 6;
            // 
            // tbConvertDecABin
            // 
            tbConvertDecABin.Location = new Point(563, 132);
            tbConvertDecABin.Name = "tbConvertDecABin";
            tbConvertDecABin.Size = new Size(150, 31);
            tbConvertDecABin.TabIndex = 7;
            // 
            // FrmConversorNumerico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 224);
            Controls.Add(tbConvertDecABin);
            Controls.Add(tbConvertBinADec);
            Controls.Add(tbDec);
            Controls.Add(tbBin);
            Controls.Add(btnDecABin);
            Controls.Add(btnBinADecimal);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmConversorNumerico";
            Text = "Form1";
            Load += FrmConversorNumerico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBinADecimal;
        private Button btnDecABin;
        private TextBox tbBin;
        private TextBox tbDec;
        private TextBox tbConvertBinADec;
        private TextBox tbConvertDecABin;
    }
}