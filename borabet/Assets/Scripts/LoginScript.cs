using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    public GameObject usernameObject;
    public GameObject passwordObject;

    private string username;
    private string password;
    private List<string> LoginInformation = new List<string>();

    public void LoginButton()
    {
        username = usernameObject.GetComponent<InputField>().text;
        password = passwordObject.GetComponent<InputField>().text;

        LoginInformation.Add(username);
        LoginInformation.Add(password);
    }
}
