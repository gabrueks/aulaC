using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Contatos
    {
        public List<Contato> listaContatos { get; }

        public Contatos()
        {
            listaContatos = new List<Contato>();
        }

        public Contatos(List<Contato> receivedList)
        {
            this.listaContatos = receivedList;
        }

        public void incluir(Contato c)
        {
            listaContatos.Add(c);
        }

        public void alterar(Contato c)
        {
            foreach (var contact in this.listaContatos)
            {
                if (contact.Equals(c.email))
                {
                    contact.email = c.email;
                    contact.nome = c.nome;
                    contact.fone = c.fone;
                }
            }
        }

        public bool excluir(Contato c)
        {
            foreach (var contact in this.listaContatos)
            {
                if (contact.Equals(c.email))
                {
                    this.listaContatos.Remove(contact);
                    return true;
                }
            }
            return false;
        }

        public Contato pesquisar(Contato c)
        {
            if (this.listaContatos.Any(x => x.Equals(c.email)))
            {
                return this.listaContatos.First(x => x.Equals(c.email));
            }

            return null;
        }
    }
}
