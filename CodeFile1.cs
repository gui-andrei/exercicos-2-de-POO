namespace ex1
{
    class jogo
    {
        private int id;
        private DateTime lancamento;
        private string nome;
        private string categoria;

        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                    throw new Exception("id tem que ser maior que zero");
                else { id = value; }

            }
        }
        public DateTime Lancamento
        {
            get => lancamento;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("jogo nao lançado");
                }

                else { lancamento = value; }
            }
        }
        public string Nome
        {
            get => nome;
            set
            {
                if (value.Length < 2)
                    throw new Exception("o nome precisa ter no minino 2 caracteres");
                else { nome = value; }
            }
        }



        public string Categoria
        {
            get => categoria;
            set
            {
                if (value != "ação" || value != "Esporte" || value != "luta" || value != "tiro")
                {
                    throw new Exception("válido apenas categoria de “ação”  “luta” “tiro” e “Esporte”");
                }
                else { categoria = value; }
            }
        }

        public override string ToString()
        {
            return "\nId do carro " + id + "\n nome " + nome + "\ncategoria " + categoria + "\ndata de lançamento" + lancamento;
        }
    }
}