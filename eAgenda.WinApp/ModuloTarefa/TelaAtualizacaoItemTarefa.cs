namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizacaoItemTarefa : Form
    {
        public List<Itens> ItensPendentes
        {
            get
            {
                return listItensTarefa.Items
                    .Cast<Itens>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        public List<Itens> ItensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems
                    .Cast<Itens>().ToList();
            }
        }

        public TelaAtualizacaoItemTarefa(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            labelTituloTarefa.Text = tarefaSelecionada.Titulo;

            CarregarItensSelecionados(tarefaSelecionada);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void CarregarItensSelecionados(Tarefa tarefaSelecionada)
        {
            int i = 0;

            foreach (Itens item in tarefaSelecionada.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.Concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }
    }
}
