using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

            //carrega os contatos
            cl_geral.ConstroiListaContatos();

            //apresenta versao do programa
            label_versao.Text = cl_geral.versao;

        }

        private void SAIR_Click(object sender, EventArgs e)
        {
            //sair da aplicação?

            //perguntar se pretende mesmo sair
            if (MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void PESQUISAR_Click(object sender, EventArgs e)
        {

        }

        private void INSERIR_Click(object sender, EventArgs e)
        {
            //abre o quadro para gestão dos contatos
            inserirEditar formulario = new inserirEditar();
            formulario.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
