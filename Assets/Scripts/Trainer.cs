using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using Unity.VisualScripting;

public class Trainer : MonoBehaviour
{
    public SpriteRenderer creatureRenderer;
    public Camera gameCamera;
    public Color caughtColour;

    public List<SpriteRenderer> uncaughtCreatures;
    public List<SpriteRenderer> caughtCreatures;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isClickded = Mouse.current.leftButton.wasPressedThisFrame;

        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToViewportPoint(mousePosition);
        worldMousePosition.z = 0f;

        if (isClickded )
        {
            //caughtCreatures;
            //for each element I want to output that to the console
            for( int i = 0; i < caughtCreatures.Count; i++)
            {
                Debug.Log(caughtCreatures[i]);
            }

            if (caughtCreatures.Count > 0)
            {
                Debug.Log(caughtCreatures[0]);
            }
        }


        if (isClickded && creatureRenderer.bounds.Contains(transform.position))
        {
            creatureRenderer.color = caughtColour;


            bool isCreatureCaught = caughtCreatures.Contains(creatureRenderer);
            //if (caughtCreatures.Contains(creatureRenderer))
            Debug.Log("Is creature caught[" + isCreatureCaught.ToString() + "]");

            if (!isCreatureCaught)
            {
                caughtCreatures.Add(creatureRenderer);
            }

            uncaughtCreatures.Remove(creatureRenderer);
        }
    }

}
