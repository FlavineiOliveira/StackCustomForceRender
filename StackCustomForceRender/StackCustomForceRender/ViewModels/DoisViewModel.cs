using StackCustomForceRender.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StackCustomForceRender.ViewModels
{
    public class DoisViewModel : ViewModelBase
    {
        private StackLayout _layoutAtual;

        private string _textoHeader;

        public string TextoHeader
        {
            get { return _textoHeader; }
            set {
                _textoHeader = value;
                OnPropertyChanged();
            }
        }

        private string _textoFooter;

        public string TextoFooter
        {
            get { return _textoFooter; }
            set {
                _textoFooter = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Pessoa> _pessoas;

        public ObservableCollection<Pessoa> Pessoas
        {
            get { return _pessoas; }
            set { 
                _pessoas = value;
                OnPropertyChanged();
             }
        }

        private ObservableCollection<string> _documentos;

        public ObservableCollection<string> Documentos
        {
            get { return _documentos; }
            set
            {
                _documentos = value;
                OnPropertyChanged();
            }
        }

        private ICommand _adicionarItemCommand;

        public ICommand AdicionarItemCommand
        {
            get { return _adicionarItemCommand; }
            set
            {
                _adicionarItemCommand = value;
                OnPropertyChanged();
            }
        }

        private ICommand _definirLayoutCommand;

        public ICommand DefinirLayoutCommand
        {
            get { return _definirLayoutCommand; }
            set
            {
                _definirLayoutCommand = value;
                OnPropertyChanged();
            }
        }

        private ICommand _voltarCommand;

        public ICommand VoltarCommand
        {
            get { return _voltarCommand; }
            set
            {
                _voltarCommand = value;
                OnPropertyChanged();
            }
        }

        public DoisViewModel()
        {
            TextoHeader = "Esse texto está no Header da Listview por meio do Binding.";
            TextoFooter = "Esse texto está no Footer por meio de Binding.";

            Documentos = new ObservableCollection<string>()
            {
                "RG",
                "CPF",
                "CNH",
                "Reservista"
            };

            DefinirLayoutCommand = new Command((object entrada) => DefinirLayout((StackLayout)entrada));
            AdicionarItemCommand = new Command((object entrada) => AdicionarItem((string)entrada));
            VoltarCommand = new Command(Voltar);

            Pessoas = new ObservableCollection<Pessoa>()
            {
                new Pessoa{ Contador = 1, Nome = "A", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 2, Nome = "B", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 3, Nome = "C", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 4, Nome = "D", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 5, Nome = "E", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 6, Nome = "F", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 7, Nome = "G", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 8, Nome = "H", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 9, Nome = "I", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 10, Nome = "J", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 11, Nome = "K", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 12, Nome = "L", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 13, Nome = "M", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 14, Nome = "N", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 15, Nome = "O", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 16, Nome = "P", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 17, Nome = "Q", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand},
                new Pessoa{ Contador = 18, Nome = "R", DefinirLayoutCommand = this.DefinirLayoutCommand, AdicionarItemCommand = this.AdicionarItemCommand}
            };           
        }

        private void AdicionarItem(string entrada)
        {
            if (entrada == null)
                return;

            var label = new Label()
            {
                Text = entrada
            };

            _layoutAtual.Children.Add(label);
        }

        private void DefinirLayout(StackLayout entrada)
        {
            if (entrada == null)
                return;

            _layoutAtual = entrada;
        }

        private async void Voltar()
        {
            await Navigation.PopAsync();
        }
    }
}
