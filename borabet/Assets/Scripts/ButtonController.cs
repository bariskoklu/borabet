using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void ChangeScene(string sceneToGo)
    {

        SceneManager.LoadScene(sceneToGo);
    }
}
