using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;
    
    

    public void Start()
    {
        //textMeshPro = GetComponent<TextMeshProUGUI>();
        
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        score.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {

        gameOverScreen.SetActive(true);
    }

    public void exitButton(){
        Application.Quit();
        Debug.Log("Quit Button Pressed!");
    }

    public void DisplayText()
    {
        textMeshPro.gameObject.SetActive(false);
    }

}
