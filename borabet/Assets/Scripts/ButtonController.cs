using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class ButtonController : MonoBehaviour, IUnityAdsListener
{
    public int buildingNumber = 3;
    string gameId = "3199971";
    bool testMode = true;
    private void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);
    }

    public void ChangeScene()
    {
        /*if (Advertisement.IsReady("LevelChange"))
        {
            Debug.Log("hey");
            Advertisement.Show("LevelChange");
        }*/

        if (SceneManager.GetActiveScene().buildIndex + 1 < buildingNumber)
        {
            if (Advertisement.IsReady("rewardedVideo"))
            {
                Advertisement.Show("rewardedVideo");
            }
        }
        else
        {
            if (Advertisement.IsReady("LevelChange"))
            {
                Advertisement.Show("LevelChange");
            }
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        
    }

    public void OnUnityAdsDidError(string message)
    {
        
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished && placementId == "rewardedVideo")
        {
            Debug.Log("Puanın ikiye katlandı");
            PointHolderStatic.currentBuildingPoint *= 2;
            PointHolderStatic.totalPoint += PointHolderStatic.currentBuildingPoint;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (showResult == ShowResult.Skipped && placementId == "rewardedVideo")
        {
            Debug.Log("Videoyu bitirmediğinden dolayı puanın ikiye katlanmadı");
        }
        else if (showResult == ShowResult.Finished && placementId == "LevelChange")
        {
            SceneManager.LoadScene(0);
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }
}
