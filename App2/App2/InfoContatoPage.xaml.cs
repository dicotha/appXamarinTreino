using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoContatoPage : ContentPage
	{
		public InfoContatoPage (Contato contato)
		{
			InitializeComponent ();

            this.Title = contato.Nome;
            var telefoneint = contato.Telefone;
            
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MaisDetalhes());
        }
    }
}