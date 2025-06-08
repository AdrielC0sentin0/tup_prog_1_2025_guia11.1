namespace Ejercicio1
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
            tbNumero = new TextBox();
            groupBox1 = new GroupBox();
            btnRegistrarValor = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lbMinimo = new Label();
            lbMaximo = new Label();
            btnActualizarMaxyMin = new Button();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            lbPromedio = new Label();
            btnActualizarPromedio = new Button();
            label7 = new Label();
            groupBox4 = new GroupBox();
            lbCantidad = new Label();
            btnVerCantidad = new Button();
            label5 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tbNumero
            // 
            tbNumero.Location = new Point(159, 55);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(100, 23);
            tbNumero.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarValor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbNumero);
            groupBox1.Location = new Point(120, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 135);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesar numero";
            // 
            // btnRegistrarValor
            // 
            btnRegistrarValor.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistrarValor.Location = new Point(159, 84);
            btnRegistrarValor.Name = "btnRegistrarValor";
            btnRegistrarValor.Size = new Size(100, 28);
            btnRegistrarValor.TabIndex = 2;
            btnRegistrarValor.Text = "Registrar valor";
            btnRegistrarValor.UseVisualStyleBackColor = true;
            btnRegistrarValor.Click += btnRegistrarValor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 57);
            label1.Name = "label1";
            label1.Size = new Size(115, 16);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un numero";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbMinimo);
            groupBox2.Controls.Add(lbMaximo);
            groupBox2.Controls.Add(btnActualizarMaxyMin);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(120, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 135);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Procesar Maximo y Minimo";
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            lbMinimo.Location = new Point(67, 89);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(59, 16);
            lbMinimo.TabIndex = 4;
            lbMinimo.Text = "lbMinimo";
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            lbMaximo.Location = new Point(67, 60);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(62, 16);
            lbMaximo.TabIndex = 3;
            lbMaximo.Text = "lbMaximo";
            // 
            // btnActualizarMaxyMin
            // 
            btnActualizarMaxyMin.Location = new Point(159, 69);
            btnActualizarMaxyMin.Name = "btnActualizarMaxyMin";
            btnActualizarMaxyMin.Size = new Size(100, 26);
            btnActualizarMaxyMin.TabIndex = 2;
            btnActualizarMaxyMin.Text = "Actualizar";
            btnActualizarMaxyMin.UseVisualStyleBackColor = true;
            btnActualizarMaxyMin.Click += btnActualizarMaxyMin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            label3.Location = new Point(6, 89);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 1;
            label3.Text = "Minimo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 0;
            label2.Text = "Maximo:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbPromedio);
            groupBox3.Controls.Add(btnActualizarPromedio);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(120, 153);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(279, 90);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Procesar promedio";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            lbPromedio.Location = new Point(78, 50);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(73, 16);
            lbPromedio.TabIndex = 3;
            lbPromedio.Text = "lbPromedio";
            // 
            // btnActualizarPromedio
            // 
            btnActualizarPromedio.Location = new Point(157, 45);
            btnActualizarPromedio.Name = "btnActualizarPromedio";
            btnActualizarPromedio.Size = new Size(100, 26);
            btnActualizarPromedio.TabIndex = 2;
            btnActualizarPromedio.Text = "Actualizar";
            btnActualizarPromedio.UseVisualStyleBackColor = true;
            btnActualizarPromedio.Click += btnActualizarPromedio_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            label7.Location = new Point(6, 50);
            label7.Name = "label7";
            label7.Size = new Size(66, 16);
            label7.TabIndex = 0;
            label7.Text = "Promedio:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbCantidad);
            groupBox4.Controls.Add(btnVerCantidad);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(120, 390);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(279, 90);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar cantidad de ingresados";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            lbCantidad.Location = new Point(78, 50);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(69, 16);
            lbCantidad.TabIndex = 3;
            lbCantidad.Text = "lbCantidad";
            // 
            // btnVerCantidad
            // 
            btnVerCantidad.Location = new Point(157, 45);
            btnVerCantidad.Name = "btnVerCantidad";
            btnVerCantidad.Size = new Size(100, 26);
            btnVerCantidad.TabIndex = 2;
            btnVerCantidad.Text = "Actualizar";
            btnVerCantidad.UseVisualStyleBackColor = true;
            btnVerCantidad.Click += btnVerCantidad_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            label5.Location = new Point(6, 50);
            label5.Name = "label5";
            label5.Size = new Size(62, 16);
            label5.TabIndex = 0;
            label5.Text = "Cantidad:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(141, 486);
            button1.Name = "button1";
            button1.Size = new Size(227, 41);
            button1.TabIndex = 7;
            button1.Text = "Reiniciar Valores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 540);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbNumero;
        private GroupBox groupBox1;
        private Button btnRegistrarValor;
        private Label label1;
        private GroupBox groupBox2;
        private Label lbMinimo;
        private Label lbMaximo;
        private Button btnActualizarMaxyMin;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Label lbPromedio;
        private Button btnActualizarPromedio;
        private Label label7;
        private GroupBox groupBox4;
        private Label lbCantidad;
        private Button btnVerCantidad;
        private Label label5;
        private Button button1;
    }
}
