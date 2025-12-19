using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float PlayerSpeed = 5.0f;

    private Rigidbody2D _rb;
    private float _hori;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _hori = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = new Vector2(_hori * PlayerSpeed, _rb.linearVelocity.y);
    }
}