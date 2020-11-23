using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        
        public Login()
        {
            InitializeComponent();
           
        }

        private async void btnIngreso_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                await DisplayAlert("Error", "Debe ingresar un usuario", "Aceptar");
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                await DisplayAlert("Error", "Debe ingresar una contraseña", "Aceptar");
                txtPass.Focus();
                return;
            }

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.100.70");
            string url = string.Format("/rest/restUsuario/post.php?usuario={0}&clave={1}",txtUsuario.Text,txtPass.Text);
            var response = await client.GetAsync(url);
            var result = response.Content.ReadAsStringAsync().Result;
            
            if (string.IsNullOrEmpty(result) || result == "false")
            {
                await DisplayAlert("Error", "Usuario o clave incorrecto", "Aceptar");
                txtUsuario.Text = string.Empty;
                txtPass.Text = string.Empty;
                txtUsuario.Focus();
                
                return;
            }
            else
            {
               await Navigation.PushAsync(new MenuPrincipal());
            }

        }

        private async void lblRegistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrarse());
        }
    }
}