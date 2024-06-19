using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RootPanel : MonoBehaviour
{
    public static RootPanel Instance;
    private Button signupButton;
    private Button loginButton;

    private void Awake()
    {
        Instance = this;
    }

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
        SignupPanel.Instance.Show();
        gameObject.SetActive(false);
    }

    private void LoginClick()
    {
        LoginPanel.Instance.Show();
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
}
