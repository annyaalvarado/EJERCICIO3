using EJERCICIO3.Controllers;
using EJERCICIO3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJERCICIO3


{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }



        private async void btnguardar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Empleado

            {
                Id = Convert.ToInt32 (txtid.Text),
                nombre = txtnombre.Text,
                apellidos = txtapellido.Text,
                edad = Convert.ToInt32(txtedad.Text),
                correo = txtcorreo.Text,
                direccion = txtdireccion.Text
            };

            var result = await App.DataBaseEmple.StoreEmple(emple);
            
            if(result>0)
            {
                await DisplayAlert("Registro Ingresado", "Correctamente", "ok");
            }

            else
            {
                await DisplayAlert("Error", "No ingresado", "ok");
            }
        }

        private void vaciarcampos()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txtcorreo.Text = "";
            txtdireccion.Text = "";
        }

        private async void btneliminar (object sender, EventArgs e)

        {
            var person = new Models.Empleado
            {
                Id = Convert.ToInt32(txtid.Text),
                nombre = txtnombre.Text,
                apellidos = txtapellido.Text,
                edad = Int32.Parse(txtedad.Text),
                correo = txtcorreo.Text,
                direccion = txtdireccion.Text
            };

            var result = await App.DataBaseEmple.DeleteEmple(person); ;

            if (result > 0)
                await DisplayAlert("El registro ha sido eliminado", "Exitosamente", "OK");
            else
                await DisplayAlert("Error", "No se pudo eliminar", "OK");

            vaciarcampos();

        }
    }
}
