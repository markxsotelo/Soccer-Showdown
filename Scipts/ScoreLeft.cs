using UnityEngine;
using TMPro;  

public class ScoreLeft : MonoBehaviour
{
    public TextMeshProUGUI score;  

    void Start()
    {
        if (score == null)
        {
            Debug.LogError("Score TextMeshProUGUI component is not assigned.");
        }
    }

    void Update()
    {
        score.text = " " + GoalScript.scoreLeft.ToString();
    }
}