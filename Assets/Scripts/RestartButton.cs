using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{

	// Use this for initialization
	public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
