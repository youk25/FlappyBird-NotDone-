using UnityEngine;

public class gameManager : MonoBehaviour
{
    private int points = 0;
    
    public void AddPoints()
    {
        points += 1;
        Debug.Log("Score: " + points);
    }
    public void GameOver()
    {
        Debug.Log("Game Over !");
    }
}
