using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SigninBackgroud : MonoBehaviour
{
    private Button signupButton;
    private Button loginButton;
    // Start is called before the first frame update
    void Start()
    {
        signupButton = transform.Find("Signup").GetComponent<Button>();
        loginButton = transform.Find("Login").GetComponent<Button>();

        signupButton.onClick.AddListener(SignupClick);
        loginButton.onClick.AddListener(LoginClick);
    }

    private void SignupClick()
    {
        Debug.Log("Signup");
    }

    private void LoginClick()
    {
        Debug.Log("Login");
    }
}
