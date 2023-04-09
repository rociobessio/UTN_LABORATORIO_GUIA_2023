namespace EJERCICIO_I01_UNIDAD_05
{
    partial class Frm2
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
            label1 = new Label();
            lblCadena = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(324, 32);
            label1.TabIndex = 0;
            label1.Text = "¡HOLA, WINDOWS FORMS!";
            // 
            // lblCadena
            // 
            lblCadena.AutoSize = true;
            lblCadena.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCadena.Location = new Point(3, 123);
            lblCadena.Name = "lblCadena";
            lblCadena.Size = new Size(71, 30);
            lblCadena.TabIndex = 1;
            lblCadena.Text = "label2";
            // 
            // Frm2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 209);
            Controls.Add(lblCadena);
            Controls.Add(label1);
            Name = "Frm2";
            Text = "Frm2";
            Load += Frm2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCadena;
    }
}