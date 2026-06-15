using Unity.VisualScripting;
using UnityEngine;

public class RotationChanger : MonoBehaviour
{
    public SpriteRenderer RotateRenderer;
    public AudioSource damageSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AngleRotation(float sliderValue)
    {
        Vector3 currentRotation = RotateRenderer.transform.eulerAngles;
        currentRotation.z = sliderValue;
        RotateRenderer.transform.eulerAngles = currentRotation;
        damageSound.Play();
    }
}
