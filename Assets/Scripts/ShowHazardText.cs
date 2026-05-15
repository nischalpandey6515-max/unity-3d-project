using UnityEngine;
using System.Collections;

public class ShowHazardText : MonoBehaviour
{
    public GameObject hazardText;

    IEnumerator Start()
    {
        // Show text
        hazardText.SetActive(true);

        // Wait for 5 seconds
        yield return new WaitForSeconds(5f);

        // Hide text
        hazardText.SetActive(false);
    }
}