using UnityEngine;

public class Pipes : MonoBehaviour
{
    float vitesseX = 2f;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialisation du Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-vitesseX, 0);
    }
}
