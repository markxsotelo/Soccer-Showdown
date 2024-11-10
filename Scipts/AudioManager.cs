using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;
    public AudioClip kick;
    public AudioClip goal;

    public void PlaySFX(AudioClip clip) {
        SFXSource.PlayOneShot(clip);
    }
}
