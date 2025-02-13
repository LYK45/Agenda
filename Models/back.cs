namespace Funcoes.Models
{
    public class Contatos
    {
        private string nome = "";
        private string sobrenome = "";
        private string telefone = "";
        public List<Contatos> agenda = new List<Contatos>();

        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Contatos(string nome, string sobrenome, string telefone)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
        }

          // Método para exibir as informações do contato
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Telefone: {telefone}");
        }

    }

}
