using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace agenda
{
    public static class cl_geral
    {
        public static string versao = "v1.0.0";

        //lista de contatos
        public static List<contato> LISTA_CONTATOS;

        //=================================================================================
        public static void ConstroiListaContatos()
        {
            //metodo para carregamento da lista de contatos

            //verificar se o ficheiro existe
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

            //cria a lista vazia
            LISTA_CONTATOS = new List<contato>();


            if (File.Exists(nome_ficheiro))
            {
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
                
                while (!ficheiro.EndOfStream)
                {
                    //carrega nome
                    string nome = ficheiro.ReadLine();
                    //carrega numero
                    string numero = ficheiro.ReadLine();

                    //adicionar a lista o contato carregado
                    contato novo_contato = new contato();
                    novo_contato.nome = nome;
                    novo_contato.numero = numero;
                    LISTA_CONTATOS.Add(novo_contato);
                }
                ficheiro.Dispose();
            }

        }

        //=================================================================================
        public static void GravarNovoRegistro(string _nome, string _numero)
        {
            //gravar um novo registro (na lista e no ficheiro)

            //gravar na lista
            LISTA_CONTATOS.Add(new contato() { nome = _nome, numero = _numero });

            //att o ficheiro
            GravarFicheiro();
        }
        //=================================================================================
        public static void GravarFicheiro()
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

            StreamWriter ficheiro = new StreamWriter(nome_ficheiro,false, Encoding.Default);
            foreach(contato contato in LISTA_CONTATOS)
            {
                ficheiro.WriteLine(contato.nome);
                ficheiro.WriteLine(contato.numero);
            }
            ficheiro.Dispose();
        }
    }

}
