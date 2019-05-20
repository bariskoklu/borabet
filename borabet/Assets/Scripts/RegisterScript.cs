using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterScript : MonoBehaviour
{
    public GameObject usernameObject;
    public GameObject passwordObject;
    public GameObject confPasswordObject;
    public GameObject emailObject;

    private string username;
    private string password;
    private string confPassword;
    private string email;
    private List<string> registerInformation = new List<string>();

    public void RegisterButton()
    {
        if (string.Equals(passwordObject.GetComponent<InputField>().text, confPasswordObject.GetComponent<InputField>().text))
        {
            username = usernameObject.GetComponent<InputField>().text;
            password = passwordObject.GetComponent<InputField>().text;
            confPassword = confPasswordObject.GetComponent<InputField>().text;
            email = emailObject.GetComponent<InputField>().text;

            registerInformation.Add(username);
            registerInformation.Add(password);
            registerInformation.Add(confPassword);
            registerInformation.Add(email);
        }
    }
}
