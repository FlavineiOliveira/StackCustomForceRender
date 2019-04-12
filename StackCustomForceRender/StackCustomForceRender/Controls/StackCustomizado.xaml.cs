
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackCustomForceRender.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackCustomizado : StackLayout
	{
        public ICommand DefinirLayoutCommand
        {
            get
            {
                return (ICommand)GetValue(DefinirLayoutCommandProperty);
            }
            set
            {
                SetValue(DefinirLayoutCommandProperty, value);
                OnPropertyChanged("DefinirLayoutCommand");
            }
        }

        public static readonly BindableProperty DefinirLayoutCommandProperty = BindableProperty.Create(
                                                                    nameof(DefinirLayoutCommand),
                                                                    typeof(ICommand),
                                                                    typeof(StackCustomizado));

        public ICommand AdicionarItemNaListaCommand
        {
            get
            {
                return (ICommand)GetValue(AdicionarItemNaListaCommandProperty);
            }
            set
            {
                SetValue(AdicionarItemNaListaCommandProperty, value);
                OnPropertyChanged("AdicionarItemNaListaCommand");
            }
        }

        public static readonly BindableProperty AdicionarItemNaListaCommandProperty = BindableProperty.Create(
                                                                    nameof(AdicionarItemNaListaCommand),
                                                                    typeof(ICommand),
                                                                    typeof(StackCustomizado));

        public object ItensStack
        {
            get
            {
                return (object)GetValue(ItensStackProperty);
            }
            set
            {
                SetValue(ItensStackProperty, value);
                OnPropertyChanged(nameof(ItensStack));
            }
        }

        public static readonly BindableProperty ItensStackProperty = BindableProperty.Create(
                                                                    nameof(ItensStack),
                                                                    typeof(object),
                                                                    typeof(StackCustomizado),
                                                                    BindingMode.TwoWay,
                                                                    propertyChanged: ItensStackChanged
                                                                    );

        static void ItensStackChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null)
                return;

            var lista = newValue as List<string>;

            if (lista.Count > 0)
            {
                var stack = (StackCustomizado)bindable;
                stack.DefinirLayoutCommand?.Execute(stack);

                foreach (var item in lista)
                {
                    stack.AdicionarItemNaListaCommand?.Execute(item);
                }
            }
        }

        public StackCustomizado ()
		{
			InitializeComponent ();
		}
	}
}