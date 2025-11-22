using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    public GameObject successPanel;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Finish Trigger touched by: " + other.name);
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER FINISHED – Activating SuccessPanel");
            successPanel.SetActive(true);

            Time.timeScale = 0f;
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
