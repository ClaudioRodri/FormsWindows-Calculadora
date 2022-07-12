
namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnIg = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSubt = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.bnt3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.Color.DarkOrange;
            this.txtVisor.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(56, 12);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(385, 78);
            this.txtVisor.TabIndex = 0;
            // 
            // btnDiv
            // 
            this.btnDiv.AutoSize = true;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Image = global::Calculadora.Properties.Resources.clacdivi;
            this.btnDiv.Location = new System.Drawing.Point(299, 340);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 69);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnIg
            // 
            this.btnIg.AutoSize = true;
            this.btnIg.FlatAppearance.BorderSize = 0;
            this.btnIg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIg.Image = global::Calculadora.Properties.Resources.clacI;
            this.btnIg.Location = new System.Drawing.Point(218, 340);
            this.btnIg.Name = "btnIg";
            this.btnIg.Size = new System.Drawing.Size(75, 69);
            this.btnIg.TabIndex = 16;
            this.btnIg.UseVisualStyleBackColor = true;
            this.btnIg.Click += new System.EventHandler(this.btnIg_Click);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Image = global::Calculadora.Properties.Resources.clac0;
            this.btn0.Location = new System.Drawing.Point(137, 340);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 69);
            this.btn0.TabIndex = 15;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Image = global::Calculadora.Properties.Resources.clacC;
            this.btnC.Location = new System.Drawing.Point(56, 340);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 69);
            this.btnC.TabIndex = 14;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMult
            // 
            this.btnMult.AutoSize = true;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Image = global::Calculadora.Properties.Resources.clacX;
            this.btnMult.Location = new System.Drawing.Point(299, 265);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 69);
            this.btnMult.TabIndex = 13;
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Image = global::Calculadora.Properties.Resources.clac9;
            this.btn9.Location = new System.Drawing.Point(218, 265);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 69);
            this.btn9.TabIndex = 12;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Image = global::Calculadora.Properties.Resources.clac8;
            this.btn8.Location = new System.Drawing.Point(137, 265);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 69);
            this.btn8.TabIndex = 11;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Image = global::Calculadora.Properties.Resources.clac7;
            this.btn7.Location = new System.Drawing.Point(56, 265);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 69);
            this.btn7.TabIndex = 10;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnSubt
            // 
            this.btnSubt.AutoSize = true;
            this.btnSubt.FlatAppearance.BorderSize = 0;
            this.btnSubt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubt.Image = global::Calculadora.Properties.Resources.clacM;
            this.btnSubt.Location = new System.Drawing.Point(299, 190);
            this.btnSubt.Name = "btnSubt";
            this.btnSubt.Size = new System.Drawing.Size(75, 69);
            this.btnSubt.TabIndex = 9;
            this.btnSubt.UseVisualStyleBackColor = true;
            this.btnSubt.Click += new System.EventHandler(this.btnSubt_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Image = global::Calculadora.Properties.Resources.clac6;
            this.btn6.Location = new System.Drawing.Point(218, 190);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 69);
            this.btn6.TabIndex = 8;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Image = global::Calculadora.Properties.Resources.clac5;
            this.btn5.Location = new System.Drawing.Point(137, 190);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 69);
            this.btn5.TabIndex = 7;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Image = global::Calculadora.Properties.Resources.clac4;
            this.btn4.Location = new System.Drawing.Point(56, 190);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 69);
            this.btn4.TabIndex = 6;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.AutoSize = true;
            this.btnSoma.FlatAppearance.BorderSize = 0;
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoma.Image = global::Calculadora.Properties.Resources.clacMa;
            this.btnSoma.Location = new System.Drawing.Point(299, 115);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 69);
            this.btnSoma.TabIndex = 5;
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // bnt3
            // 
            this.bnt3.AutoSize = true;
            this.bnt3.FlatAppearance.BorderSize = 0;
            this.bnt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt3.Image = global::Calculadora.Properties.Resources.clac3;
            this.bnt3.Location = new System.Drawing.Point(218, 115);
            this.bnt3.Name = "bnt3";
            this.bnt3.Size = new System.Drawing.Size(75, 69);
            this.bnt3.TabIndex = 4;
            this.bnt3.UseVisualStyleBackColor = true;
            this.bnt3.Click += new System.EventHandler(this.bnt3_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Image = global::Calculadora.Properties.Resources.clac2;
            this.btn2.Location = new System.Drawing.Point(137, 115);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 69);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::Calculadora.Properties.Resources.clac1;
            this.btn1.Location = new System.Drawing.Point(56, 115);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 69);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 489);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnIg);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSubt);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.bnt3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EtecCALC";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button bnt3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSubt;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnIg;
        private System.Windows.Forms.Button btnDiv;
    }
}

