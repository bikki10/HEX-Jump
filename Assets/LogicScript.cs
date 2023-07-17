using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text score;
    

    /*private void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }*/

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        score.text = playerScore.ToString();
    }
}
