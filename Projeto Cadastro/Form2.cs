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
    public partial class Frm_Confirmacao : Form
    {
        public Frm_Confirmacao()
        {
            InitializeComponent();
        }
        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro(); // instanciando um objeto cadastro que serve para chamar a tela cadastro
            cadastro.Show(); //abrindo a tela cadastro
            Close(); //fechando a tela confirmação

        }

        private void Frm_Confirmacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
