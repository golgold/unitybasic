using UnityEngine;

public class WhaleDescriptionTrigger : MonoBehaviour
{
    public GameObject descriptionUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            descriptionUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            descriptionUI.SetActive(false);
        }
    }
}