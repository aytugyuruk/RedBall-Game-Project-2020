using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;


public class gecisreklam : MonoBehaviour
{

    private BannerView gecis;
    void Start()
    {
        gecis = new BannerView("ca-app-pub-4225865230234720/5233134517", AdSize.Banner,AdPosition.Top);
        AdRequest reklamistegi = new AdRequest.Builder().Build();
        gecis.LoadAd(reklamistegi);
       
    }
    public void reklamgöster()
    {
        gecis.Show();



    }
}
