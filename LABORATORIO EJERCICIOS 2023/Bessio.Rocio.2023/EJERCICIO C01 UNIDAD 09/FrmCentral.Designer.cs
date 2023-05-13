namespace EJERCICIO_C01_UNIDAD_09
{
    partial class FrmCentral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCentral));
            btnGenerarLlamada = new Button();
            btnFacturacionTotal = new Button();
            btnFacturacionLocal = new Button();
            btnFacturacionProvincial = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            btnGenerarLlamada.FlatAppearance.BorderSize = 0;
            btnGenerarLlamada.FlatStyle = FlatStyle.Popup;
            btnGenerarLlamada.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerarLlamada.Location = new Point(40, 27);
            btnGenerarLlamada.Name = "btnGenerarLlamada";
            btnGenerarLlamada.Size = new Size(453, 88);
            btnGenerarLlamada.TabIndex = 0;
            btnGenerarLlamada.Text = "Generar Llamada";
            btnGenerarLlamada.UseVisualStyleBackColor = true;
            btnGenerarLlamada.Click += btnGenerarLlamada_Click;
            // 
            // btnFacturacionTotal
            // 
            btnFacturacionTotal.FlatAppearance.BorderSize = 0;
            btnFacturacionTotal.FlatStyle = FlatStyle.Popup;
            btnFacturacionTotal.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnFacturacionTotal.Location = new Point(40, 144);
            btnFacturacionTotal.Name = "btnFacturacionTotal";
            btnFacturacionTotal.Size = new Size(453, 88);
            btnFacturacionTotal.TabIndex = 1;
            btnFacturacionTotal.Text = "Facturación Total";
            btnFacturacionTotal.UseVisualStyleBackColor = true;
            btnFacturacionTotal.Click += btnFacturacionTotal_Click;
            // 
            // btnFacturacionLocal
            // 
            btnFacturacionLocal.FlatAppearance.BorderSize = 0;
            btnFacturacionLocal.FlatStyle = FlatStyle.Popup;
            btnFacturacionLocal.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnFacturacionLocal.Location = new Point(40, 267);
            btnFacturacionLocal.Name = "btnFacturacionLocal";
            btnFacturacionLocal.Size = new Size(453, 88);
            btnFacturacionLocal.TabIndex = 2;
            btnFacturacionLocal.Text = "Facturación Local";
            btnFacturacionLocal.UseVisualStyleBackColor = true;
            btnFacturacionLocal.Click += btnFacturacionLocal_Click;
            // 
            // btnFacturacionProvincial
            // 
            btnFacturacionProvincial.FlatAppearance.BorderSize = 0;
            btnFacturacionProvincial.FlatStyle = FlatStyle.Popup;
            btnFacturacionProvincial.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnFacturacionProvincial.Location = new Point(40, 389);
            btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            btnFacturacionProvincial.Size = new Size(453, 88);
            btnFacturacionProvincial.TabIndex = 3;
            btnFacturacionProvincial.Text = "Facturación Provincial";
            btnFacturacionProvincial.UseVisualStyleBackColor = true;
            btnFacturacionProvincial.Click += btnFacturacionProvincial_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(40, 507);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(453, 88);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmCentral
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(530, 607);
            Controls.Add(btnSalir);
            Controls.Add(btnFacturacionProvincial);
            Controls.Add(btnFacturacionLocal);
            Controls.Add(btnFacturacionTotal);
            Controls.Add(btnGenerarLlamada);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCentral";
            Text = "Form1";
            Load += FrmCentral_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerarLlamada;
        private Button btnFacturacionTotal;
        private Button btnFacturacionLocal;
        private Button btnFacturacionProvincial;
        private Button btnSalir;
    }
}