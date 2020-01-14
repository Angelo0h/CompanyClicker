using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using System.Collections;

[RequireComponent (typeof (Button))]
public class RewardedAdsButton : MonoBehaviour, IUnityAdsListener 
{

    #if UNITY_IOS
    private string gameId = "3430828";
    #elif UNITY_ANDROID
    private string gameId = "3430829";
    #endif

    Button myButton;
    private string myPlacementId = "rewardedVideo";

    void Start () 
    {   
        myButton = GetComponent <Button> ();

        myButton.interactable = Advertisement.IsReady (myPlacementId); 

        if (myButton) myButton.onClick.AddListener (ShowRewardedVideo);

        Advertisement.AddListener (this);
        Advertisement.Initialize (gameId, true);
    }

    void ShowRewardedVideo () 
    {
        Advertisement.Show (myPlacementId);
    }

    public void OnUnityAdsReady(string placementId)
    {
        if(placementId == myPlacementId)
        {
            myButton.interactable = true;
        }
    }
    public void OnUnityAdsDidFinish (string placementId, ShowResult showResult) 
    {
        
        if (showResult == ShowResult.Finished) 
        {
            Time.timeScale = 5;
            StartCoroutine(TimeTravel());
        } else if (showResult == ShowResult.Skipped) 
        {
            //Pulou
        } else if (showResult == ShowResult.Failed) 
        {
            //Falhou
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsDidError (string message) 
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart (string placementId) 
    {
        // Optional actions to take when the end-users triggers an ad.
    } 

    IEnumerator TimeTravel()
    {
        yield return new WaitForSeconds(10);
        Time.timeScale = 1;
    }
}