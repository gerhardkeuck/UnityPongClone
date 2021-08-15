using UnityEngine;

public class RacketPlayerLeft : MonoBehaviour
{
    public float movementSpeed = 400f;
    private Rigidbody2D _rigidbody2D;


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        _rigidbody2D.velocity = new Vector2(0, v) * movementSpeed;
    }
}