using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public class Contato    {
        public string Nome { get; set; }
        public decimal Telefone { get; set; }
    }



    public partial class MainPage : ContentPage
	{
        public List<Contato> Contatos { get; set; }

        public MainPage()
		{
			InitializeComponent();
            this.Contatos = new List<Contato>
            {
                new Contato {Nome = "Waldir", Telefone = 946250052 },
                new Contato {Nome = "Thalita", Telefone = 946250052 },
                new Contato {Nome = "Bernardo", Telefone = 946250052 },
            };
            listaContatos.ItemsSource = this.Contatos;
            this.BindingContext = this;

        }

        private void listaContatos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var telefone = (Contato)e.Item;

            Navigation.PushAsync(new InfoContatoPage(telefone));
        }
    }
}
