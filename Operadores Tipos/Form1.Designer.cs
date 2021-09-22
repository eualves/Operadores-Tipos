
namespace Operadores_Tipos
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPrincipal = new System.Windows.Forms.ListBox();
            this.btnFormatacao = new System.Windows.Forms.Button();
            this.lblFormatacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(70, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(70, 126);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(62, 15);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(70, 60);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 15);
            this.lblA.TabIndex = 2;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(70, 93);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(0, 15);
            this.lblB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mais Operadores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPrincipal
            // 
            this.listBoxPrincipal.FormattingEnabled = true;
            this.listBoxPrincipal.ItemHeight = 15;
            this.listBoxPrincipal.Location = new System.Drawing.Point(70, 250);
            this.listBoxPrincipal.Name = "listBoxPrincipal";
            this.listBoxPrincipal.Size = new System.Drawing.Size(339, 184);
            this.listBoxPrincipal.TabIndex = 5;
            // 
            // btnFormatacao
            // 
            this.btnFormatacao.Location = new System.Drawing.Point(515, 29);
            this.btnFormatacao.Name = "btnFormatacao";
            this.btnFormatacao.Size = new System.Drawing.Size(96, 32);
            this.btnFormatacao.TabIndex = 6;
            this.btnFormatacao.Text = "Formatação";
            this.btnFormatacao.UseVisualStyleBackColor = true;
            this.btnFormatacao.Click += new System.EventHandler(this.Formatacao_Click);
            // 
            // lblFormatacao
            // 
            this.lblFormatacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFormatacao.Location = new System.Drawing.Point(467, 78);
            this.lblFormatacao.Name = "lblFormatacao";
            this.lblFormatacao.Size = new System.Drawing.Size(200, 100);
            this.lblFormatacao.TabIndex = 7;
            this.lblFormatacao.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.lblFormatacao);
            this.Controls.Add(this.btnFormatacao);
            this.Controls.Add(this.listBoxPrincipal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxPrincipal;
        private System.Windows.Forms.Button btnFormatacao;
        private System.Windows.Forms.Label lblFormatacao;
    }
}

