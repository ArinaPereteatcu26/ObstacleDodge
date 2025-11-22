using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOverTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over! Restarting...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
