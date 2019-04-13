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
	public partial class TresPage : ContentPage
	{
		public TresPage()
		{
			InitializeComponent ();

            BindingContext = new TresViewModel();
		}
	}
}