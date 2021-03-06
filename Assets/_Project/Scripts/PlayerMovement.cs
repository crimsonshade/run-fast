using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float speed = 8f;
    [SerializeField] private float jumpPower = 16f;
    
    private float _horizontal;
    
    private Rigidbody2D _rb;
    private AudioSource _audio;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_horizontal * speed, _rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    #region MOVEMENT

    public void Move(InputAction.CallbackContext context)
    {
        _horizontal = context.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpPower);
            _audio.Play();
        }

        if (context.canceled && _rb.velocity.y > 0f)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _rb.velocity.y * 0.5f);
        }
    }

    #endregion

    public void KillPlayer()
    {
        _rb.velocity = Vector2.zero;
        _rb.gravityScale = 0f;
        _horizontal = 0f;
    }
}
