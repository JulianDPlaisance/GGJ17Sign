using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        else
            Destroy(collision.gameObject);
    }
}
