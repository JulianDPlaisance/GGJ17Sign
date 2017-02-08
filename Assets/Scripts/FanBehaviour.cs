using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanBehaviour : MonoBehaviour
{
    bool hasBeenAutographed = false;
    float sinWave;
    public GameObject player;
    Color colour;
    public int FanergyAmt = 3;

    public AudioClip[] clips;

    public void PlayRandomClip()
    {
        AudioSource.PlayClipAtPoint(clips[Random.Range(0, clips.Length)], gameObject.transform.position, 1);
    }

    void Start()
    {
        colour = Random.ColorHSV(0, 1, 1, 1, 0, 1);
    }


    // Update is called once per frame
    void Update()
    {
        
        gameObject.GetComponent<Light>().intensity = 0;

        if (hasBeenAutographed)
        {
            sinWave += Mathf.PI / 16;
            transform.Translate(0.0f, 5f * Time.deltaTime * Mathf.Sin(sinWave), 0.0f);
            gameObject.GetComponent<Light>().intensity = 5;
            gameObject.GetComponent<Light>().color = colour;
        }
        else
        {
            transform.LookAt(player.transform);
        }
    }

    void Autograph()
    {
        hasBeenAutographed = true;
    }

    void FanErgy()
    {
        player.GetComponent<PlayerController>().addFanergy(FanergyAmt);
    }


}
