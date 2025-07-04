
namespace Projeto_Cadastro
{
    partial class Frm_Confirmacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Resultado2 = new System.Windows.Forms.Label();
            this.Lbl_Confirmacao = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Resultado2
            // 
            this.Lbl_Resultado2.AutoSize = true;
            this.Lbl_Resultado2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Resultado2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado2.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Resultado2.Location = new System.Drawing.Point(66, 264);
            this.Lbl_Resultado2.Name = "Lbl_Resultado2";
            this.Lbl_Resultado2.Size = new System.Drawing.Size(87, 21);
            this.Lbl_Resultado2.TabIndex = 9;
            this.Lbl_Resultado2.Text = "Resultado";
            // 
            // Lbl_Confirmacao
            // 
            this.Lbl_Confirmacao.AutoSize = true;
            this.Lbl_Confirmacao.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Confirmacao.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Confirmacao.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Confirmacao.Location = new System.Drawing.Point(65, 239);
            this.Lbl_Confirmacao.Name = "Lbl_Confirmacao";
            this.Lbl_Confirmacao.Size = new System.Drawing.Size(239, 25);
            this.Lbl_Confirmacao.TabIndex = 8;
            this.Lbl_Confirmacao.Text = "Confirmação dos Dados";
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(338, 239);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(79, 34);
            this.Btn_Voltar.TabIndex = 10;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Frm_Confirmacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 639);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Resultado2);
            this.Controls.Add(this.Lbl_Confirmacao);
            this.Name = "Frm_Confirmacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Confirmacao_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Confirmacao;
        private System.Windows.Forms.Button Btn_Voltar;
        public System.Windows.Forms.Label Lbl_Resultado2;
    }
}