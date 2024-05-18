using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClicked2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ButtonClicked()
    {
        Debug.Log("ButtonClicked");
    }

    private void ButtonClicked2()
    {
        Debug.Log("ButtonClicked2");
    }
}
