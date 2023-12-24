using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text ScoreText;
    public GameObject gameOverscreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoretoadd)
    {
    playerScore = playerScore + scoretoadd;
    ScoreText.text = playerScore.ToString();

  }  
  public void restartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
  public void GameOver()
  {
     gameOverscreen.SetActive(true);
  }
  public void quitgame()
  {
    Application.Quit();
  }
} 
