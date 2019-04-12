using StackCustomForceRender.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackCustomForceRender.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoisPage : ContentPage
	{
		public DoisPage ()
		{
			InitializeComponent ();

            BindingContext = new DoisViewModel()
            {
                Navigation = this.Navigation
            };
        }
	}
}