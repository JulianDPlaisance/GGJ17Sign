using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditSequence : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
