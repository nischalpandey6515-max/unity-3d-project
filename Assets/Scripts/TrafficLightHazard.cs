using UnityEngine;
using TMPro;

public class TrafficLightHazard : MonoBehaviour
{
    public TMP_Text trafficText;

    public bool redLight = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trafficText.gameObject.SetActive(true);

            // RED LIGHT
            if (redLight)
            {
                trafficText.text = "STOP! Red Light";
            }

            // GREEN LIGHT
            else
            {
                trafficText.text = "GO! Green Light";
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trafficText.gameObject.SetActive(false);
        }
    }
}