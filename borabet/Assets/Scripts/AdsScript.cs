using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsScript : MonoBehaviour
{
    // Start is called before the first frame update
    string gameId = "1234567";
    bool testMode = true;

    // Initialize the Ads service:
    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    private void Update()
    {
        
    }
}
