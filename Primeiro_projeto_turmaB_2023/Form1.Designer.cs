namespace Primeiro_projeto_turmaB_2023
{
    partial class frmCalculo
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.grpControle = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNum1.Location = new System.Drawing.Point(84, 44);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(311, 29);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Digite o primeiro número:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNum2.Location = new System.Drawing.Point(84, 190);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(314, 29);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Digite o segundo número:";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNum1.Location = new System.Drawing.Point(88, 93);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 35);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.Text = "                                    ";
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNum2.Location = new System.Drawing.Point(88, 240);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 35);
            this.txtNum2.TabIndex = 3;
            // 
            // grpControle
            // 
            this.grpControle.Controls.Add(this.btnCalcular);
            this.grpControle.Controls.Add(this.btnLimpar);
            this.grpControle.Controls.Add(this.btnSair);
            this.grpControle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpControle.Location = new System.Drawing.Point(513, 44);
            this.grpControle.Name = "grpControle";
            this.grpControle.Size = new System.Drawing.Size(200, 286);
            this.grpControle.TabIndex = 4;
            this.grpControle.TabStop = false;
            this.grpControle.Text = "Controles";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(31, 49);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 44);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "&CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(31, 114);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(131, 44);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(31, 184);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 47);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(809, 499);
            this.Controls.Add(this.grpControle);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmCalculo";
            this.Text = "Aplicativo de Cálculo";
            this.Load += new System.EventHandler(this.FrmCalculo_Load);
            this.grpControle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.GroupBox grpControle;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

