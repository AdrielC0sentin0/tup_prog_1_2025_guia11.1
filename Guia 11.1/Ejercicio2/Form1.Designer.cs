namespace Ejercicio2
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
            groupBox1 = new GroupBox();
            btnRegistrarMonto = new Button();
            tbMonto = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRegistrarEdades = new Button();
            tbEdad4 = new TextBox();
            label5 = new Label();
            tbEdad3 = new TextBox();
            label4 = new Label();
            tbEdad2 = new TextBox();
            label3 = new Label();
            tbEdad1 = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnMontoyPorcentaje = new Button();
            tbResultados = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarMonto);
            groupBox1.Controls.Add(tbMonto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 106);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Solicitud de monto a repartir";
            // 
            // btnRegistrarMonto
            // 
            btnRegistrarMonto.Location = new Point(266, 47);
            btnRegistrarMonto.Name = "btnRegistrarMonto";
            btnRegistrarMonto.Size = new Size(121, 24);
            btnRegistrarMonto.TabIndex = 2;
            btnRegistrarMonto.Text = "Registrar Monto";
            btnRegistrarMonto.UseVisualStyleBackColor = true;
            btnRegistrarMonto.Click += btnRegistrarMonto_Click;
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(146, 47);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(100, 23);
            tbMonto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 50);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 0;
            label1.Text = "Monto:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRegistrarEdades);
            groupBox2.Controls.Add(tbEdad4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbEdad3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbEdad2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbEdad1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 185);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Solicitud de monto a repartir";
            // 
            // btnRegistrarEdades
            // 
            btnRegistrarEdades.Location = new Point(184, 124);
            btnRegistrarEdades.Name = "btnRegistrarEdades";
            btnRegistrarEdades.Size = new Size(140, 37);
            btnRegistrarEdades.TabIndex = 8;
            btnRegistrarEdades.Text = "Registrar Edades";
            btnRegistrarEdades.UseVisualStyleBackColor = true;
            btnRegistrarEdades.Click += btnRegistrarEdades_Click;
            // 
            // tbEdad4
            // 
            tbEdad4.Location = new Point(349, 78);
            tbEdad4.Name = "tbEdad4";
            tbEdad4.Size = new Size(55, 23);
            tbEdad4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(292, 81);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 6;
            label5.Text = "Edad 4:";
            // 
            // tbEdad3
            // 
            tbEdad3.Location = new Point(349, 34);
            tbEdad3.Name = "tbEdad3";
            tbEdad3.Size = new Size(55, 23);
            tbEdad3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(292, 37);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 4;
            label4.Text = "Edad 3:";
            // 
            // tbEdad2
            // 
            tbEdad2.Location = new Point(146, 80);
            tbEdad2.Name = "tbEdad2";
            tbEdad2.Size = new Size(55, 23);
            tbEdad2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 83);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 2;
            label3.Text = "Edad 2:";
            // 
            // tbEdad1
            // 
            tbEdad1.Location = new Point(146, 36);
            tbEdad1.Name = "tbEdad1";
            tbEdad1.Size = new Size(55, 23);
            tbEdad1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 39);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 0;
            label2.Text = "Edad 1:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnMontoyPorcentaje);
            groupBox3.Controls.Add(tbResultados);
            groupBox3.Location = new Point(12, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(489, 197);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Monto y Porcentaje de las niñas";
            // 
            // btnMontoyPorcentaje
            // 
            btnMontoyPorcentaje.Location = new Point(374, 81);
            btnMontoyPorcentaje.Name = "btnMontoyPorcentaje";
            btnMontoyPorcentaje.Size = new Size(105, 42);
            btnMontoyPorcentaje.TabIndex = 1;
            btnMontoyPorcentaje.Text = "Actualizar";
            btnMontoyPorcentaje.UseVisualStyleBackColor = true;
            btnMontoyPorcentaje.Click += btnMontoyPorcentaje_Click;
            // 
            // tbResultados
            // 
            tbResultados.Location = new Point(18, 22);
            tbResultados.Multiline = true;
            tbResultados.Name = "tbResultados";
            tbResultados.Size = new Size(350, 169);
            tbResultados.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 525);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrarMonto;
        private TextBox tbMonto;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tbEdad4;
        private Label label5;
        private TextBox tbEdad3;
        private Label label4;
        private TextBox tbEdad2;
        private Label label3;
        private TextBox tbEdad1;
        private Label label2;
        private Button btnRegistrarEdades;
        private GroupBox groupBox3;
        private Button btnMontoyPorcentaje;
        private TextBox tbResultados;
    }
}
