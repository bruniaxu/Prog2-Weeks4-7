using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.U2D;


public class ShapeDes : MonoBehaviour
{
    public SpriteRenderer shapeRenderer;
    public Camera gameCamera;
    public TMP_Text desText;
    public string des;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        if (shapeRenderer.bounds.Contains(worldMousePosition))
        {
            desText.text = des;
        }
    }
}
