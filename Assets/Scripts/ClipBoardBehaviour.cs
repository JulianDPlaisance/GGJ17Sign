using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipBoardBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SendMessageUpwards("Autograph");
            gameObject.SendMessageUpwards("FanErgy");
            collision.gameObject.SendMessage("PlayRandomClip");
            gameObject.SendMessageUpwards("PlayRandomClip");
            Destroy(gameObject);

        }
    }
}
