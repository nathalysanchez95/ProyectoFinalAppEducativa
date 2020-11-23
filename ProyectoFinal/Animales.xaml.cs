using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Animales : ContentPage
    {
        ISimpleAudioPlayer player;
        public Animales()
        {
            InitializeComponent();
            /*var stream = GetStreamFromFile("leon.mp3");
            player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            player.Load(stream);

            InitControls();*/
        }
      /*  void InitControls()
        {
            sliderVolume.Value = player.Volume;

            btnPlay.Clicked += BtnPlayClicked;
            btnPause.Clicked += BtnPauseClicked;
            btnStop.Clicked += BtnStopClicked;

            sliderVolume.ValueChanged += SliderVolumeValueChanged;
            sliderPosition.ValueChanged += SliderPostionValueChanged;

        }
        private void SliderPostionValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sliderPosition.Value != player.Duration)
                player.Seek(sliderPosition.Value);
        }

        private void SliderVolumeValueChanged(object sender, ValueChangedEventArgs e)
        {
            player.Volume = sliderVolume.Value;
        }

        private void BtnStopClicked(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void BtnPauseClicked(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void BtnPlayClicked(object sender, EventArgs e)
        {
            /*player.Play();

            sliderPosition.Maximum = player.Duration;
            sliderPosition.IsEnabled = player.CanSeek;

            Device.StartTimer(TimeSpan.FromSeconds(0.5), UpdatePosition);*/
      /*      var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioFile = assembly.GetManifestResourceStream("leon.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioFile);

            audio.Stop();

        }
      
        bool UpdatePosition()
        {
            lblPosition.Text = $"Postion: {(int)player.CurrentPosition} / {(int)player.Duration}";

            sliderPosition.ValueChanged -= SliderPostionValueChanged;
            sliderPosition.Value = player.CurrentPosition;
            sliderPosition.ValueChanged += SliderPostionValueChanged;

            return player.IsPlaying;
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("SAPlayerSample." + filename);

            return stream;
        }
        */
      
        private void btnSonidoLeon_Clicked(object sender, EventArgs e)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioFile = assembly.GetManifestResourceStream("ProyectoFinal.Reso.leon.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioFile);

            audio.Stop();
        }

        private void btnVideoLeon_Clicked(object sender, EventArgs e)
        {
            VideoAnimales.Source = "https://www.youtube.com/embed/AjWY-Go0gdo";
        }

        private void btnSonidoEle_Clicked(object sender, EventArgs e)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioFile = assembly.GetManifestResourceStream("ProyectoFinal.Reso.ELEPHANT.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioFile);

            //audio.Stop();
        }

        private void btnVideoEle_Clicked(object sender, EventArgs e)
        {
            VideoAnimales.Source = "https://www.youtube.com/embed/oqtSxLeG0a8";
        }

        private void btnSonidoJirafa_Clicked(object sender, EventArgs e)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioFile = assembly.GetManifestResourceStream("ProyectoFinal.Reso.jirafa.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioFile);

            audio.Stop();
        }

        private void btnVideoJirafa_Clicked(object sender, EventArgs e)
        {
            VideoAnimales.Source = "https://www.youtube.com/embed/1L3EGZN4K5k";
        }
    }
}