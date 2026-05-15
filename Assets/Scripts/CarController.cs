using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 100f;

    void Update()
    {
        // Get input
        float move = Input.GetAxis("Vertical");     // W/S
        float turn = Input.GetAxis("Horizontal");   // A/D

        // Move forward/backward
        transform.Translate(Vector3.forward * move * moveSpeed * Time.deltaTime);

        // Turn left/right
        transform.Rotate(Vector3.up * turn * turnSpeed * Time.deltaTime);
    }
}