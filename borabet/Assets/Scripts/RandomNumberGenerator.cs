using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumberGenerator : MonoBehaviour
{
    private int pointGenerated = 0;
    private int maxRange = 1000;//Alınabilicek en fazla puan
    private int minRange = 300;//Alınabilicek en düşük puan
    public GameObject pointText;

    void Start()
    {
        pointText.GetComponent<Text>().text = PointHolderStatic.currentPoint.ToString();
    }


    public void GeneratePoint()
    {
        pointGenerated = Random.Range(minRange, maxRange);
        PointHolderStatic.currentPoint += pointGenerated;
        pointText.GetComponent<Text>().text = PointHolderStatic.currentPoint.ToString();
    }
}
