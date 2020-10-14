namespace FormComplejo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCompReal1 = new System.Windows.Forms.TextBox();
            this.txtbCompImag1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOperador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCompReal2 = new System.Windows.Forms.TextBox();
            this.txtbCompImag2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnConjugar = new System.Windows.Forms.Button();
            this.rdbSuma = new System.Windows.Forms.RadioButton();
            this.rdbResta = new System.Windows.Forms.RadioButton();
            this.rdbMult = new System.Windows.Forms.RadioButton();
            this.rdbConjuga = new System.Windows.Forms.RadioButton();
            this.lbConjuga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complejo 1";
            // 
            // txtbCompReal1
            // 
            this.txtbCompReal1.Location = new System.Drawing.Point(31, 131);
            this.txtbCompReal1.Name = "txtbCompReal1";
            this.txtbCompReal1.Size = new System.Drawing.Size(68, 26);
            this.txtbCompReal1.TabIndex = 1;
            this.txtbCompReal1.Text = "2";
            // 
            // txtbCompImag1
            // 
            this.txtbCompImag1.Location = new System.Drawing.Point(161, 131);
            this.txtbCompImag1.Name = "txtbCompImag1";
            this.txtbCompImag1.Size = new System.Drawing.Size(68, 26);
            this.txtbCompImag1.TabIndex = 1;
            this.txtbCompImag1.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "+";
            // 
            // lbOperador
            // 
            this.lbOperador.AutoSize = true;
            this.lbOperador.Location = new System.Drawing.Point(273, 137);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(18, 20);
            this.lbOperador.TabIndex = 0;
            this.lbOperador.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "+";
            // 
            // txtbCompReal2
            // 
            this.txtbCompReal2.Location = new System.Drawing.Point(327, 131);
            this.txtbCompReal2.Name = "txtbCompReal2";
            this.txtbCompReal2.Size = new System.Drawing.Size(68, 26);
            this.txtbCompReal2.TabIndex = 1;
            this.txtbCompReal2.Text = "1";
            // 
            // txtbCompImag2
            // 
            this.txtbCompImag2.Location = new System.Drawing.Point(463, 131);
            this.txtbCompImag2.Name = "txtbCompImag2";
            this.txtbCompImag2.Size = new System.Drawing.Size(68, 26);
            this.txtbCompImag2.TabIndex = 1;
            this.txtbCompImag2.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "=";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(627, 137);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(39, 20);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "3+7i";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "i";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "i";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Complejo 2";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(75, 242);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(104, 66);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(211, 242);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(104, 66);
            this.btnRestar.TabIndex = 2;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(355, 242);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(104, 66);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnConjugar
            // 
            this.btnConjugar.Location = new System.Drawing.Point(500, 242);
            this.btnConjugar.Name = "btnConjugar";
            this.btnConjugar.Size = new System.Drawing.Size(104, 66);
            this.btnConjugar.TabIndex = 2;
            this.btnConjugar.Text = "Conjugar";
            this.btnConjugar.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            this.rdbSuma.AutoSize = true;
            this.rdbSuma.Location = new System.Drawing.Point(757, 73);
            this.rdbSuma.Name = "rdbSuma";
            this.rdbSuma.Size = new System.Drawing.Size(73, 24);
            this.rdbSuma.TabIndex = 3;
            this.rdbSuma.TabStop = true;
            this.rdbSuma.Text = "suma";
            this.rdbSuma.UseVisualStyleBackColor = true;
            this.rdbSuma.CheckedChanged += new System.EventHandler(this.rdbSuma_CheckedChanged);
            // 
            // rdbResta
            // 
            this.rdbResta.AutoSize = true;
            this.rdbResta.Location = new System.Drawing.Point(757, 127);
            this.rdbResta.Name = "rdbResta";
            this.rdbResta.Size = new System.Drawing.Size(70, 24);
            this.rdbResta.TabIndex = 3;
            this.rdbResta.TabStop = true;
            this.rdbResta.Text = "resta";
            this.rdbResta.UseVisualStyleBackColor = true;
            this.rdbResta.CheckedChanged += new System.EventHandler(this.rdbResta_CheckedChanged);
            // 
            // rdbMult
            // 
            this.rdbMult.AutoSize = true;
            this.rdbMult.Location = new System.Drawing.Point(757, 178);
            this.rdbMult.Name = "rdbMult";
            this.rdbMult.Size = new System.Drawing.Size(128, 24);
            this.rdbMult.TabIndex = 3;
            this.rdbMult.TabStop = true;
            this.rdbMult.Text = "multiplicación";
            this.rdbMult.UseVisualStyleBackColor = true;
            this.rdbMult.CheckedChanged += new System.EventHandler(this.rdbMult_CheckedChanged);
            // 
            // rdbConjuga
            // 
            this.rdbConjuga.AutoSize = true;
            this.rdbConjuga.Location = new System.Drawing.Point(757, 242);
            this.rdbConjuga.Name = "rdbConjuga";
            this.rdbConjuga.Size = new System.Drawing.Size(90, 24);
            this.rdbConjuga.TabIndex = 3;
            this.rdbConjuga.TabStop = true;
            this.rdbConjuga.Text = "conjuga";
            this.rdbConjuga.UseVisualStyleBackColor = true;
            this.rdbConjuga.CheckedChanged += new System.EventHandler(this.rdbConjuga_CheckedChanged);
            // 
            // lbConjuga
            // 
            this.lbConjuga.AutoSize = true;
            this.lbConjuga.Location = new System.Drawing.Point(611, 96);
            this.lbConjuga.Name = "lbConjuga";
            this.lbConjuga.Size = new System.Drawing.Size(68, 20);
            this.lbConjuga.TabIndex = 0;
            this.lbConjuga.Text = "Conjuga";
            this.lbConjuga.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.rdbConjuga);
            this.Controls.Add(this.rdbMult);
            this.Controls.Add(this.rdbResta);
            this.Controls.Add(this.rdbSuma);
            this.Controls.Add(this.btnConjugar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtbCompImag2);
            this.Controls.Add(this.txtbCompReal2);
            this.Controls.Add(this.txtbCompImag1);
            this.Controls.Add(this.txtbCompReal1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbOperador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbConjuga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCompReal1;
        private System.Windows.Forms.TextBox txtbCompImag1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOperador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCompReal2;
        private System.Windows.Forms.TextBox txtbCompImag2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnConjugar;
        private System.Windows.Forms.RadioButton rdbSuma;
        private System.Windows.Forms.RadioButton rdbResta;
        private System.Windows.Forms.RadioButton rdbMult;
        private System.Windows.Forms.RadioButton rdbConjuga;
        private System.Windows.Forms.Label lbConjuga;
    }
}

