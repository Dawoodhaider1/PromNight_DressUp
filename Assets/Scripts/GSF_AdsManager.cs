using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
using UnityEngine.Advertisements;
using System.Runtime.CompilerServices;

public class GSF_AdsManager
{
    private static BannerView bannerView;
    private static InterstitialAd interstitial;
    private static string bannerID = "ca-app-pub-2085728649070932/7623287266";
    private static string interstitialID = "ca-app-pub-2085728649070932/6647486634";
    private static string adUnit = "video";

    public static void RequestBanner(AdPosition adPosition)
    {
        bannerView = new BannerView(bannerID, AdSize.Banner, adPosition);
    }

    public static void RequestInterstitial()
    {
        interstitial = new InterstitialAd(interstitialID);
        AdRequest request = new AdRequest.Builder().Build();
        interstitial.LoadAd(request);
    }

    public static void LoadAd(IUnityAdsLoadListener unityAdsLoadListener)
    {
        if (MainManager.Instance.AdsInit)
        {
            Advertisement.Load(adUnit, unityAdsLoadListener);
        }
    }


    public static void ShowInterstitial(int sequenceID, IUnityAdsShowListener unityAdsShowListener)
    {

       
            if (sequenceID == 0)
            {
                if (interstitial.IsLoaded())
                {
                    interstitial.Show();
                }
                else
                {
                if (Advertisement.isInitialized)
                {
                    Advertisement.Show(adUnit, unityAdsShowListener);
                }
            }
            }
            else if (sequenceID == 1)
            {
                if (Advertisement.isInitialized)
                {
                    Advertisement.Show(adUnit, unityAdsShowListener);
                }
                else
                {
                    if (interstitial.IsLoaded())
                    {
                        interstitial.Show();
                    }
                }
            }
    }

    public static void ShowRewardedVideo(int sequenceID, string SceneName)
    {
        //		if (ConsoliAds.Instance != null) {
        //			Debug.Log ("Show Ad Called ----------> Sequence ID : " + sequenceID + " | Scene : " + SceneName);
        //			ConsoliAds.Instance.ShowRewardedVideo (sequenceID);
        //		} else {
        //			Debug.LogWarning ("Consoli Ads Instance Not Found !");
        //		}
    }

    public static void ShowBanner(int sequenceID)
    {

       
    }

    public static void HideBanner()
    {
        //bannerView.Destroy();
    }

    public static void RemoveAdvertisements()
    {
        //bannerView.Destroy();
    }

   
}
