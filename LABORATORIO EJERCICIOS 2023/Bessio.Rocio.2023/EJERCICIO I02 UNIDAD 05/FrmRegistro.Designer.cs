namespace EJERCICIO_I02_UNIDAD_05
{
    partial class FrmRegistro
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
            groupBox1 = new GroupBox();
            tbDireccion = new TextBox();
            tbNombre = new TextBox();
            numericUpDownEdad = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            rbGeneroNoBin = new RadioButton();
            rbGeneroFemenino = new RadioButton();
            rbGeneroMasc = new RadioButton();
            groupBox3 = new GroupBox();
            cbCursosJavaScript = new CheckBox();
            cbCursosCSharp = new CheckBox();
            cbCursoC = new CheckBox();
            listBoxPaises = new ListBox();
            label1 = new Label();
            btnIngresar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(numericUpDownEdad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 172);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del usuario";
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(129, 89);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(150, 29);
            tbDireccion.TabIndex = 10;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(129, 38);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(150, 29);
            tbNombre.TabIndex = 9;
            // 
            // numericUpDownEdad
            // 
            numericUpDownEdad.Location = new Point(99, 137);
            numericUpDownEdad.Name = "numericUpDownEdad";
            numericUpDownEdad.Size = new Size(180, 29);
            numericUpDownEdad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 137);
            label4.Name = "label4";
            label4.Size = new Size(60, 22);
            label4.TabIndex = 7;
            label4.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(110, 22);
            label3.TabIndex = 6;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbGeneroNoBin);
            groupBox2.Controls.Add(rbGeneroFemenino);
            groupBox2.Controls.Add(rbGeneroMasc);
            groupBox2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(381, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 166);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Género";
            // 
            // rbGeneroNoBin
            // 
            rbGeneroNoBin.AutoSize = true;
            rbGeneroNoBin.Location = new Point(23, 133);
            rbGeneroNoBin.Name = "rbGeneroNoBin";
            rbGeneroNoBin.Size = new Size(135, 26);
            rbGeneroNoBin.TabIndex = 2;
            rbGeneroNoBin.TabStop = true;
            rbGeneroNoBin.Text = "No binario";
            rbGeneroNoBin.UseVisualStyleBackColor = true;
            // 
            // rbGeneroFemenino
            // 
            rbGeneroFemenino.AutoSize = true;
            rbGeneroFemenino.Location = new Point(23, 88);
            rbGeneroFemenino.Name = "rbGeneroFemenino";
            rbGeneroFemenino.Size = new Size(115, 26);
            rbGeneroFemenino.TabIndex = 1;
            rbGeneroFemenino.TabStop = true;
            rbGeneroFemenino.Text = "Femenino";
            rbGeneroFemenino.UseVisualStyleBackColor = true;
            // 
            // rbGeneroMasc
            // 
            rbGeneroMasc.AutoSize = true;
            rbGeneroMasc.Location = new Point(23, 36);
            rbGeneroMasc.Name = "rbGeneroMasc";
            rbGeneroMasc.Size = new Size(125, 26);
            rbGeneroMasc.TabIndex = 0;
            rbGeneroMasc.TabStop = true;
            rbGeneroMasc.Text = "Masculino";
            rbGeneroMasc.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbCursosJavaScript);
            groupBox3.Controls.Add(cbCursosCSharp);
            groupBox3.Controls.Add(cbCursoC);
            groupBox3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(381, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(197, 150);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cursos";
            // 
            // cbCursosJavaScript
            // 
            cbCursosJavaScript.AutoSize = true;
            cbCursosJavaScript.Location = new Point(22, 107);
            cbCursosJavaScript.Name = "cbCursosJavaScript";
            cbCursosJavaScript.Size = new Size(136, 26);
            cbCursosJavaScript.TabIndex = 5;
            cbCursosJavaScript.Text = "JavaScript";
            cbCursosJavaScript.UseVisualStyleBackColor = true;
            // 
            // cbCursosCSharp
            // 
            cbCursosCSharp.AutoSize = true;
            cbCursosCSharp.Location = new Point(102, 43);
            cbCursosCSharp.Name = "cbCursosCSharp";
            cbCursosCSharp.Size = new Size(56, 26);
            cbCursosCSharp.TabIndex = 4;
            cbCursosCSharp.Text = "C#";
            cbCursosCSharp.UseVisualStyleBackColor = true;
            // 
            // cbCursoC
            // 
            cbCursoC.AutoSize = true;
            cbCursoC.Location = new Point(23, 43);
            cbCursoC.Name = "cbCursoC";
            cbCursoC.Size = new Size(46, 26);
            cbCursoC.TabIndex = 3;
            cbCursoC.Text = "C";
            cbCursoC.UseVisualStyleBackColor = true;
            // 
            // listBoxPaises
            // 
            listBoxPaises.FormattingEnabled = true;
            listBoxPaises.ItemHeight = 25;
            listBoxPaises.Location = new Point(12, 227);
            listBoxPaises.Name = "listBoxPaises";
            listBoxPaises.Size = new Size(300, 129);
            listBoxPaises.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 202);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 4;
            label1.Text = "País";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(403, 377);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(158, 51);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 450);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Controls.Add(listBoxPaises);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmRegistro";
            Text = "Form1";
            Load += FrmRegistro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbDireccion;
        private TextBox tbNombre;
        private NumericUpDown numericUpDownEdad;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton rbGeneroNoBin;
        private RadioButton rbGeneroFemenino;
        private RadioButton rbGeneroMasc;
        private GroupBox groupBox3;
        private CheckBox cbCursosJavaScript;
        private CheckBox cbCursosCSharp;
        private CheckBox cbCursoC;
        private ListBox listBoxPaises;
        private Label label1;
        private Button btnIngresar;
    }
}