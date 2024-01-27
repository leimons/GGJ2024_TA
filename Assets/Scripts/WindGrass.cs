using UnityEngine;

public class ContinuousGrassShift : MonoBehaviour
{
    public float shiftSpeed = 1f; // Adjust the speed of the shift
    public float shiftAmount = 0.1f; // Adjust the amount of the shift
    public Vector3 initialPosition; // Initial position of the grass

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calculate the shift amount based on sine function
        float shift = Mathf.Sin(Time.time * shiftSpeed) * shiftAmount;

        // Apply the shift to the grass sprite's Y position
        transform.position = new Vector3(initialPosition.x, initialPosition.y + shift, initialPosition.z);
    }
}