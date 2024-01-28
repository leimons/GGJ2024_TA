using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightFlickering : MonoBehaviour
{
    public float minIntensity = 2.5f; // Minimum intensity value
    public float maxIntensity = 5f;   // Maximum intensity value
    public float flickerSpeed = 1f;   // Speed of the flicker

    public Light2D light2D;
    private float originalIntensity;

    void Start()
    {
        light2D = GetComponent<Light2D>();

        if (light2D == null)
        {
            Debug.LogError("Light2D component not found on the GameObject.");
            enabled = false; // Disable the script if Light2D component is not found.
        }

        originalIntensity = light2D.intensity;
    }

    void Update()
    {
        // Calculate flicker intensity using a sine function
        float flickerIntensity = Mathf.Lerp(minIntensity, maxIntensity, Mathf.PingPong(Time.time * flickerSpeed, 1f));

        // Apply flicker intensity to the Light2D component
        light2D.intensity = originalIntensity * flickerIntensity;
    }
}