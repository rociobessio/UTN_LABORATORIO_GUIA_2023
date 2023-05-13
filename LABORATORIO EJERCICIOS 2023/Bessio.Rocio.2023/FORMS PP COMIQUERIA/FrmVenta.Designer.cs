namespace FORMS_PP_COMIQUERIA
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            lblDescripcion = new Label();
            label1 = new Label();
            numericUpDownCantidad = new NumericUpDown();
            lblPrecioFinal = new Label();
            btnVender = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(31, 83);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(160, 30);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "lblDescripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 171);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 1;
            label1.Text = "Cantidad:";
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(31, 209);
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(180, 31);
            numericUpDownCantidad.TabIndex = 2;
            numericUpDownCantidad.ValueChanged += numericUpDownCantidad_ValueChanged;
            // 
            // lblPrecioFinal
            // 
            lblPrecioFinal.AutoSize = true;
            lblPrecioFinal.Location = new Point(260, 215);
            lblPrecioFinal.Name = "lblPrecioFinal";
            lblPrecioFinal.Size = new Size(115, 25);
            lblPrecioFinal.TabIndex = 3;
            lblPrecioFinal.Text = "lblPrecioFinal";
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.DarkRed;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(31, 277);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(180, 49);
            btnVender.TabIndex = 4;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(260, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(159, 49);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(462, 352);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnVender);
            Controls.Add(lblPrecioFinal);
            Controls.Add(numericUpDownCantidad);
            Controls.Add(label1);
            Controls.Add(lblDescripcion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVenta";
            Text = "FrmVenta";
            Load += FrmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private Label label1;
        private NumericUpDown numericUpDownCantidad;
        private Label lblPrecioFinal;
        private Button btnVender;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}