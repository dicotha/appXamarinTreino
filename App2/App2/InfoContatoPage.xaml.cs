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

        bool AtivaTelefone;

        public bool Valida
        {
            get
            {
                return AtivaTelefone;
            }
            set
            {
                AtivaTelefone = value;
                if (AtivaTelefone)
                    DisplayAlert("Torna Principal", "Telefone Ativo como principal", "ok");
                else
                    DisplayAlert("Torna Principal", "Desativa Telefone como principal", "ok");

            }

        }


        public InfoContatoPage (Contato contato)
		{
			InitializeComponent ();

            this.Title = contato.Nome;
            this.SwitchTelefone.Text = Convert.ToString(contato.Telefone);
            
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MaisDetalhes());
        }
    }
}