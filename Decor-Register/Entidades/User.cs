namespace Decor_Register.Entidades
{
    class User
    {
        private string id;
        private byte[] imagem;
        private string codigo;
        private string produto;
        private string valor;
        private string categoria;
        private string descricao;

        public string ID { get => id; set => id = value; }
        public byte[] Imagem { get => imagem; set => imagem = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Produto { get => produto; set => produto = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Descricao { get => descricao; set => descricao = value; }

    }
}
