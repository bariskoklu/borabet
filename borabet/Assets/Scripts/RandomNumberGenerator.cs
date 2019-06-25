using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumberGenerator : MonoBehaviour
{
    private int pointGenerated = 0;
    private int maxRange = 1000;//Alınabilicek en fazla puan
    private int minRange = 300;//Alınabilicek en düşük puan
    public GameObject buildingPointText;
    public GameObject totalPointText;

    void Start()
    {
        PointHolderStatic.currentBuildingPoint = 0;
        totalPointText.GetComponent<Text>().text = PointHolderStatic.totalPoint.ToString();
        buildingPointText.GetComponent<Text>().text = PointHolderStatic.currentBuildingPoint.ToString();
    }


    public void GeneratePoint()
    {
        pointGenerated = Random.Range(minRange, maxRange);
        PointHolderStatic.currentBuildingPoint = pointGenerated;
        buildingPointText.GetComponent<Text>().text = PointHolderStatic.currentBuildingPoint.ToString();
    }
}
