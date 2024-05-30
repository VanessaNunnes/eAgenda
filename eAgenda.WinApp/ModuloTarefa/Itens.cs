namespace eAgenda.WinApp.ModuloTarefa
{
    public class Itens
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public bool Concluido { get; set; }
        public Tarefa Tarefa { get; set; }

        public Itens(string titulo)
        {
            this.Titulo = titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        public void MarcarPendente()
        {
            Concluido = false;
        }

        public override string ToString()
        {
            return $"{Titulo}";
        }
    }
}
