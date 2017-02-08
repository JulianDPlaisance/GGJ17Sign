using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float showYMove;
    public float Fanergy = 5.5f;
    public Text fanergyText;

    public AudioClip[] clips;

    public void PlayRandomClip()
    {
        AudioSource.PlayClipAtPoint(clips[Random.Range(0, clips.Length)], gameObject.transform.position, 5);
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
        if (Time.timeScale != 0)
        {
            if (Fanergy <= 0.0f)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
            else
            {
                Fanergy -= 0.01f;
            }
            fanergyText.text = "Fanergy: " + Fanergy.ToString("F2");
        }
	}

    void Movement ()
    {
        float xmove = Input.GetAxis("Horizontal") * Time.deltaTime * 150f;
        float zmove = Input.GetAxis("Vertical") * Time.deltaTime * 10f;
        float ymove = 0.0f;
        if(Input.GetKey(KeyCode.Space))
        {
            if (ymove < Time.deltaTime * 0.05f)
            {
                ymove += Time.deltaTime * 10f;
            }
            else
            {
                ymove = Time.deltaTime * 0.15f;
            }
        }
        else
        {
            ymove = 0.0f;
        }
        showYMove = ymove;
        transform.Translate(0.0f, ymove, zmove);
        transform.Rotate(0.0f, xmove, 0.0f);
    }

    public void addFanergy(float amount)
    {
        Fanergy += amount;
    }
}
