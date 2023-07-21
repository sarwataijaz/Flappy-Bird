using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using Unity.UI;
using UnityEngine.UI; // for including texts, UI
using System.ComponentModel.Design.Serialization;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public Text scoreText;
    public Text textScore;
    public GameObject gameOverScreen;
    int restart;

  
    private void Start()
    {
        // Retrieve the high score from PlayerPrefs when the scene starts
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        // Display the high score
        scoreText.text = highScore.ToString();
    }


    [ContextMenu("Increase Score")]
    public void addScore(int scoretoAdd)
    {
        playerScore = playerScore + scoretoAdd;
        textScore.text = playerScore.ToString(); // converting int to string
    }

    private void saveHighScore()
    {
        if(playerScore > highScore)
        {
            highScore = playerScore;
        }

        // Save the high score using PlayerPrefs
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();

        scoreText.text = highScore.ToString();

    }
    public void restartGame()
    {
        // save score before loading the screen
        saveHighScore();


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    
    } 

    public void quitGame()
    {
        Application.Quit();
    }
   
}
