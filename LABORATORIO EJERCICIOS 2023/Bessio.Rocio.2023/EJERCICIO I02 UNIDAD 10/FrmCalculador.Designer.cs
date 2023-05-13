namespace EJERCICIO_I02_UNIDAD_10
{
    partial class FrmCalculador
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
            label1 = new Label();
            label2 = new Label();
            txtKilometros = new TextBox();
            txtLitros = new TextBox();
            richTextBox1 = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 0;
            label1.Text = "Kilometros:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 157);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 1;
            label2.Text = "Litros:";
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(30, 54);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(150, 31);
            txtKilometros.TabIndex = 2;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(30, 192);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(150, 31);
            txtLitros.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(328, 54);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(292, 290);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(30, 268);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(169, 44);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FrmCalculador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(632, 356);
            Controls.Add(btnCalcular);
            Controls.Add(richTextBox1);
            Controls.Add(txtLitros);
            Controls.Add(txtKilometros);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCalculador";
            Text = "Form1";
            Load += FrmCalculador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKilometros;
        private TextBox txtLitros;
        private RichTextBox richTextBox1;
        private Button btnCalcular;
    }
}