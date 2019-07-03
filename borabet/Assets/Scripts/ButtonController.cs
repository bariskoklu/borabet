using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class ButtonController : MonoBehaviour
{
    public int buildingNumber = 3;
    public GameObject Canvas;
    public GameObject PopUp;
    public int currentBuildingNumber;
    string gameId = "3199971";
    bool testMode = true;
    private void Start()
    {
        Advertisement.Initialize(gameId, testMode);

    }

    public void ChangeScene()
    {
        /*if (Advertisement.IsReady("LevelChange"))
        {
            Debug.Log("hey");
            Advertisement.Show("LevelChange");
        }*/
        //Debug.Log("ses");
        Canvas.SetActive(false);
        gameObject.GetComponent<Camera>().backgroundColor = new Color(0,0,0,0.2f);
        PopUp.SetActive(true);
        //popupdan devam edilecek. Yeni fonksiyon yazılacak popup'ın çağırdığı


        currentBuildingNumber = SceneManager.GetActiveScene().buildIndex;

        if (currentBuildingNumber + 1 < buildingNumber)
        {
            Debug.Log(PointHolderStatic.currentBuildingPoint);
            ShowRewardedVideo();
        }
        else
        {
            Advertisement.Show("LevelChange");
            SceneManager.LoadScene(0);
        }
    }

    void ShowRewardedVideo()
    {
        ShowOptions options = new ShowOptions();
        options.resultCallback = HandleShowResult;

        Advertisement.Show("rewardedVideo", options);
    }

    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            Debug.Log("Video completed - Offer a reward to the player");
            PointHolderStatic.currentBuildingPoint *= 2;
            PointHolderStatic.totalPoint += PointHolderStatic.currentBuildingPoint;
            SceneManager.LoadScene(currentBuildingNumber + 1);

        }
        else if (result == ShowResult.Skipped)
        {
            Debug.LogWarning("Video was skipped - Do NOT reward the player");

        }
        else if (result == ShowResult.Failed)
        {
            Debug.LogError("Video failed to show");
        }
    }
}
