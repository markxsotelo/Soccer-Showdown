using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public static int scoreLeft = 0;  
    public GameObject ball;           
    public Transform ballSpawnPoint;  
AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            audioManager.PlaySFX(audioManager.goal);

            scoreLeft++;

            Debug.Log("Left Player Score: " + scoreLeft);

            other.gameObject.SetActive(false);  

            Debug.Log("Ball deactivated, scheduling respawn");
            Invoke("ResetBall", 1f);  
        }
    }

    private void ResetBall()
    {
        if (ballSpawnPoint == null)
        {
            Debug.LogError("Ball Spawn Point is not assigned or has been destroyed!");
        }
        else
        {
            Debug.Log("Ball Spawn Point is valid.");
        }

        if (ball == null)
        {
            Debug.LogError("Ball prefab is not assigned!");
        }
        else
        {
            Debug.Log("Ball prefab is valid.");
        }

        if (ballSpawnPoint != null && ball != null)
        {
            Debug.Log("Respawning ball at position: " + ballSpawnPoint.position);

            ball.SetActive(true);  
            ball.transform.position = ballSpawnPoint.position;  
        }
        else
        {
            Debug.LogError("Ball spawn or ball prefab is null, cannot respawn ball.");
        }
    }
}