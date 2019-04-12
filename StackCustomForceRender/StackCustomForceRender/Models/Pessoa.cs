using System.Windows.Input;

namespace StackCustomForceRender.Models
{
    public class Pessoa
    {
        public int Contador { get; set; }
        public string Nome { get; set; }
        public ICommand DefinirLayoutCommand { get; set; }
        public ICommand AdicionarItemCommand { get; set; }
    }
}
