using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class ShowAds : MonoBehaviour, IUnityAdsLoadListener,IUnityAdsShowListener
{

    public int AdID;
    private void Awake()
    {
        LoadAds();
    }

    public void LoadAds()
    {
        GSF_AdsManager.RequestInterstitial();
        GSF_AdsManager.LoadAd(this);
    }
    public void ShowAdsNow()
    {
        GSF_AdsManager.ShowInterstitial(AdID, this);
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
    }

    public void OnUnityAdsShowStart(string placementId)
    {
    }

    public void OnUnityAdsShowClick(string placementId)
    {
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
    }
}
