using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginPanel : MonoBehaviour
{
    public static LoginPanel Instance;
    private InputField userName;
    private InputField password;
    private Button backButton;
    private Button loginButton;

    private void Awake()
    {
        Instance = this;
        userName = transform.Find("Name Label/Name InputField").GetComponent<InputField>();
        password = transform.Find("Passwd Label/Passwd InputField").GetComponent<InputField>();

        backButton = transform.Find("Back Button").GetComponent<Button>();
        loginButton = transform.Find("Login Button").GetComponent<Button>();

        backButton.onClick.AddListener(BackButtonClick);
        loginButton.onClick.AddListener(LoginButtonClick);

        gameObject.SetActive(false);
    }

    private void BackButtonClick()
    {
        RootPanel.Instance.Show();
        gameObject.SetActive(false);
    }

    private void LoginButtonClick()
    {
        if (userName.text == null
            || password.text == null)
        {
            FloatWindow.Instance.ShowInfo("«Î ‰»Î’ÀªßªÚ√‹¬Î£°");
        } else if (GameManager.Instance.GetUserInfo(userName.text) == null)
        {
            FloatWindow.Instance.ShowInfo("’Àªß¥ÌŒÛ£°");
        } else if (GameManager.Instance.GetUserInfo(userName.text).password != password.text)
        {
            FloatWindow.Instance.ShowInfo("√‹¬Î¥ÌŒÛ£°");
        } else
        {
            FloatWindow.Instance.ShowInfo("µ«¬º≥…π¶£°");
        }

        userName.text = "";
        password.text = "";
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
}
