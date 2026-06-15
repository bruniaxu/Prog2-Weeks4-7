//W6 CodingGym - Controls : challenge 2

using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer colorRenderer;
    public AudioSource damageSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
   

        

    }

    public void colorChanger()
    {
        colorRenderer.color = new Color(Random.value, Random.value, Random.value);
        damageSound.Play();
    }
}
