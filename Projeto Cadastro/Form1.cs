using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cadastro
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

     

        private void Rad_Padrao_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.cuphead; //ativar imagem de fundo padrão
            Rad_Padrao.ForeColor = Color.Red; //mudar a cor da opção padão
            Rad_T1.ForeColor = Color.White; //voltando a cor do tema 1 pra preto
            Rad_T2.ForeColor = Color.White; //voltando a cor do tema 2 pra preto
            Rad_T3.ForeColor = Color.White; //voltando a cor do tema 3 pra preto
            Rad_Homem.ForeColor = Color.White; //Força a cor do rad homem para branco em qualquer tema
            Rad_Mulher.ForeColor = Color.White; //Força a cor do rad mulher para branco em qualquer tema
            Rad_Outro.ForeColor = Color.White;//Força a cor do rad outro para branco em qualquer tema
            Lbl_Confirmacao.ForeColor = Color.White;//Força a cor do lbl corfimacao para branco em qualquer tema
            Lbl_Resultado.ForeColor = Color.White; //Força a cor do lbl resultado para branco em qualquer tema
        }

        private void Rad_T1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.knight; //ativar a imagem do tema 1
            Rad_T1.ForeColor = Color.Red; //trocando a opção do tema 1
            Rad_Padrao.ForeColor = Color.White; //voltando a opção padrão para cor preto
            Rad_T2.ForeColor = Color.White; //voltando a cor do tema 2 pra preto
            Rad_T3.ForeColor = Color.White; //voltando a cor do tema 3 pra preto
            Rad_Homem.ForeColor = Color.White; //Força a cor do rad homem para branco em qualquer tema
            Rad_Mulher.ForeColor = Color.White;  //Força a cor do rad mulher para branco em qualquer tema
            Rad_Outro.ForeColor = Color.White; //Força a cor do rad outro para branco em qualquer tema
            Lbl_Confirmacao.ForeColor = Color.White; //Força a cor do lbl corfimacao para branco em qualquer tema
            Lbl_Resultado.ForeColor = Color.White; //Força a cor do lbl resultado para branco em qualquer tema
        }

        private void Rad_T2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.one_piece; //ativar a imagem do tema 2
            Rad_T2.ForeColor = Color.Red; //trocando a cor da imagem do tema 2
            Rad_Padrao.ForeColor = Color.White; //voltando a cor do tema padão pra preto
            Rad_T1.ForeColor = Color.White; //voltando a cor do tema 1 pra preto
            Rad_T3.ForeColor = Color.White; //voltando a cor do tema 3 pra preto
            Rad_Homem.ForeColor = Color.White; //Força a cor do rad homem para branco em qualquer tema
            Rad_Mulher.ForeColor = Color.White; //Força a cor do rad mulher para branco em qualquer tema
            Rad_Outro.ForeColor = Color.White; //Força a cor do rad outro para branco em qualquer tema
            Lbl_Confirmacao.ForeColor = Color.White; //Força a cor do lbl corfimacao para branco em qualquer tema
            Lbl_Resultado.ForeColor = Color.White; //Força a cor do lbl resultado para branco em qualquer tema
        }

        private void Rad_T3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.timao; //ativar a imagem do tema 3
            Rad_T3.ForeColor = Color.Red; //trocando a cor da imagem do tema 3
            Rad_Padrao.ForeColor = Color.White; //voltando a cor do tema padrão pra preto
            Rad_T1.ForeColor = Color.White; //voltando a cor do tema 1 pra preto
            Rad_T2.ForeColor = Color.White; //voltando a cor do tema 2 pra preto
            Rad_Homem.ForeColor = Color.White; //Força a cor do rad homem pra branco
            Rad_Mulher.ForeColor = Color.White; //Força a cor do rad mulher pra branco
            Rad_Outro.ForeColor = Color.White; //Força a cor do rad outro pra branco
            Lbl_Confirmacao.ForeColor = Color.White; //Força a cor do lbl corfimacao pra branco
            Lbl_Resultado.ForeColor = Color.White; //Força a cor do lbl resultado pra branco
        }

        private void Btn_Nome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Nome.Text; //configura o botão enviar nome
        }

        private void Btn_Sobrenome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Sobrenome.Text; //configura o botão enviar sobrenome
        }

        private void Btn_Idade_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Idade.Text; //configura o botão enviar Idade
        }

        private void Btn_Bairro_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Bairro.Text; //configura o botão enviar bairro
        }

        private void Btn_Celular_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Celular.Text; //configura o botão enviar Celular
        }

        private void Btn_Email_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Email.Text; //configura o botão enviar email
        }

        private void Btn_Genero_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Genero.Text; //configura o botão enviar genero
        }

        private void Rad_Homem_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Homen.Image = Properties.Resources.homem; //apertar um botão e carregar a imagem do homem
            Pic_Mulher.Visible = false; //não mostrar a imagem da mulher
            Pic_Outro.Visible = false; //não mostrar a imagem do outro
            Pic_Homen.Visible = true; //Mostrar a imagem do homem
            Txt_Genero.Text = Rad_Homem.Text; //colocar a opção homem no texto de genero
        }

        private void Rad_Mulher_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Mulher.Image = Properties.Resources.mulher; //apertar um botão e carregar a imagem da Mulher
            Pic_Mulher.Visible = true; //mostrar a imagem da mulher
            Pic_Homen.Visible = false; //não mostar a imagem do homem
            Pic_Outro.Visible = false; //não mostar a imagem do outro
            Txt_Genero.Text = Rad_Mulher.Text; //colocar a opção mulher no texto de genero
        }

        private void Rad_Outro_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Outro.Image = Properties.Resources.helicoptero_de_combate; //apertar um botão e carregar a imagem do outro
            Pic_Mulher.Visible = false; //não mostrar a imagem da mulher
            Pic_Homen.Visible = false; //não mostrar a imagem do homem
            Pic_Outro.Visible = true; //mostrar a imagem do outro
            Txt_Genero.Text = Rad_Outro.Text;//colocar a opção outro no texto de genero
        }

        private void Btn_Ativar_Click(object sender, EventArgs e)
        {
            Grp_Temas.Enabled = true; //ativar o grupo temas
            Grp_Dados.Enabled = true; //ativar o grupo dados
            Btn_Ativar.Enabled = false; //desativa o botão ativar
            Btn_Desativar.Enabled = true; //ativa o botão desativar
            Btn_Limpar.Enabled = true; //ativa o botão limpar
        }

        private void Btn_Desativar_Click(object sender, EventArgs e)
        {
            Grp_Temas.Enabled = false; //desativa o grupo temas
            Grp_Dados.Enabled = false; //desativa o grupo dados
            Btn_Ativar.Enabled = true; //ativa o botão ativar
            Btn_Desativar.Enabled = false; //desativa o botão desativar
            Btn_Limpar.Enabled = false; //desativa o botão limpar
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Controls.Clear(); //Limpar tudo liralmente 
            InitializeComponent(); //inicializar todos os componetes
        }

        private void Btn_Enviar_Tudo_Click(object sender, EventArgs e)
        {
            Frm_Confirmacao confirmacao = new Frm_Confirmacao(); //instanciando ( criando ) um objeto confirmacao que serve para chamar a próxima tela
            confirmacao.Lbl_Resultado2.Text = Txt_Nome.Text + " " + Txt_Sobrenome.Text + " \n" + Txt_Idade.Text + " anos" + "\n\n"+ Txt_Bairro.Text +"\n\n" + Txt_Celular.Text + "\n\n" + Txt_Email.Text + "\n\n" + Txt_Genero.Text; //enviando o nome e sobrenome digitado com espaço da telande cadastro para a tela de confirmação
            confirmacao.BackgroundImage = BackgroundImage;
            confirmacao.Show(); //abrindo a tela de confirmação
            Hide(); //ocultar o form1 ( tela de cadastro )
        }

        private void Frm_Abertura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}