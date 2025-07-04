
namespace Projeto_Cadastro
{
    partial class Frm_Cadastro
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
            this.Btn_Desativar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Ativar = new System.Windows.Forms.Button();
            this.Rad_Padrao = new System.Windows.Forms.RadioButton();
            this.Rad_T1 = new System.Windows.Forms.RadioButton();
            this.Rad_T2 = new System.Windows.Forms.RadioButton();
            this.Rad_T3 = new System.Windows.Forms.RadioButton();
            this.Grp_Temas = new System.Windows.Forms.GroupBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Sobrenome = new System.Windows.Forms.Label();
            this.Lbl_Idade = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Celular = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.Txt_Idade = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Txt_Celular = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Btn_Nome = new System.Windows.Forms.Button();
            this.Btn_Sobrenome = new System.Windows.Forms.Button();
            this.Btn_Idade = new System.Windows.Forms.Button();
            this.Btn_Bairro = new System.Windows.Forms.Button();
            this.Btn_Celular = new System.Windows.Forms.Button();
            this.Btn_Email = new System.Windows.Forms.Button();
            this.Btn_Enviar_Tudo = new System.Windows.Forms.Button();
            this.Lbl_Genero = new System.Windows.Forms.Label();
            this.Txt_Genero = new System.Windows.Forms.TextBox();
            this.Btn_Genero = new System.Windows.Forms.Button();
            this.Pic_Homen = new System.Windows.Forms.PictureBox();
            this.Pic_Mulher = new System.Windows.Forms.PictureBox();
            this.Pic_Outro = new System.Windows.Forms.PictureBox();
            this.Rad_Homem = new System.Windows.Forms.RadioButton();
            this.Rad_Mulher = new System.Windows.Forms.RadioButton();
            this.Rad_Outro = new System.Windows.Forms.RadioButton();
            this.Grp_Dados = new System.Windows.Forms.GroupBox();
            this.Lbl_Confirmacao = new System.Windows.Forms.Label();
            this.Grp_Temas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Homen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Mulher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Outro)).BeginInit();
            this.Grp_Dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Desativar
            // 
            this.Btn_Desativar.Enabled = false;
            this.Btn_Desativar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Desativar.Location = new System.Drawing.Point(579, 252);
            this.Btn_Desativar.Name = "Btn_Desativar";
            this.Btn_Desativar.Size = new System.Drawing.Size(104, 23);
            this.Btn_Desativar.TabIndex = 3;
            this.Btn_Desativar.Text = "Desativar";
            this.Btn_Desativar.UseVisualStyleBackColor = true;
            this.Btn_Desativar.Click += new System.EventHandler(this.Btn_Desativar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Enabled = false;
            this.Btn_Limpar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(579, 281);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(104, 23);
            this.Btn_Limpar.TabIndex = 4;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Ativar
            // 
            this.Btn_Ativar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ativar.Location = new System.Drawing.Point(579, 225);
            this.Btn_Ativar.Name = "Btn_Ativar";
            this.Btn_Ativar.Size = new System.Drawing.Size(104, 23);
            this.Btn_Ativar.TabIndex = 2;
            this.Btn_Ativar.Text = "Ativar";
            this.Btn_Ativar.UseVisualStyleBackColor = true;
            this.Btn_Ativar.Click += new System.EventHandler(this.Btn_Ativar_Click);
            // 
            // Rad_Padrao
            // 
            this.Rad_Padrao.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Padrao.ForeColor = System.Drawing.Color.Black;
            this.Rad_Padrao.Location = new System.Drawing.Point(7, 20);
            this.Rad_Padrao.Name = "Rad_Padrao";
            this.Rad_Padrao.Size = new System.Drawing.Size(71, 22);
            this.Rad_Padrao.TabIndex = 0;
            this.Rad_Padrao.TabStop = true;
            this.Rad_Padrao.Text = "Padrão";
            this.Rad_Padrao.UseVisualStyleBackColor = true;
            this.Rad_Padrao.CheckedChanged += new System.EventHandler(this.Rad_Padrao_CheckedChanged);
            // 
            // Rad_T1
            // 
            this.Rad_T1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_T1.ForeColor = System.Drawing.Color.Black;
            this.Rad_T1.Location = new System.Drawing.Point(122, 20);
            this.Rad_T1.Name = "Rad_T1";
            this.Rad_T1.Size = new System.Drawing.Size(73, 22);
            this.Rad_T1.TabIndex = 1;
            this.Rad_T1.TabStop = true;
            this.Rad_T1.Text = "Tema 1";
            this.Rad_T1.UseVisualStyleBackColor = true;
            this.Rad_T1.CheckedChanged += new System.EventHandler(this.Rad_T1_CheckedChanged);
            // 
            // Rad_T2
            // 
            this.Rad_T2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_T2.ForeColor = System.Drawing.Color.Black;
            this.Rad_T2.Location = new System.Drawing.Point(237, 20);
            this.Rad_T2.Name = "Rad_T2";
            this.Rad_T2.Size = new System.Drawing.Size(73, 22);
            this.Rad_T2.TabIndex = 2;
            this.Rad_T2.TabStop = true;
            this.Rad_T2.Text = "Tema 2";
            this.Rad_T2.UseVisualStyleBackColor = true;
            this.Rad_T2.CheckedChanged += new System.EventHandler(this.Rad_T2_CheckedChanged);
            // 
            // Rad_T3
            // 
            this.Rad_T3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_T3.ForeColor = System.Drawing.Color.Black;
            this.Rad_T3.Location = new System.Drawing.Point(352, 20);
            this.Rad_T3.Name = "Rad_T3";
            this.Rad_T3.Size = new System.Drawing.Size(73, 22);
            this.Rad_T3.TabIndex = 3;
            this.Rad_T3.TabStop = true;
            this.Rad_T3.Text = "Tema 3";
            this.Rad_T3.UseVisualStyleBackColor = true;
            this.Rad_T3.CheckedChanged += new System.EventHandler(this.Rad_T3_CheckedChanged);
            // 
            // Grp_Temas
            // 
            this.Grp_Temas.BackColor = System.Drawing.Color.Transparent;
            this.Grp_Temas.Controls.Add(this.Rad_T3);
            this.Grp_Temas.Controls.Add(this.Rad_T2);
            this.Grp_Temas.Controls.Add(this.Rad_T1);
            this.Grp_Temas.Controls.Add(this.Rad_Padrao);
            this.Grp_Temas.Enabled = false;
            this.Grp_Temas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Temas.ForeColor = System.Drawing.Color.Red;
            this.Grp_Temas.Location = new System.Drawing.Point(18, 142);
            this.Grp_Temas.Name = "Grp_Temas";
            this.Grp_Temas.Size = new System.Drawing.Size(532, 49);
            this.Grp_Temas.TabIndex = 1;
            this.Grp_Temas.TabStop = false;
            this.Grp_Temas.Text = "Temas";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nome.Location = new System.Drawing.Point(6, 35);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(44, 18);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Lbl_Sobrenome
            // 
            this.Lbl_Sobrenome.AutoSize = true;
            this.Lbl_Sobrenome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sobrenome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Sobrenome.Location = new System.Drawing.Point(6, 64);
            this.Lbl_Sobrenome.Name = "Lbl_Sobrenome";
            this.Lbl_Sobrenome.Size = new System.Drawing.Size(77, 18);
            this.Lbl_Sobrenome.TabIndex = 1;
            this.Lbl_Sobrenome.Text = "Sobrenome";
            // 
            // Lbl_Idade
            // 
            this.Lbl_Idade.AutoSize = true;
            this.Lbl_Idade.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idade.ForeColor = System.Drawing.Color.White;
            this.Lbl_Idade.Location = new System.Drawing.Point(6, 93);
            this.Lbl_Idade.Name = "Lbl_Idade";
            this.Lbl_Idade.Size = new System.Drawing.Size(44, 18);
            this.Lbl_Idade.TabIndex = 2;
            this.Lbl_Idade.Text = "Idade";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bairro.ForeColor = System.Drawing.Color.White;
            this.Lbl_Bairro.Location = new System.Drawing.Point(6, 122);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Bairro.TabIndex = 3;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Lbl_Celular
            // 
            this.Lbl_Celular.AutoSize = true;
            this.Lbl_Celular.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Celular.ForeColor = System.Drawing.Color.White;
            this.Lbl_Celular.Location = new System.Drawing.Point(6, 151);
            this.Lbl_Celular.Name = "Lbl_Celular";
            this.Lbl_Celular.Size = new System.Drawing.Size(54, 18);
            this.Lbl_Celular.TabIndex = 4;
            this.Lbl_Celular.Text = "Celular";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.ForeColor = System.Drawing.Color.White;
            this.Lbl_Email.Location = new System.Drawing.Point(6, 178);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(58, 18);
            this.Lbl_Email.TabIndex = 5;
            this.Lbl_Email.Text = "E -mail";
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Resultado.Location = new System.Drawing.Point(4, 295);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(71, 18);
            this.Lbl_Resultado.TabIndex = 7;
            this.Lbl_Resultado.Text = "Resultado";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.ForeColor = System.Drawing.Color.Black;
            this.Txt_Nome.Location = new System.Drawing.Point(82, 28);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(237, 20);
            this.Txt_Nome.TabIndex = 8;
            // 
            // Txt_Sobrenome
            // 
            this.Txt_Sobrenome.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Sobrenome.ForeColor = System.Drawing.Color.Black;
            this.Txt_Sobrenome.Location = new System.Drawing.Point(82, 58);
            this.Txt_Sobrenome.Name = "Txt_Sobrenome";
            this.Txt_Sobrenome.Size = new System.Drawing.Size(237, 20);
            this.Txt_Sobrenome.TabIndex = 9;
            // 
            // Txt_Idade
            // 
            this.Txt_Idade.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Idade.ForeColor = System.Drawing.Color.Black;
            this.Txt_Idade.Location = new System.Drawing.Point(82, 88);
            this.Txt_Idade.MaxLength = 3;
            this.Txt_Idade.Name = "Txt_Idade";
            this.Txt_Idade.Size = new System.Drawing.Size(237, 20);
            this.Txt_Idade.TabIndex = 10;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Bairro.ForeColor = System.Drawing.Color.Black;
            this.Txt_Bairro.Location = new System.Drawing.Point(82, 118);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(237, 20);
            this.Txt_Bairro.TabIndex = 11;
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Celular.ForeColor = System.Drawing.Color.Black;
            this.Txt_Celular.Location = new System.Drawing.Point(82, 148);
            this.Txt_Celular.MaxLength = 19;
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(237, 20);
            this.Txt_Celular.TabIndex = 12;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.ForeColor = System.Drawing.Color.Black;
            this.Txt_Email.Location = new System.Drawing.Point(82, 178);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(237, 20);
            this.Txt_Email.TabIndex = 13;
            // 
            // Btn_Nome
            // 
            this.Btn_Nome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nome.ForeColor = System.Drawing.Color.Black;
            this.Btn_Nome.Location = new System.Drawing.Point(326, 30);
            this.Btn_Nome.Name = "Btn_Nome";
            this.Btn_Nome.Size = new System.Drawing.Size(74, 23);
            this.Btn_Nome.TabIndex = 14;
            this.Btn_Nome.Text = "Enviar";
            this.Btn_Nome.UseVisualStyleBackColor = true;
            this.Btn_Nome.Click += new System.EventHandler(this.Btn_Nome_Click);
            // 
            // Btn_Sobrenome
            // 
            this.Btn_Sobrenome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sobrenome.ForeColor = System.Drawing.Color.Black;
            this.Btn_Sobrenome.Location = new System.Drawing.Point(326, 60);
            this.Btn_Sobrenome.Name = "Btn_Sobrenome";
            this.Btn_Sobrenome.Size = new System.Drawing.Size(74, 23);
            this.Btn_Sobrenome.TabIndex = 15;
            this.Btn_Sobrenome.Text = "Enviar";
            this.Btn_Sobrenome.UseVisualStyleBackColor = true;
            this.Btn_Sobrenome.Click += new System.EventHandler(this.Btn_Sobrenome_Click);
            // 
            // Btn_Idade
            // 
            this.Btn_Idade.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Idade.ForeColor = System.Drawing.Color.Black;
            this.Btn_Idade.Location = new System.Drawing.Point(326, 90);
            this.Btn_Idade.Name = "Btn_Idade";
            this.Btn_Idade.Size = new System.Drawing.Size(75, 23);
            this.Btn_Idade.TabIndex = 16;
            this.Btn_Idade.Text = "Enviar";
            this.Btn_Idade.UseVisualStyleBackColor = true;
            this.Btn_Idade.Click += new System.EventHandler(this.Btn_Idade_Click);
            // 
            // Btn_Bairro
            // 
            this.Btn_Bairro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Bairro.ForeColor = System.Drawing.Color.Black;
            this.Btn_Bairro.Location = new System.Drawing.Point(326, 120);
            this.Btn_Bairro.Name = "Btn_Bairro";
            this.Btn_Bairro.Size = new System.Drawing.Size(74, 23);
            this.Btn_Bairro.TabIndex = 17;
            this.Btn_Bairro.Text = "Enviar";
            this.Btn_Bairro.UseVisualStyleBackColor = true;
            this.Btn_Bairro.Click += new System.EventHandler(this.Btn_Bairro_Click);
            // 
            // Btn_Celular
            // 
            this.Btn_Celular.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Celular.ForeColor = System.Drawing.Color.Black;
            this.Btn_Celular.Location = new System.Drawing.Point(326, 150);
            this.Btn_Celular.Name = "Btn_Celular";
            this.Btn_Celular.Size = new System.Drawing.Size(74, 26);
            this.Btn_Celular.TabIndex = 18;
            this.Btn_Celular.Text = "Enviar";
            this.Btn_Celular.UseVisualStyleBackColor = true;
            this.Btn_Celular.Click += new System.EventHandler(this.Btn_Celular_Click);
            // 
            // Btn_Email
            // 
            this.Btn_Email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Email.ForeColor = System.Drawing.Color.Black;
            this.Btn_Email.Location = new System.Drawing.Point(326, 183);
            this.Btn_Email.Name = "Btn_Email";
            this.Btn_Email.Size = new System.Drawing.Size(75, 23);
            this.Btn_Email.TabIndex = 19;
            this.Btn_Email.Text = "Enviar";
            this.Btn_Email.UseVisualStyleBackColor = true;
            this.Btn_Email.Click += new System.EventHandler(this.Btn_Email_Click);
            // 
            // Btn_Enviar_Tudo
            // 
            this.Btn_Enviar_Tudo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar_Tudo.ForeColor = System.Drawing.Color.Black;
            this.Btn_Enviar_Tudo.Location = new System.Drawing.Point(325, 244);
            this.Btn_Enviar_Tudo.Name = "Btn_Enviar_Tudo";
            this.Btn_Enviar_Tudo.Size = new System.Drawing.Size(75, 53);
            this.Btn_Enviar_Tudo.TabIndex = 20;
            this.Btn_Enviar_Tudo.Text = "Enviar Tudo";
            this.Btn_Enviar_Tudo.UseVisualStyleBackColor = true;
            this.Btn_Enviar_Tudo.Click += new System.EventHandler(this.Btn_Enviar_Tudo_Click);
            // 
            // Lbl_Genero
            // 
            this.Lbl_Genero.AutoSize = true;
            this.Lbl_Genero.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Genero.ForeColor = System.Drawing.Color.White;
            this.Lbl_Genero.Location = new System.Drawing.Point(6, 213);
            this.Lbl_Genero.Name = "Lbl_Genero";
            this.Lbl_Genero.Size = new System.Drawing.Size(53, 18);
            this.Lbl_Genero.TabIndex = 21;
            this.Lbl_Genero.Text = "Gênero";
            // 
            // Txt_Genero
            // 
            this.Txt_Genero.Enabled = false;
            this.Txt_Genero.Location = new System.Drawing.Point(82, 213);
            this.Txt_Genero.Name = "Txt_Genero";
            this.Txt_Genero.Size = new System.Drawing.Size(237, 25);
            this.Txt_Genero.TabIndex = 22;
            // 
            // Btn_Genero
            // 
            this.Btn_Genero.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Genero.ForeColor = System.Drawing.Color.Black;
            this.Btn_Genero.Location = new System.Drawing.Point(325, 213);
            this.Btn_Genero.Name = "Btn_Genero";
            this.Btn_Genero.Size = new System.Drawing.Size(75, 23);
            this.Btn_Genero.TabIndex = 23;
            this.Btn_Genero.Text = "Enviar";
            this.Btn_Genero.UseVisualStyleBackColor = true;
            this.Btn_Genero.Click += new System.EventHandler(this.Btn_Genero_Click);
            // 
            // Pic_Homen
            // 
            this.Pic_Homen.Location = new System.Drawing.Point(0, 363);
            this.Pic_Homen.Name = "Pic_Homen";
            this.Pic_Homen.Size = new System.Drawing.Size(111, 90);
            this.Pic_Homen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Homen.TabIndex = 24;
            this.Pic_Homen.TabStop = false;
            // 
            // Pic_Mulher
            // 
            this.Pic_Mulher.Location = new System.Drawing.Point(166, 363);
            this.Pic_Mulher.Name = "Pic_Mulher";
            this.Pic_Mulher.Size = new System.Drawing.Size(110, 84);
            this.Pic_Mulher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Mulher.TabIndex = 25;
            this.Pic_Mulher.TabStop = false;
            // 
            // Pic_Outro
            // 
            this.Pic_Outro.Location = new System.Drawing.Point(332, 363);
            this.Pic_Outro.Name = "Pic_Outro";
            this.Pic_Outro.Size = new System.Drawing.Size(126, 83);
            this.Pic_Outro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Outro.TabIndex = 26;
            this.Pic_Outro.TabStop = false;
            // 
            // Rad_Homem
            // 
            this.Rad_Homem.AutoSize = true;
            this.Rad_Homem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Homem.ForeColor = System.Drawing.Color.Black;
            this.Rad_Homem.Location = new System.Drawing.Point(6, 339);
            this.Rad_Homem.Name = "Rad_Homem";
            this.Rad_Homem.Size = new System.Drawing.Size(76, 22);
            this.Rad_Homem.TabIndex = 27;
            this.Rad_Homem.TabStop = true;
            this.Rad_Homem.Text = "Homem";
            this.Rad_Homem.UseVisualStyleBackColor = true;
            this.Rad_Homem.CheckedChanged += new System.EventHandler(this.Rad_Homem_CheckedChanged);
            // 
            // Rad_Mulher
            // 
            this.Rad_Mulher.AutoSize = true;
            this.Rad_Mulher.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Mulher.ForeColor = System.Drawing.Color.Black;
            this.Rad_Mulher.Location = new System.Drawing.Point(166, 340);
            this.Rad_Mulher.Name = "Rad_Mulher";
            this.Rad_Mulher.Size = new System.Drawing.Size(74, 22);
            this.Rad_Mulher.TabIndex = 28;
            this.Rad_Mulher.TabStop = true;
            this.Rad_Mulher.Text = "Mulher";
            this.Rad_Mulher.UseVisualStyleBackColor = true;
            this.Rad_Mulher.CheckedChanged += new System.EventHandler(this.Rad_Mulher_CheckedChanged);
            // 
            // Rad_Outro
            // 
            this.Rad_Outro.AutoSize = true;
            this.Rad_Outro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Outro.ForeColor = System.Drawing.Color.Black;
            this.Rad_Outro.Location = new System.Drawing.Point(343, 340);
            this.Rad_Outro.Name = "Rad_Outro";
            this.Rad_Outro.Size = new System.Drawing.Size(62, 22);
            this.Rad_Outro.TabIndex = 29;
            this.Rad_Outro.TabStop = true;
            this.Rad_Outro.Text = "Outro";
            this.Rad_Outro.UseVisualStyleBackColor = true;
            this.Rad_Outro.CheckedChanged += new System.EventHandler(this.Rad_Outro_CheckedChanged);
            // 
            // Grp_Dados
            // 
            this.Grp_Dados.BackColor = System.Drawing.Color.Transparent;
            this.Grp_Dados.Controls.Add(this.Rad_Outro);
            this.Grp_Dados.Controls.Add(this.Rad_Mulher);
            this.Grp_Dados.Controls.Add(this.Rad_Homem);
            this.Grp_Dados.Controls.Add(this.Pic_Outro);
            this.Grp_Dados.Controls.Add(this.Pic_Mulher);
            this.Grp_Dados.Controls.Add(this.Pic_Homen);
            this.Grp_Dados.Controls.Add(this.Btn_Genero);
            this.Grp_Dados.Controls.Add(this.Txt_Genero);
            this.Grp_Dados.Controls.Add(this.Lbl_Genero);
            this.Grp_Dados.Controls.Add(this.Btn_Enviar_Tudo);
            this.Grp_Dados.Controls.Add(this.Btn_Email);
            this.Grp_Dados.Controls.Add(this.Btn_Celular);
            this.Grp_Dados.Controls.Add(this.Btn_Bairro);
            this.Grp_Dados.Controls.Add(this.Btn_Idade);
            this.Grp_Dados.Controls.Add(this.Btn_Sobrenome);
            this.Grp_Dados.Controls.Add(this.Btn_Nome);
            this.Grp_Dados.Controls.Add(this.Txt_Email);
            this.Grp_Dados.Controls.Add(this.Txt_Celular);
            this.Grp_Dados.Controls.Add(this.Txt_Bairro);
            this.Grp_Dados.Controls.Add(this.Txt_Idade);
            this.Grp_Dados.Controls.Add(this.Txt_Sobrenome);
            this.Grp_Dados.Controls.Add(this.Txt_Nome);
            this.Grp_Dados.Controls.Add(this.Lbl_Resultado);
            this.Grp_Dados.Controls.Add(this.Lbl_Confirmacao);
            this.Grp_Dados.Controls.Add(this.Lbl_Email);
            this.Grp_Dados.Controls.Add(this.Lbl_Celular);
            this.Grp_Dados.Controls.Add(this.Lbl_Bairro);
            this.Grp_Dados.Controls.Add(this.Lbl_Idade);
            this.Grp_Dados.Controls.Add(this.Lbl_Sobrenome);
            this.Grp_Dados.Controls.Add(this.Lbl_Nome);
            this.Grp_Dados.Enabled = false;
            this.Grp_Dados.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Dados.ForeColor = System.Drawing.Color.Red;
            this.Grp_Dados.Location = new System.Drawing.Point(12, 197);
            this.Grp_Dados.Name = "Grp_Dados";
            this.Grp_Dados.Size = new System.Drawing.Size(532, 453);
            this.Grp_Dados.TabIndex = 0;
            this.Grp_Dados.TabStop = false;
            this.Grp_Dados.Text = "Dados Pessoais";
            // 
            // Lbl_Confirmacao
            // 
            this.Lbl_Confirmacao.AutoSize = true;
            this.Lbl_Confirmacao.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Confirmacao.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Confirmacao.Location = new System.Drawing.Point(4, 269);
            this.Lbl_Confirmacao.Name = "Lbl_Confirmacao";
            this.Lbl_Confirmacao.Size = new System.Drawing.Size(160, 18);
            this.Lbl_Confirmacao.TabIndex = 6;
            this.Lbl_Confirmacao.Text = "Confirmação dos Dados";
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Cadastro.Properties.Resources.one_piece;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1253, 662);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Desativar);
            this.Controls.Add(this.Btn_Ativar);
            this.Controls.Add(this.Grp_Temas);
            this.Controls.Add(this.Grp_Dados);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Abertura_FormClosed);
            this.Grp_Temas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Homen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Mulher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Outro)).EndInit();
            this.Grp_Dados.ResumeLayout(false);
            this.Grp_Dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Desativar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Ativar;
        private System.Windows.Forms.RadioButton Rad_Padrao;
        private System.Windows.Forms.RadioButton Rad_T1;
        private System.Windows.Forms.RadioButton Rad_T2;
        private System.Windows.Forms.RadioButton Rad_T3;
        private System.Windows.Forms.GroupBox Grp_Temas;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Sobrenome;
        private System.Windows.Forms.Label Lbl_Idade;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Celular;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Sobrenome;
        private System.Windows.Forms.TextBox Txt_Idade;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.TextBox Txt_Celular;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Button Btn_Nome;
        private System.Windows.Forms.Button Btn_Sobrenome;
        private System.Windows.Forms.Button Btn_Idade;
        private System.Windows.Forms.Button Btn_Bairro;
        private System.Windows.Forms.Button Btn_Celular;
        private System.Windows.Forms.Button Btn_Email;
        private System.Windows.Forms.Button Btn_Enviar_Tudo;
        private System.Windows.Forms.Label Lbl_Genero;
        private System.Windows.Forms.TextBox Txt_Genero;
        private System.Windows.Forms.Button Btn_Genero;
        private System.Windows.Forms.PictureBox Pic_Homen;
        private System.Windows.Forms.PictureBox Pic_Mulher;
        private System.Windows.Forms.PictureBox Pic_Outro;
        private System.Windows.Forms.RadioButton Rad_Homem;
        private System.Windows.Forms.RadioButton Rad_Mulher;
        private System.Windows.Forms.RadioButton Rad_Outro;
        private System.Windows.Forms.GroupBox Grp_Dados;
        private System.Windows.Forms.Label Lbl_Confirmacao;
    }
}

