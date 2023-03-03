using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.MODEL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Tarea3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private  async  void BtnSalvar_Clicked(object sender, EventArgs e)
        {

            var PERSON = new Personas
            {
            
                Nombres = txtNombres.Text,
                Apellidos = txtapellido.Text,
                Edad = int.Parse(txtEdad.Text),
                correo = txtCorreo.Text,
                Direccion = txtDireccion.Text,
            };

            if ( await App.Database.Saveemple(PERSON) > 0)
            {
                await DisplayAlert("Ingresado", "Persona ingresada con exito", "OK");
            }

            var secondpage = new PageResultado();
            secondpage.BindingContext = PERSON;
            Navigation.PushAsync(secondpage);

        }
    }
}