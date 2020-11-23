using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrarse : ContentPage
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private async void btnRegistrarse_Clicked(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var apellido = txtApellido.Text;
            var clave = txtPass.Text;
            var usuario = txtUsuario.Text;

            try
            {
                //Crear objeto - instancia 
                WebClient cliente = new WebClient();

                //Contenedor para los atributos de la tabla que envia el usuario en las cajas de texto
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("usuario", txtUsuario.Text);
                parametros.Add("clave", txtPass.Text);

                //envio de datos para el POST
                cliente.UploadValues("http://192.168.100.70/rest/restUsuario/post.php", "POST", parametros);
                await DisplayAlert("Alerta", "Ingreso correctamente", "Aceptar");
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtPass.Text = string.Empty;
                txtUsuario.Text = string.Empty;


            }
            catch (Exception ex)
            {
                await DisplayAlert("Alerta", "ERROR " + ex.Message, "ok");
            }

        }
    }
}