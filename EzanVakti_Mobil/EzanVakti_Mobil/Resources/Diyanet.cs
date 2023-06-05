using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EzanVakti_Mobil.Resources.Services;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EzanVakti_Mobil.Resources
{
    public class Diyanet
    {
        public string BirAyet,titleAyet;
        public string BirHadis,titleHadis;
        public string BirDua,titleDua;
        public string TakvimOn,titleTakvimon;
        public string TakvimArka { get; set; }
           public string titleTakvimarka { get; set; }
        HtmlClientModel htmlclient = new HtmlClientModel();
        HtmlDocument html = new HtmlDocument();
        public Diyanet()
        {
         

        }

        public async Task CallTakvimArka()
        {
           
             string response = await htmlclient.htmlProcess("https://www.diyanethaber.com.tr/diyanet-takvimi");
             html.LoadHtml(response);
             var Links = html.DocumentNode;

             var a = Links.SelectNodes("/html/body/main/div/div[2]/div[3]/div/div[1]/div[1]/div[1]/div[1]/a")[0];
             string link = "https://www.diyanethaber.com.tr" + a.Attributes["href"].Value;
            string response2= await htmlclient.htmlProcess(link);

             html.LoadHtml(response2);
             var diyanetLink=html.DocumentNode;
             this.TakvimArka = diyanetLink.SelectNodes("/html/body/main/div/div[3]/div[2]/div/div/div[1]/div[3]/div/p[1]")[0].InnerText;
             var baslik = diyanetLink.SelectNodes("/html/head/meta[8]")[0];
             this.titleTakvimarka= baslik.Attributes["content"].Value.ToUpper();
            try
            {
                this.TakvimOn = diyanetLink.SelectNodes("/html/body/main/div/div[3]/div[2]/div/div/div[1]/div[3]/div/p[3]/strong")[0].InnerText+ "\n" + diyanetLink.SelectNodes("/html/body/main/div/div[3]/div[2]/div/div/div[1]/div[3]/div/p[5]")[0].InnerText;
            }
            catch(Exception ex)
            {
                this.TakvimOn = null;
            }
           
            


        }
     public async Task CallBirAyet()
        {
            string response = await htmlclient.htmlProcess("https://www.diyanethaber.com.tr/bir-ayet");
            html.LoadHtml(response);
            var Links = html.DocumentNode;
            var ay = Links.SelectNodes("/html/body/main/div/div[2]/div[3]/div/div[1]/div[1]/div[1]/div[1]/a")[0];
            string link = "https://www.diyanethaber.com.tr" + ay.Attributes["href"].Value;
            string response2 = await htmlclient.htmlProcess(link);

            html.LoadHtml(response2);
            var diyanetLink = html.DocumentNode;
            var ayet = diyanetLink.SelectNodes("/html/body/main/div/div[3]/div[2]/div/div/div[1]/div[3]/div/p[1]/strong")[0].InnerText;
            int inde2 = ayet.IndexOf("(", ayet.Length - 30);
            this.BirAyet = ayet.Remove(inde2);
            this.titleAyet = ayet.Remove(0, inde2);
           
        }
        public async Task CallBirHadis()
        {
            string response = await htmlclient.htmlProcess("https://www.diyanethaber.com.tr/hadislerle-islam");
            html.LoadHtml(response);
            var Links = html.DocumentNode;
            var ay = Links.SelectNodes("/html/body/main/div/div[2]/div[3]/div/div[1]/div[1]/div[1]/div[1]/a")[0];
            string link = "https://www.diyanethaber.com.tr" + ay.Attributes["href"].Value;
            string response2 = await htmlclient.htmlProcess(link);

            html.LoadHtml(response2);
            var diyanetLink = html.DocumentNode;
            try
            {
                this.BirHadis = diyanetLink.SelectNodes("/html/body/main/div/div[3]/div[2]/div/div/div[1]/div[3]/div/p[3]/em")[0].InnerText;
                this.titleHadis = diyanetLink.SelectNodes("/html/body/main/div/div[3]/div[2]/div/div/div[1]/div[3]/div/p[4]")[0].InnerText;
            }
            catch(Exception ex)
            {
                this.BirHadis = null;
                this.titleHadis= null;
            }

           
        }
        public async Task CallBirHadis2()
        {
            string response = await htmlclient.htmlProcess("https://www.diyanet.gov.tr");
            html.LoadHtml(response);

            var Links = html.DocumentNode;
            string hadis = Links.SelectSingleNode("/html/body/div[2]/div/div[10]/div[2]/div[1]/a/p").InnerText;
            string hadisSource = Links.SelectSingleNode("/html/body/div[2]/div/div[10]/div[2]/div[2]/p").InnerText;
            string had = System.Net.WebUtility.HtmlDecode(hadis).Remove(0, 26);
            this.BirHadis = had.Remove(had.Length-22); //.Remove(had.Length - 40);
            this.titleHadis = System.Net.WebUtility.HtmlDecode(hadisSource);

        }
        public async Task CallBirDua()
        {
            string response = await htmlclient.htmlProcess("https://www.diyanet.gov.tr");
           html.LoadHtml(response);
          
            var Links = html.DocumentNode;
            string dua = Links.SelectSingleNode("/html/body/div[2]/div/div[10]/div[3]/div/a/p").InnerText;
            string duaSource = Links.SelectSingleNode("/html/body/div[2]/div/div[10]/div[3]/div/div/p").InnerText;
            this.BirDua=System.Net.WebUtility.HtmlDecode(dua).Remove(0,26);
            this.BirDua = this.BirDua.Remove(this.BirDua.Length - 22);
            this.titleDua = System.Net.WebUtility.HtmlDecode(duaSource);
          
        }
    }
}