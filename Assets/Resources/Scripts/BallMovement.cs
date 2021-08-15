using System;
using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedPerHit = 0;
    public float maxExtraSpeed;

    private int hitCounter = 0;


    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        StartCoroutine(StartBall());
    }

    void PositionBall(bool isStartingPlayer1)
    {
        _rigidbody2D.velocity = Vector2.zero;

        if (isStartingPlayer1)
        {
            gameObject.transform.position = new Vector3(-100, 0, 0);
        }
        else
        {
            gameObject.transform.position = new Vector3(100, 0, 0);
        }
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        PositionBall(isStartingPlayer1);
        
        hitCounter = 0;
        yield return new WaitForSeconds(2f);

        if (isStartingPlayer1)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
    }

    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = movementSpeed + hitCounter * extraSpeedPerHit;
        if (speed > maxExtraSpeed)
        {
            speed = maxExtraSpeed;
        }

        _rigidbody2D.velocity = dir * speed;
    }

    public void IncreateHitCount()
    {
        if (hitCounter * extraSpeedPerHit + movementSpeed < maxExtraSpeed)
        {
            hitCounter++;
        }
    }
}