using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsychoFanBehaviour : MonoBehaviour
{

    bool hasBeenAutographed = false;
    float sinWave;
    public GameObject player;
    bool hasBeenCopped = false;

    public AudioClip clips;

    public void PlayRandomClip()
    {
        AudioSource.PlayClipAtPoint(clips, gameObject.transform.position);
    }


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        gameObject.GetComponent<Light>().intensity = 0;

        if (hasBeenAutographed)
        {
            if (!hasBeenCopped)
            {
                sinWave += Mathf.PI / 16;
                transform.Translate((player.transform.position.x - gameObject.transform.position.x) * 0.75f * Time.deltaTime, 5f * Time.deltaTime * Mathf.Sin(sinWave),
                    (player.transform.position.z - gameObject.transform.position.z) * Time.deltaTime * 0.75f);
                gameObject.GetComponent<Light>().intensity = 20;
                gameObject.GetComponent<Light>().range = 15;
                gameObject.GetComponent<Light>().color = Color.red;
            }
            else
            {
                sinWave += Mathf.PI / 32;
                transform.Translate(0.0f, 3f * Time.deltaTime * Mathf.Sin(sinWave), 0.0f);
            }
        }
    }

    void Autograph()
    {
        hasBeenAutographed = true;
    }

    public void Copped()
    {
        hasBeenCopped = true;
        Destroy(gameObject.GetComponent<Rigidbody>());
        Destroy(gameObject.GetComponent<Collider>());
    }

    void FanErgy()
    {
        player.GetComponent<PlayerController>().addFanergy(5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasBeenAutographed)
        {
            if(!hasBeenCopped)
                player.GetComponent<PlayerController>().addFanergy(-2);
        }
    }
}
