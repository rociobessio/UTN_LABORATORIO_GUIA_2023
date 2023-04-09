namespace EJERCICIO_I01_UNIDAD_05
{
    partial class Frm
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
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSaludar = new Button();
            cbMateriaFav = new ComboBox();
            SuspendLayout();
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(345, 59);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(150, 31);
            tbApellido.TabIndex = 0;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(49, 59);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(150, 31);
            tbNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 14);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 2;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(357, 14);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 3;
            label2.Text = "APELLIDO";
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaludar.Location = new Point(430, 177);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(128, 43);
            btnSaludar.TabIndex = 4;
            btnSaludar.Text = "SALUDAR";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // cbMateriaFav
            // 
            cbMateriaFav.FormattingEnabled = true;
            cbMateriaFav.Location = new Point(49, 125);
            cbMateriaFav.Name = "cbMateriaFav";
            cbMateriaFav.Size = new Size(446, 33);
            cbMateriaFav.TabIndex = 5;
            // 
            // Frm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 232);
            Controls.Add(cbMateriaFav);
            Controls.Add(btnSaludar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNombre);
            Controls.Add(tbApellido);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm";
            Text = "Form1";
            Load += Frm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbApellido;
        private TextBox tbNombre;
        private Label label1;
        private Label label2;
        private Button btnSaludar;
        private ComboBox cbMateriaFav;
    }
}