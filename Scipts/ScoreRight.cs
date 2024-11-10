using UnityEngine;
using TMPro;  

public class ScoreRight : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        if (scoreText == null)
        {
            Debug.LogError("Score TextMeshProUGUI component is not assigned.");
        }
    }

    void Update()
    {
        scoreText.text = " " + GoalScriptLeft.scoreRight.ToString();
    }
}