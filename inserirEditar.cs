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
    public partial class inserirEditar : Form
    {
        int indice;

        //=================================================================================
        public inserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }

        //=================================================================================
        private void fechar_Click(object sender, EventArgs e)
        {
            // fechar quadro
            this.Close();
        }

        //=================================================================================
        private void inserirEditar_Load(object sender, EventArgs e)
        {
            // Evento Load do Form
        }

        //=================================================================================
        private void ConstroiLista()
        {
            // adicionar a lista de contatos aos registrados
            lista_contatos.Items.Clear();

            foreach (contato contato in cl_geral.LISTA_CONTATOS)
            {
                lista_contatos.Items.Add(contato.nome + "(" + contato.numero + ")");
            }

            // atualiza o numero de registros
            numero_registros.Text = "Registros: " + lista_contatos.Items.Count;

            // impedir edição e eliminação do registro
            Apagar.Enabled = false;
            editar.Enabled = false;
        }

        //=================================================================================
        private void gravar_Click(object sender, EventArgs e)
        {
            // insere novo registro na lista

            // verifica se todos os campos estão preenchidos
            if (text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("Os campos não estão todos preenchidos.");
                return;
            }

            // verifica se existe registro igual
            foreach (contato contato in cl_geral.LISTA_CONTATOS)
            {
                if (contato.nome == text_nome.Text && contato.numero == text_numero.Text)
                {
                    MessageBox.Show("ERRO! Esse registro já existe.");
                    return;
                }
            }

            // gravar novo registro
            cl_geral.GravarNovoRegistro(text_nome.Text, text_numero.Text);

            // atualizar lista de contatos
            ConstroiLista();

            // preparar o quadro para o novo registro
            text_nome.Text = "";
            text_numero.Text = "";
            text_nome.Focus();
        }

        //=================================================================================
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // verifica se o índice é -1
            if (lista_contatos.SelectedIndex == -1) return;

            // seleciona um índice
            indice = lista_contatos.SelectedIndex;
            editar.Enabled = true;
            Apagar.Enabled = true;
        }

        //=================================================================================
        private void Apagar_Click(object sender, EventArgs e)
        {
            // apaga o registro selecionado

            // 1 - eliminar registro
            cl_geral.LISTA_CONTATOS.RemoveAt(indice);

            // 2 - renovar o ficheiro
            cl_geral.GravarFicheiro();

            // 3 - reconstruir lista
            ConstroiLista();
        }
    }
}
