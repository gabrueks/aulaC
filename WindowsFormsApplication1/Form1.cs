using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Contatos contacts { get; set; }
        public Form1()
        {
            InitializeComponent();
            contacts = new Contatos();
        }       private void label1_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {
            Contato novoContato = new Contato(email.Text, nome.Text, fone.Text);
            if(contacts.pesquisar(novoContato) == null)
            {
                this.contacts.incluir(novoContato);
            } else
            {
                contacts.alterar(novoContato);
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(new String[3] {
                    novoContato.email,
                    novoContato.nome,
                    novoContato.fone
                });
            }
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            Contato novoContato = new Contato(email.Text, nome.Text, fone.Text);
            if(this.contacts.pesquisar(novoContato) == null)
            {
                label4.Text = "Usuário não encontrado.";
            } else
            {
                this.nome.Text = novoContato.nome;
                this.fone.Text = novoContato.fone;
                this.email.Text = novoContato.email;
                label4.Text = "Usuário existente!";
            }
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            Contato novoContato = new Contato(email.Text, nome.Text, fone.Text);
            if (this.contacts.excluir(novoContato))
            {
                this.isDeleted.Text = "Deletado com sucesso";
            } else
            {
                this.isDeleted.Text = "Impossibilidade de apagar, opis o usuário não foi encontrado";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach(var x in contacts.listaContatos)
            {
                dataGridView1.Rows.Add(new String[3] {
                    x.email,
                    x.nome,
                    x.fone
                });
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.email.Text = "";
            this.nome.Text = "";
            this.fone.Text = "";
        }
    }
}
