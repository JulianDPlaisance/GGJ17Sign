using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

	public void Quit()
    {
        Application.Quit();
    }

    public void OpenTheGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    
    public void Credits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
