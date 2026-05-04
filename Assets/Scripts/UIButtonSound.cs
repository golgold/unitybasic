using UnityEngine;
public class UIButtonSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hoverSound;   // 효과음1
    public AudioClip clickSound;   // 효과음2
    public void PlayHover()
    {
        audioSource.PlayOneShot(hoverSound);
    }

    public void PlayClick()
    {
        audioSource.PlayOneShot(clickSound);
    }
}