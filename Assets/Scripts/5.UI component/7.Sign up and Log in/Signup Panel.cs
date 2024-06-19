using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignupPanel : MonoBehaviour
{
    public static SignupPanel Instance;
    private InputField userName;
    private InputField password;
    private InputField rePassword;
    private Toggle isMan;
    private Button backButton;
    private Button okButton;

    private void Awake()
    {
        Instance = this;
        userName = transform.Find("Name Label/Name InputField").GetComponent<InputField>();
        password = transform.Find("Passwd Label/Passwd InputField").GetComponent<InputField>();
        rePassword = transform.Find("Repasswd Label/Repasswd InputField").GetComponent<InputField>();
        isMan = transform.Find("Sex panel/Man").GetComponent<Toggle>();

        backButton = transform.Find("Back Button").GetComponent<Button>();
        okButton = transform.Find("Submit").GetComponent<Button>();

        backButton.onClick.AddListener(BackButtonClick);
        okButton.onClick.AddListener(OkButtonClick);

        gameObject.SetActive(false);
    }

    private void BackButtonClick()
    {
        RootPanel.Instance.Show();
        gameObject.SetActive(false);
    }

    private void OkButtonClick()
    {
        if (string.IsNullOrEmpty(userName.text)
            || string.IsNullOrEmpty(password.text)
            || string.IsNullOrEmpty (rePassword.text))
        {
            FloatWindow.Instance.ShowInfo("请输入账号或密码！");
        } else if (password.text != rePassword.text)
        {
            FloatWindow.Instance.ShowInfo("确认密码不一致！");
        } else
        {
            if (GameManager.Instance.GetUserInfo(userName.text) != null)
            {
                FloatWindow.Instance.ShowInfo("已经注册过啦！");
            } else
            {
                L5_7UserInfo userInfo = new L5_7UserInfo(userName.text, password.text, isMan.isOn);
                GameManager.Instance.SaveUserInfo(userInfo);
                FloatWindow.Instance.ShowInfo("注册成功");
            }
            userName.text = "";
            password.text = "";
            rePassword.text = "";
            isMan.isOn = true;
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
}
