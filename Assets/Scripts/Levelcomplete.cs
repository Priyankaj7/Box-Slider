using UnityEngine.SceneManagement;
using UnityEngine;

public class Levelcomplete : MonoBehaviour {

	public void LoadNextLevel()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                return;
            }
        }  
    }
}
