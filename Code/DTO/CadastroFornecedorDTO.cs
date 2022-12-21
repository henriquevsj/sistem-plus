namespace SistemPlus.Code.DTO
{
    public class CadastroFornecedorDTO
    {
        private int id;
        private string nome;
        private int telefone;
        private string empresa;
        private string email;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Email { get => email; set => email = value; }
    }
}
