using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class VideoAdScript : MonoBehaviour 
{ 

    string gameId = "3430829";

    void Start () 
    {
        Advertisement.Initialize (gameId, true);
    }

    void Update()
    {
        StartCoroutine(AdShow());
    }

    IEnumerator AdShow()
    {
        yield return new WaitForSeconds(2400);
        Advertisement.Show();

    }
}