using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using HtmlAgilityPack;
using System.Threading.Tasks;
using Java.Lang;

namespace EzanVakti_Mobil.Resources.Services
{
    public  class HtmlClientModel
    {
        private readonly HttpClient client;
        private readonly HtmlDocument bhtml;
        public static string htmlMetni;
        public HtmlClientModel()
        {
            client = new HttpClient();
           bhtml = new HtmlDocument();
        }
        public async Task<string> htmlProcess(string url)
        {
            var uri = new Uri(url);
            var streamTask = await client.GetStringAsync(uri);
            
           htmlMetni = streamTask;
           return streamTask;
        }

    }
}