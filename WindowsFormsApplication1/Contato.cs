using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Contato : Object
    {
        public string email { get; set; } 
        public string nome { get; set; }
        public string fone { get; set; }

        public Contato(string receivedEmail, string receivedNome, string receivedFone)
        {
            this.email = receivedEmail;
            this.nome = receivedNome;
            this.fone = receivedFone;
        }

        public Contato()
        {

        }

        public bool Equals(string expectedString)
        {
            return (expectedString == this.email);
        }
    }
}
