using System;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "PlayerLeft")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        ballMovement.IncreateHitCount();
        ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PlayerLeft" || collision.gameObject.name == "PlayerRight")
        {
            BounceFromRacket(collision);
        }
        else if (collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Collision with WallLeft");
            scoreController.GoalPlayer2();
            StartCoroutine(ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collision with WallRight");
            scoreController.GoalPlayer1();
            StartCoroutine(ballMovement.StartBall(false));
        }
    }
}