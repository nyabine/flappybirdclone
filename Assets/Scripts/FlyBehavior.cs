using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    private Rigidbody2D _rb;

    public void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        // if (Mouse.current.leftButton.wasPressedThisFrame) {
        //     _rb.linearVelocity = Vector2.up * _velocity;
        // }

        // if (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.isPressed) {
        //     _rb.linearVelocity = Vector2.up * _velocity;
        // }

        // if (Input.touchCount > 0 && Input.GetTouch(0).phase == UnityEngine.TouchPhase.Began) {
        //     _rb.linearVelocity = Vector2.up * _velocity;
        // }
    }

    public void FixedUpdate() {
        transform.rotation = Quaternion.Euler(0, 0, _rb.linearVelocity.y * _rotationSpeed);
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        GameManager.instance.GameOver();
    }

    public void VelocityChange() {
        _rb.linearVelocity = Vector2.up * _velocity;
    }
}
