//W6 CodingGym - Controls : challenge 2

using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer colorRenderer;
    public Color color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colorRenderer.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        bool isMouseClicked = Mouse.current.leftButton.wasReleasedThisFrame;
        bool isMouseOverSprite = colorRenderer.bounds.Contains(worldMousePosition);

        

    }
}
