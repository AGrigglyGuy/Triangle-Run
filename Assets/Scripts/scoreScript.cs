using UnityEngine;


public class scoreScript : MonoBehaviour
{
    
    public bool pointScored = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!pointScored) {
            if (other.CompareTag("player"))
            {
                scoreManager.Instance.addScore(1);
                pointScored = true;
                Debug.Log($"Collided! Score:{score}");
            }
        }
        
    }
}
