namespace EJERCICIO_C01_UNIDAD_09
{
    partial class FrmMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrar));
            richTextBoxLlamadas = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxLlamadas
            // 
            richTextBoxLlamadas.BackColor = SystemColors.ButtonFace;
            richTextBoxLlamadas.Location = new Point(25, 29);
            richTextBoxLlamadas.Name = "richTextBoxLlamadas";
            richTextBoxLlamadas.Size = new Size(586, 593);
            richTextBoxLlamadas.TabIndex = 0;
            richTextBoxLlamadas.Text = "";
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(640, 634);
            Controls.Add(richTextBoxLlamadas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMostrar";
            Text = "FrmMostrar";
            Load += FrmMostrar_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxLlamadas;
    }
}