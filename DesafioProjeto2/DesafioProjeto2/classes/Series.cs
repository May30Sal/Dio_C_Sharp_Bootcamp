namespace DesafioProjeto2.classes
{
    public class Series : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string? Titulo { get; set; }

        private string? Descricao { get; set; }

        private bool Excluido { get; set; }

        //Métodos
        public Series(int Id, Genero Genero, string? Titulo, string? Descricao)
        {
            this.Id = Id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Id:" + this.Id + Environment.NewLine; 
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string? retornaTitulo()
        {
            return this.Titulo;
        }

         public int? retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}