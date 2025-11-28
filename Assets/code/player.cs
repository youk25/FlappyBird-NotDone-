using UnityEngine;

public class Player : MonoBehaviour
{
    private // pas de :
    float vitesseY = 4f;
    Rigidbody2D rb;
    bool enCollision = false;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialisation du Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        // Deplacement 
        if (Input.GetKeyDown(KeyCode.Space) && !enCollision)
        {
            rb.velocity = new Vector3(0, vitesseY, 0);
        }
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
    if (collision.gameObject.CompareTag("Tuyau"))
        rb.velocity = new Vector2(0, 0);
        Debug.Log("Game Over !");
        enCollision = true;
    }
}
