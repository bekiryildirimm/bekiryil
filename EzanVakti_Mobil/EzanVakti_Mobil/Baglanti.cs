using Android.Webkit;

namespace EzanVakti_Mobil
{
    public class Baglanti : WebViewClient
    {
        [System.Obsolete]
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {
           
           view.LoadUrl(url);
            return true;
        }
    }
}