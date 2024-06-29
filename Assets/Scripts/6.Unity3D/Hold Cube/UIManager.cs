using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Text score_text;
    private int total_enemy_num = 0;
    public Text result_info;
    public GameObject result_panel;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        score_text = transform.Find("ScoreText").GetComponent<Text>();
        result_panel = transform.Find("ResultPanel").gameObject;
        result_info = transform.Find("ResultPanel/ResultInfo").GetComponent<Text>();
        
        result_panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreText()
    {
        total_enemy_num += 1;
        score_text.text = total_enemy_num.ToString();
    }

    public void ShowResult(bool result)
    {
        result_panel.SetActive(true);
        if (result)
        {
            result_info.text = "You Win!";
        } else
        {
            result_info.text = "You Lose!";
        }
    }
}
