namespace Practica_7_grados_centigrados
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
            valor = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            Resultado = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(valor);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(42, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // valor
            // 
            valor.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valor.Location = new Point(168, 38);
            valor.Name = "valor";
            valor.Size = new Size(100, 23);
            valor.TabIndex = 1;
            valor.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 38);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa valor:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(42, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opciones de conversión";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(245, 40);
            button3.Name = "button3";
            button3.Size = new Size(85, 29);
            button3.TabIndex = 2;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(122, 40);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 1;
            button2.Text = "Centígrados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(6, 40);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 0;
            button1.Text = "Fahrenheit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Resultado);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(42, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(336, 110);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultado en grados";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(188, 46);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 29);
            Resultado.TabIndex = 1;
            Resultado.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(141, 17);
            label2.TabIndex = 0;
            label2.Text = "Equivalente en grados:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "conversion de temperatura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox valor;
        private Label label1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button button3;
        private GroupBox groupBox3;
        private TextBox Resultado;
        private Label label2;
    }
}
