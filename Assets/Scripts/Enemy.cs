using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Enemy : MonoBehaviour
{
    public int health;

    public Camera gameCamera;

    public TextMeshProUGUI healthText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();

        bool isClicked = Mouse.current.leftButton.wasPressedThisFrame;

        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if (isClicked && spriteRenderer.bounds.Contains(worldMousePosition))
        {
            health--;

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
