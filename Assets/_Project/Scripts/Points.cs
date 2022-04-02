using System;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private float givenTime;

    private GameManager _gameManager;

    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<PlayerMovement>();

        if (player == null) { return; }
        
        _gameManager.AddTime(givenTime);
        Destroy(this.gameObject);
    }
}
