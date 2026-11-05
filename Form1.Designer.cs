namespace CalculadoraPaneles
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
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label2 = new Label();
            txtNumero2 = new TextBox();
            label1 = new Label();
            txtNumero1 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            btnLimpiar = new Button();
            btnDividir = new Button();
            button3 = new Button();
            btnRestar = new Button();
            btnSumar = new Button();
            txtResultado = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            txtResultado.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNumero2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNumero1);
            panel1.Location = new Point(12, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 235);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 41);
            panel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 10);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 4;
            label4.Text = "DATOS";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 151);
            label2.Name = "label2";
            label2.Size = new Size(178, 28);
            label2.TabIndex = 2;
            label2.Text = "Segundo número:";
            // 
            // txtNumero2
            // 
            txtNumero2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero2.Location = new Point(183, 151);
            txtNumero2.Multiline = true;
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(108, 38);
            txtNumero2.TabIndex = 3;
            txtNumero2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(9, 85);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "Primer número:";
            label1.Click += label1_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero1.Location = new Point(183, 85);
            txtNumero1.Multiline = true;
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(108, 36);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(162, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(277, 37);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnLimpiar);
            panel2.Location = new Point(12, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 98);
            panel2.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Navy;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(463, 41);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 48);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(181, 85);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(128, 48);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "÷ Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(181, 139);
            button3.Name = "button3";
            button3.Size = new Size(128, 48);
            button3.TabIndex = 2;
            button3.Text = "x Multiplicar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(35, 85);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(127, 48);
            btnRestar.TabIndex = 1;
            btnRestar.Text = "- Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(35, 139);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(127, 48);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "+ Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += button1_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.LightSteelBlue;
            txtResultado.Controls.Add(btnDividir);
            txtResultado.Controls.Add(panel4);
            txtResultado.Controls.Add(button3);
            txtResultado.Controls.Add(btnSumar);
            txtResultado.Controls.Add(btnRestar);
            txtResultado.Location = new Point(341, 50);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(344, 235);
            txtResultado.TabIndex = 2;
            txtResultado.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(344, 41);
            panel4.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(148, 28);
            label5.TabIndex = 5;
            label5.Text = "OPERACIONES";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 28);
            label3.TabIndex = 0;
            label3.Text = "RESULTADO ";
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 6;
            label6.Click += label6_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.CornflowerBlue;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(12, 291);
            panel5.Name = "panel5";
            panel5.Size = new Size(673, 36);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Navy;
            panel6.Controls.Add(label7);
            panel6.Location = new Point(12, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(673, 39);
            panel6.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(224, 4);
            label7.Name = "label7";
            label7.Size = new Size(267, 31);
            label7.TabIndex = 0;
            label7.Text = "CALCULADORA BÁSICA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 400);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(txtResultado);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            txtResultado.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Panel panel2;
        private Panel txtResultado;
        private Button btnDividir;
        private Button button3;
        private Button btnRestar;
        private Button btnSumar;
        private Button btnLimpiar;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label7;
    }
}
