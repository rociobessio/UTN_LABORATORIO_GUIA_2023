namespace FORMS_PP_EL_DISPOSITIVO
{
    partial class FrmPrincipal
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
            rtbAppsInstaladas = new RichTextBox();
            rtbAppNoInstaladas = new RichTextBox();
            SuspendLayout();
            // 
            // rtbAppsInstaladas
            // 
            rtbAppsInstaladas.BackColor = Color.Black;
            rtbAppsInstaladas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rtbAppsInstaladas.ForeColor = Color.White;
            rtbAppsInstaladas.Location = new Point(36, 12);
            rtbAppsInstaladas.Name = "rtbAppsInstaladas";
            rtbAppsInstaladas.Size = new Size(259, 426);
            rtbAppsInstaladas.TabIndex = 0;
            rtbAppsInstaladas.Text = "";
            // 
            // rtbAppNoInstaladas
            // 
            rtbAppNoInstaladas.BackColor = Color.Black;
            rtbAppNoInstaladas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rtbAppNoInstaladas.ForeColor = Color.White;
            rtbAppNoInstaladas.Location = new Point(439, 12);
            rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            rtbAppNoInstaladas.Size = new Size(269, 426);
            rtbAppNoInstaladas.TabIndex = 1;
            rtbAppNoInstaladas.Text = "";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbAppNoInstaladas);
            Controls.Add(rtbAppsInstaladas);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EL DISPOSITIVO";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbAppsInstaladas;
        private RichTextBox rtbAppNoInstaladas;
    }
}