using UnityEngine;
using UnityEngine.InputSystem;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D rb;

    public float jumpForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.linearVelocity = new Vector2(0, jumpForce * 2);
        }
    }
}
