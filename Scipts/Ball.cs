using UnityEngine;

public class Ball : MonoBehaviour
{
AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.layer == 5 || collision.gameObject.layer == 6) {
        audioManager.PlaySFX(audioManager.kick);
        }
    }
}