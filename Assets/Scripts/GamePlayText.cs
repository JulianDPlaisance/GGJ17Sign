using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayText : MonoBehaviour
{
    public GameObject evilPanel;
	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 0;
	}

    public void Resume()
    {
        evilPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
