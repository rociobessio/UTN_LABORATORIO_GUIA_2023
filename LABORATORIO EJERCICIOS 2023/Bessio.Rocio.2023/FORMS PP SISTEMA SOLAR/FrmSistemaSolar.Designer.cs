namespace FORMS_PP_SISTEMA_SOLAR
{
    partial class FrmSistemaSolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistemaSolar));
            txtNombrePlaneta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtOrbitaPlaneta = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtNombreAstro = new TextBox();
            cbPlanetas = new ComboBox();
            numOrbita = new NumericUpDown();
            numRotacion = new NumericUpDown();
            numSatelite = new NumericUpDown();
            numRotacionSatelite = new NumericUpDown();
            btnAgregarPlaneta = new Button();
            btnAgregarSatelite = new Button();
            btnMostrarAstros = new Button();
            button1 = new Button();
            cbTipo = new ComboBox();
            listPlanetas = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numOrbita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRotacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSatelite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRotacionSatelite).BeginInit();
            SuspendLayout();
            // 
            // txtNombrePlaneta
            // 
            txtNombrePlaneta.Location = new Point(269, 69);
            txtNombrePlaneta.Name = "txtNombrePlaneta";
            txtNombrePlaneta.Size = new Size(258, 31);
            txtNombrePlaneta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 72);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Planeta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 142);
            label2.Name = "label2";
            label2.Size = new Size(237, 25);
            label2.TabIndex = 3;
            label2.Text = "Tiempo en completar orbita:";
            // 
            // txtOrbitaPlaneta
            // 
            txtOrbitaPlaneta.Location = new Point(269, 136);
            txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            txtOrbitaPlaneta.Size = new Size(258, 31);
            txtOrbitaPlaneta.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 200);
            label3.Name = "label3";
            label3.Size = new Size(255, 25);
            label3.TabIndex = 4;
            label3.Text = "Tiempo en completar rotación:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 261);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 5;
            label4.Text = "Cantidad de lunas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 324);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 6;
            label5.Text = "Tipo de planeta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(630, 75);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 7;
            label6.Text = "Planeta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(594, 142);
            label7.Name = "label7";
            label7.Size = new Size(171, 25);
            label7.TabIndex = 8;
            label7.Text = "Nombre del satelite:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(561, 203);
            label8.Name = "label8";
            label8.Size = new Size(237, 25);
            label8.TabIndex = 9;
            label8.Text = "Tiempo en completar orbita:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(547, 261);
            label9.Name = "label9";
            label9.Size = new Size(255, 25);
            label9.TabIndex = 10;
            label9.Text = "Tiempo en completar rotación:";
            // 
            // txtNombreAstro
            // 
            txtNombreAstro.Location = new Point(808, 139);
            txtNombreAstro.Name = "txtNombreAstro";
            txtNombreAstro.Size = new Size(258, 31);
            txtNombreAstro.TabIndex = 11;
            // 
            // cbPlanetas
            // 
            cbPlanetas.FormattingEnabled = true;
            cbPlanetas.Location = new Point(808, 67);
            cbPlanetas.Name = "cbPlanetas";
            cbPlanetas.Size = new Size(258, 33);
            cbPlanetas.TabIndex = 12;
            // 
            // numOrbita
            // 
            numOrbita.Location = new Point(808, 201);
            numOrbita.Name = "numOrbita";
            numOrbita.Size = new Size(258, 31);
            numOrbita.TabIndex = 14;
            // 
            // numRotacion
            // 
            numRotacion.Location = new Point(269, 198);
            numRotacion.Name = "numRotacion";
            numRotacion.Size = new Size(258, 31);
            numRotacion.TabIndex = 15;
            // 
            // numSatelite
            // 
            numSatelite.Location = new Point(269, 264);
            numSatelite.Name = "numSatelite";
            numSatelite.Size = new Size(258, 31);
            numSatelite.TabIndex = 16;
            // 
            // numRotacionSatelite
            // 
            numRotacionSatelite.Location = new Point(808, 259);
            numRotacionSatelite.Name = "numRotacionSatelite";
            numRotacionSatelite.Size = new Size(258, 31);
            numRotacionSatelite.TabIndex = 17;
            // 
            // btnAgregarPlaneta
            // 
            btnAgregarPlaneta.Location = new Point(26, 397);
            btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            btnAgregarPlaneta.Size = new Size(503, 77);
            btnAgregarPlaneta.TabIndex = 19;
            btnAgregarPlaneta.Text = "Agregar Planeta";
            btnAgregarPlaneta.UseVisualStyleBackColor = true;
            btnAgregarPlaneta.Click += btnAgregarPlaneta_Click;
            // 
            // btnAgregarSatelite
            // 
            btnAgregarSatelite.Location = new Point(552, 397);
            btnAgregarSatelite.Name = "btnAgregarSatelite";
            btnAgregarSatelite.Size = new Size(503, 77);
            btnAgregarSatelite.TabIndex = 20;
            btnAgregarSatelite.Text = "Agregar Satelite";
            btnAgregarSatelite.UseVisualStyleBackColor = true;
            // 
            // btnMostrarAstros
            // 
            btnMostrarAstros.Location = new Point(26, 493);
            btnMostrarAstros.Name = "btnMostrarAstros";
            btnMostrarAstros.Size = new Size(1029, 67);
            btnMostrarAstros.TabIndex = 21;
            btnMostrarAstros.Text = "Mostrar informacion";
            btnMostrarAstros.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(26, 574);
            button1.Name = "button1";
            button1.Size = new Size(1029, 67);
            button1.TabIndex = 22;
            button1.Text = "Mover astros";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(269, 321);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(258, 33);
            cbTipo.TabIndex = 23;
            // 
            // listPlanetas
            // 
            listPlanetas.FormattingEnabled = true;
            listPlanetas.ItemHeight = 25;
            listPlanetas.Location = new Point(1095, 41);
            listPlanetas.Name = "listPlanetas";
            listPlanetas.Size = new Size(400, 604);
            listPlanetas.TabIndex = 24;
            // 
            // FrmSistemaSolar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1507, 669);
            Controls.Add(listPlanetas);
            Controls.Add(cbTipo);
            Controls.Add(button1);
            Controls.Add(btnMostrarAstros);
            Controls.Add(btnAgregarSatelite);
            Controls.Add(btnAgregarPlaneta);
            Controls.Add(numRotacionSatelite);
            Controls.Add(numSatelite);
            Controls.Add(numRotacion);
            Controls.Add(numOrbita);
            Controls.Add(cbPlanetas);
            Controls.Add(txtNombreAstro);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtOrbitaPlaneta);
            Controls.Add(label1);
            Controls.Add(txtNombrePlaneta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSistemaSolar";
            Text = "Form1";
            Load += FrmSistemaSolar_Load;
            ((System.ComponentModel.ISupportInitialize)numOrbita).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRotacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSatelite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRotacionSatelite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombrePlaneta;
        private Label label1;
        private Label label2;
        private TextBox txtOrbitaPlaneta;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtNombreAstro;
        private ComboBox cbPlanetas;
        private NumericUpDown numOrbita;
        private NumericUpDown numRotacion;
        private NumericUpDown numSatelite;
        private NumericUpDown numRotacionSatelite;
        private Button btnAgregarPlaneta;
        private Button btnAgregarSatelite;
        private Button btnMostrarAstros;
        private Button button1;
        private ComboBox cbTipo;
        private ListBox listPlanetas;
    }
}