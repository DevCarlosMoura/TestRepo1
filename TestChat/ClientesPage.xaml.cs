
using System.Threading.Tasks;

namespace TestChat
{
    public partial class ClientesPage : ContentPage
    {

        public ClientesPage()
        {
            InitializeComponent();
        }

        private async Task OnAddClienteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientesPage());
        }
        public class async { Task DeletarItemPorId(int idParaDeletar)
        {
            object? clientes = null;
            var clienteEncontrado = clientes.FirstOrDefault(cliente => cliente.Id == idParaDeletar);

            if (clienteEncontrado != null)
            {
                clientes.Remove(clienteEncontrado);
                Console.WriteLine($"Item com ID {idParaDeletar} deletado.");
                return true;
            }
            else
            {
                Console.WriteLine($"Item com ID {idParaDeletar} não encontrado.");
                return false;
            }
        }

    }
}