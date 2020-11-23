using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Figuras : ContentPage
    {
        public Figuras()
        {
            InitializeComponent();
            /*var htmlcontent = new HtmlWebViewSource();
            htmlcontent.Html = "<html><head></head><body>" +
                "<iframe width='560' height='315' src='https://www.youtube.com/embed/65wZuz-8u-k' " +
                "frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"+
                "</body></html>";
            Video.Source = htmlcontent;*/
            VideoFiguras.Source = "https://www.youtube.com/embed/65wZuz-8u-k";
        }

        public string GetYouTubeUrl()
        {
            var videoInfoUrl = "https://www.youtube.com/embed/65wZuz-8u-k";
            using (var client = new HttpClient())
            {
                var videoPageContent = client.GetStringAsync(videoInfoUrl).Result;
                var videoParameters = HttpUtility.ParseQueryString(videoPageContent);
                var encodedStreamsDelimited1 = WebUtility.HtmlDecode(videoParameters["player_response"]);
                JObject jObject = JObject.Parse(encodedStreamsDelimited1);
                string url = (string)jObject["streamingData"]["formats"][0]["url"];
                return url;
            }
        }
    }
}