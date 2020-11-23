using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Matematicas : ContentPage
    {
        public Matematicas()
        {
            InitializeComponent();
        }

        private void btnP4_Clicked(object sender, EventArgs e)
        {

            btnP4.BackgroundColor = Color.Green;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
            btnA2.BackgroundColor = Color.LightPink;
            btnA4.BackgroundColor = Color.LightPink;
            btnA5.BackgroundColor = Color.LightPink;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
        }

        private void btnP1_Clicked(object sender, EventArgs e)
        {
            btnP1.BackgroundColor = Color.Red;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
            btnA2.BackgroundColor = Color.LightPink;
            btnA4.BackgroundColor = Color.LightPink;
            btnA5.BackgroundColor = Color.LightPink;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
        }

        private void btnP3_Clicked(object sender, EventArgs e)
        {
            btnP3.BackgroundColor = Color.Red;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP4.BackgroundColor = Color.LightYellow;
            btnA2.BackgroundColor = Color.LightPink;
            btnA4.BackgroundColor = Color.LightPink;
            btnA5.BackgroundColor = Color.LightPink;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
        }

        private void btnA2_Clicked(object sender, EventArgs e)
        {
            btnA2.BackgroundColor = Color.Green;
            btnA4.BackgroundColor = Color.LightPink;
            btnA5.BackgroundColor = Color.LightPink;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
        }

        private void btnA4_Clicked(object sender, EventArgs e)
        {
            btnA4.BackgroundColor = Color.Red;
            btnA2.BackgroundColor = Color.LightPink;
            btnA5.BackgroundColor = Color.LightPink;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
        }

        private void btnA5_Clicked(object sender, EventArgs e)
        {
            btnA5.BackgroundColor = Color.Red;
            btnA4.BackgroundColor = Color.LightPink;
            btnA2.BackgroundColor = Color.LightPink;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
        }

        private void btnPe7_Clicked(object sender, EventArgs e)
        {
            btnPe7.BackgroundColor = Color.Red;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnA5.BackgroundColor = Color.LightPink;
            btnA4.BackgroundColor = Color.LightPink;
            btnA2.BackgroundColor = Color.LightPink;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
        }

        private void btnPe8_Clicked(object sender, EventArgs e)
        {
            btnPe8.BackgroundColor = Color.Green;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnA5.BackgroundColor = Color.LightPink;
            btnA4.BackgroundColor = Color.LightPink;
            btnA2.BackgroundColor = Color.LightPink;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
        }

        private void btnPe9_Clicked(object sender, EventArgs e)
        {
            btnPe9.BackgroundColor = Color.Red;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnA5.BackgroundColor = Color.LightPink;
            btnA4.BackgroundColor = Color.LightPink;
            btnA2.BackgroundColor = Color.LightPink;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
        }

        private void btnN3_Clicked(object sender, EventArgs e)
        {
            btnN3.BackgroundColor = Color.Red;
            btnN6.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnA5.BackgroundColor = Color.LightPink;
            btnA4.BackgroundColor = Color.LightPink;
            btnA2.BackgroundColor = Color.LightPink;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
            
        }

        private void btnN6_Clicked(object sender, EventArgs e)
        {
            btnN6.BackgroundColor = Color.Red;
            btnN3.BackgroundColor = Color.Lavender;
            btnN5.BackgroundColor = Color.Lavender;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnA5.BackgroundColor = Color.LightPink;
            btnA4.BackgroundColor = Color.LightPink;
            btnA2.BackgroundColor = Color.LightPink;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
        }

        private void btnN5_Clicked(object sender, EventArgs e)
        {
            btnN5.BackgroundColor = Color.Green;
            btnN6.BackgroundColor = Color.Lavender;
            btnN3.BackgroundColor = Color.Lavender;
            btnPe9.BackgroundColor = Color.LightBlue;
            btnPe8.BackgroundColor = Color.LightBlue;
            btnPe7.BackgroundColor = Color.LightBlue;
            btnA5.BackgroundColor = Color.LightPink;
            btnA4.BackgroundColor = Color.LightPink;
            btnA2.BackgroundColor = Color.LightPink;
            btnP4.BackgroundColor = Color.LightYellow;
            btnP1.BackgroundColor = Color.LightYellow;
            btnP3.BackgroundColor = Color.LightYellow;
        }
    }
}