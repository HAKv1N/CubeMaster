using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Finish") && other.CompareTag("Player")) {
            select_level.lvls_complete[SceneManager.GetActiveScene().buildIndex] = true;
            try {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } finally {
                SceneManager.LoadScene("menu");
            }
        }
    }
}