using UnityEngine;
using TMPro;

public class HazardWarningSystem : MonoBehaviour
{
    public TMP_Text warningText;
    public TMP_Text warning2;

    public AudioSource warningAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Show warnings
            warningText.gameObject.SetActive(true);
            warning2.gameObject.SetActive(true);

            // Play audio once
            if (warningAudio != null && !warningAudio.isPlaying)
            {
                warningAudio.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide warnings
            warningText.gameObject.SetActive(false);
            warning2.gameObject.SetActive(false);

            // Stop audio
            if (warningAudio != null)
            {
                warningAudio.Stop();
            }
        }
    }
}