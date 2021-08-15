using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    private int _scorePlayer1 = 0;
    private int _scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalWin;
    private Text _uiScorePlayer2;
    private Text _uiScorePlayer1;

    private void Start()
    {
        _uiScorePlayer1 = scoreTextPlayer1.GetComponent<Text>();
        _uiScorePlayer2 = scoreTextPlayer2.GetComponent<Text>();
    }

    private void Update()
    {
        if (_scorePlayer1 >= goalWin || _scorePlayer2 >= goalWin)
        {
            Debug.Log("Game Won");
        }        
        
    }

    private void FixedUpdate()
    {
        _uiScorePlayer1.text = $"{_scorePlayer1}";
        _uiScorePlayer2.text = $"{_scorePlayer2}";
    }

    public void GoalPlayer1()
    {
        _scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        _scorePlayer2++;
    }
}
