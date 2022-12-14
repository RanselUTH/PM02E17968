using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace PM02E10052.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaSitios : ContentPage
    {
        public ListaSitios()
        {
            InitializeComponent();
            Title = "Lista";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            cargarListado();
        }

        public async void cargarListado()
        {
            var lista = await App.BaseDatos.ObtenerListaSitios();
            listaSitios.ItemsSource = lista;
        }

        private async void listaSitios_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.Sitios item = (Models.Sitios)e.Item;

            var page = new Vistas.UpdatePage();
            page.BindingContext = item;
            await Navigation.PushAsync(page);
        }
    }
}