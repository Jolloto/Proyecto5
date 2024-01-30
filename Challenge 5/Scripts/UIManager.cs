using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI gameOverScoreText;
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject gameOverPanel;


    public void UpdateScoreText(int score)
    {
        scoreText.text = $"Score:{score}";
    }

    public void UpdateTimeText(int time)
    {
        timeText.text = $"Time:{time}";
    }

    public void ShowGameOverPanel(int score) 
    { 
        gameOverPanel.SetActive(true); 
        gameOverScoreText.text = $"Score: {score}";
    }

    public void HideGameOverPanel() 
    {
        gameOverPanel.SetActive(false);
    }

    public void ShowMainMenuPanel()
    {
        mainMenuPanel.SetActive(true);
        
    }

    public void HideMainMenuPanel()
    {
       mainMenuPanel.SetActive(false);
    }

}
