using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public void AdicionarItens(Tarefa tarefaSelecionada, List<Itens> itens)
        {
            foreach (Itens item in itens)
                tarefaSelecionada.AdicionarItem(item);
        }

        public void AtualizarItens(Tarefa tarefaSelecionada, List<Itens> itensPendentes, List<Itens> itensConcluidos)
        {
            foreach (Itens i in itensPendentes)
                tarefaSelecionada.MarcarPendente(i);

            foreach (Itens i in itensConcluidos)
                tarefaSelecionada.ConcluirItem(i);
        }
    }
}
