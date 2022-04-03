using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Points : MonoBehaviour
{
    [SerializeField] private float givenTime;

    private GameManager _gameManager;
    private AudioSource _audio;
    private BoxCollider2D _boxCollider;
    private SpriteRenderer _sprite;

    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _audio = GetComponent<AudioSource>();
        _sprite = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<PlayerMovement>();

        if (player == null) { return; }
        
        _gameManager.AddTime(givenTime);
        _audio.Play();
        RemovePoint();
    }

    private void RemovePoint()
    {
        Destroy(_boxCollider);
        Destroy(_sprite);
    }
}
