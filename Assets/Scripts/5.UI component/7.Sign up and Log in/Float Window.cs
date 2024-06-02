using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatWindow : MonoBehaviour
{
    public static FloatWindow Instance;
    private Text infoText;
    private Button checkbutton;
    private void Awake()
    {
        Instance = this;
        infoText = transform.Find("Message Text").GetComponent<Text>();
        checkbutton = transform.Find("Ok").GetComponent<Button>();
        checkbutton.onClick.AddListener(CheckButtonClick);
        CheckButtonClick();
    }

    public void ShowInfo(string info)
    {
        gameObject.SetActive(true);
        infoText.text = info;
    }

    public void CheckButtonClick()
    {
        gameObject.SetActive(false);
    }
}
