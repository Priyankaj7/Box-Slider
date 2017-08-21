using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gamehasended = false;
    public float restartdelay = 1f;
    public GameObject levelcompleteUI;
    public void CompleteLevel()
    {
        levelcompleteUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartdelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
