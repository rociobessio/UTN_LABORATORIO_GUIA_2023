namespace FORMS_PP_COMIQUERIA
{
    partial class FrmComiqueria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComiqueria));
            lstbProductos = new ListBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnPrintTicket = new Button();
            btnVender = new Button();
            lstbVentas = new ListBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstbProductos
            // 
            lstbProductos.FormattingEnabled = true;
            lstbProductos.ItemHeight = 25;
            lstbProductos.Location = new Point(12, 71);
            lstbProductos.Name = "lstbProductos";
            lstbProductos.Size = new Size(479, 229);
            lstbProductos.TabIndex = 0;
            lstbProductos.SelectedIndexChanged += lstbProductos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista de Productos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPrintTicket);
            groupBox1.Controls.Add(btnVender);
            groupBox1.Location = new Point(587, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 151);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // btnPrintTicket
            // 
            btnPrintTicket.BackColor = Color.DarkRed;
            btnPrintTicket.FlatStyle = FlatStyle.Flat;
            btnPrintTicket.ForeColor = Color.White;
            btnPrintTicket.Location = new Point(233, 49);
            btnPrintTicket.Name = "btnPrintTicket";
            btnPrintTicket.Size = new Size(153, 49);
            btnPrintTicket.TabIndex = 1;
            btnPrintTicket.Text = "Imprimir Ticket";
            btnPrintTicket.UseVisualStyleBackColor = false;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.DarkRed;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(24, 49);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(137, 49);
            btnVender.TabIndex = 0;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // lstbVentas
            // 
            lstbVentas.FormattingEnabled = true;
            lstbVentas.ItemHeight = 25;
            lstbVentas.Location = new Point(12, 417);
            lstbVentas.Name = "lstbVentas";
            lstbVentas.Size = new Size(1000, 229);
            lstbVentas.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 389);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 4;
            label2.Text = "Lista de Ventas";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(587, 270);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(414, 127);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(587, 242);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 6;
            label3.Text = "Descripcion:";
            // 
            // FrmComiqueria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1038, 667);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(lstbVentas);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(lstbProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmComiqueria";
            Text = "FrmComiqueria";
            Load += FrmComiqueria_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbProductos;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnPrintTicket;
        private Button btnVender;
        private ListBox lstbVentas;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
    }
}