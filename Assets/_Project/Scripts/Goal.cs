using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<PlayerMovement>();

        if (player == null) { return; }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
