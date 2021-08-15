using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayerRight : MonoBehaviour
{
    public float movementSpeed = 400f;
    private Rigidbody2D _rigidbody2D;


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");
        _rigidbody2D.velocity = new Vector2(0, v) * movementSpeed;
    }
}
