﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private async void btnMatematicas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Matematicas());
        }

        private void btnLetras_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnAnimales_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Animales());
        }

        private async void btnFiguras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Figuras());
        }
    }
}