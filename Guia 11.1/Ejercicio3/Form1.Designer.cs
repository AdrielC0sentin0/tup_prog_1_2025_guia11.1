namespace Ejercicio3
{
    partial class Form1
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
            btnRegistrarEstudiante = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbNombre3 = new TextBox();
            tbNombre2 = new TextBox();
            tbNombre1 = new TextBox();
            tbLibreta3 = new TextBox();
            tbLibreta2 = new TextBox();
            tbLibreta1 = new TextBox();
            groupBox2 = new GroupBox();
            btnListaOrdenada = new Button();
            tbResultadosOrdenados = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.Location = new Point(152, 140);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(173, 41);
            btnRegistrarEstudiante.TabIndex = 0;
            btnRegistrarEstudiante.Text = "Registrar Estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            btnRegistrarEstudiante.Click += btnRegistrarEstudiante_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbNombre3);
            groupBox1.Controls.Add(tbNombre2);
            groupBox1.Controls.Add(tbNombre1);
            groupBox1.Controls.Add(tbLibreta3);
            groupBox1.Controls.Add(tbLibreta2);
            groupBox1.Controls.Add(tbLibreta1);
            groupBox1.Controls.Add(btnRegistrarEstudiante);
            groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 204);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro del estudiante (Libreta y Nombre)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 104);
            label6.Name = "label6";
            label6.Size = new Size(60, 16);
            label6.TabIndex = 12;
            label6.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 76);
            label5.Name = "label5";
            label5.Size = new Size(60, 16);
            label5.TabIndex = 11;
            label5.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 48);
            label4.Name = "label4";
            label4.Size = new Size(60, 16);
            label4.TabIndex = 10;
            label4.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 16);
            label3.TabIndex = 9;
            label3.Text = "Libreta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 76);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 8;
            label2.Text = "Libreta:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 16);
            label1.TabIndex = 7;
            label1.Text = "Libreta:";
            // 
            // tbNombre3
            // 
            tbNombre3.Location = new Point(318, 98);
            tbNombre3.Name = "tbNombre3";
            tbNombre3.Size = new Size(100, 22);
            tbNombre3.TabIndex = 6;
            // 
            // tbNombre2
            // 
            tbNombre2.Location = new Point(318, 70);
            tbNombre2.Name = "tbNombre2";
            tbNombre2.Size = new Size(100, 22);
            tbNombre2.TabIndex = 5;
            // 
            // tbNombre1
            // 
            tbNombre1.Location = new Point(318, 42);
            tbNombre1.Name = "tbNombre1";
            tbNombre1.Size = new Size(100, 22);
            tbNombre1.TabIndex = 4;
            // 
            // tbLibreta3
            // 
            tbLibreta3.Location = new Point(106, 98);
            tbLibreta3.Name = "tbLibreta3";
            tbLibreta3.Size = new Size(100, 22);
            tbLibreta3.TabIndex = 3;
            // 
            // tbLibreta2
            // 
            tbLibreta2.Location = new Point(106, 70);
            tbLibreta2.Name = "tbLibreta2";
            tbLibreta2.Size = new Size(100, 22);
            tbLibreta2.TabIndex = 2;
            // 
            // tbLibreta1
            // 
            tbLibreta1.Location = new Point(106, 42);
            tbLibreta1.Name = "tbLibreta1";
            tbLibreta1.Size = new Size(100, 22);
            tbLibreta1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnListaOrdenada);
            groupBox2.Controls.Add(tbResultadosOrdenados);
            groupBox2.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.Location = new Point(12, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(461, 224);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mostrar lista ordenada";
            // 
            // btnListaOrdenada
            // 
            btnListaOrdenada.Location = new Point(366, 80);
            btnListaOrdenada.Name = "btnListaOrdenada";
            btnListaOrdenada.Size = new Size(89, 57);
            btnListaOrdenada.TabIndex = 1;
            btnListaOrdenada.Text = "Actualizar";
            btnListaOrdenada.UseVisualStyleBackColor = true;
            btnListaOrdenada.Click += btnListaOrdenada_Click;
            // 
            // tbResultadosOrdenados
            // 
            tbResultadosOrdenados.Location = new Point(6, 21);
            tbResultadosOrdenados.Multiline = true;
            tbResultadosOrdenados.Name = "tbResultadosOrdenados";
            tbResultadosOrdenados.Size = new Size(354, 181);
            tbResultadosOrdenados.TabIndex = 0;
            tbResultadosOrdenados.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(485, 498);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarEstudiante;
        private GroupBox groupBox1;
        private TextBox tbNombre3;
        private TextBox tbNombre2;
        private TextBox tbNombre1;
        private TextBox tbLibreta3;
        private TextBox tbLibreta2;
        private TextBox tbLibreta1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox tbResultadosOrdenados;
        private Button btnListaOrdenada;
    }
}
