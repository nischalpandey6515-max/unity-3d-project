using UnityEngine;
using TMPro;

public class HazardDetection : MonoBehaviour
{
    public TMP_Text warningText;
    public TMP_Text warning2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            warningText.gameObject.SetActive(true);
            warning2.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            warningText.gameObject.SetActive(false);
            warning2.gameObject.SetActive(false);
        }
    }
}