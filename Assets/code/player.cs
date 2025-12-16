using UnityEngine;

public class Player : MonoBehaviour
{
    private float vitesseY = 4f;
    private Rigidbody2D rb;
    private bool enCollision = false;
    //private int points = 0;
    private gameManager gm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        // Initialisation du Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
        gm = FindObjectOfType<gameManager>();
    }

    // Update is called once per frame
    public void Update()
    {
        
        // Deplacement 
        if (Input.GetKeyDown(KeyCode.Space) && !enCollision)
        {
            rb.velocity = new Vector2(0, vitesseY);
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        { 
            rb.velocity = new Vector2(0, 0);
            enCollision = true;
            gm.GameOver();
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Scoring"))
        {
            gm.AddPoints();
        }
    }
}
