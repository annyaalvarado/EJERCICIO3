using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJERCICIO3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listado : ContentPage
    {
        

        public Listado()
        {
            InitializeComponent();

        }

        //Evento load de un content page

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listemple.ItemsSource = await App.DataBaseEmple.ListaEmpleados();

        }

        private async void toolad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void listemple_SelectionChanged(Object sender, SelectionChangedEventArgs e)
        {
            Models.Empleado emple = (Models.Empleado)e.CurrentSelection.FirstOrDefault();

            MainPage pag = new MainPage();
            pag.BindingContext = emple;
            await Navigation.PushAsync(pag);
        }
    }
}