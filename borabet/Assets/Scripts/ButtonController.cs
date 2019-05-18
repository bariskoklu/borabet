using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public List<GameObject> buildings;
    public int currentBuildingNumber = 0;
    public GameObject currentBuilding;
    private void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, currentBuilding.transform.position.z + 7);
    }
    public void ChangeBuilding()
    {

        currentBuildingNumber++;
        if (currentBuildingNumber >= 3)
        {
            currentBuildingNumber = 0;
        }

        currentBuilding = buildings[currentBuildingNumber];
        this.ChangeCamera(currentBuilding);
    }

    private void ChangeCamera(GameObject currentBuilding)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, currentBuilding.transform.position.z + 7);
    }
}
