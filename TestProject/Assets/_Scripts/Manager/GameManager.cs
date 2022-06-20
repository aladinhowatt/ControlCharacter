using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Serializable]
    public enum GameState
    {
        Starting,
        Main,
        Ending
    }

    public GameState State;


    public void Start()
    {
        ChangeState(GameState.Starting);
    }

    public void ChangeState(GameState newState)
    {
        State = newState;

        switch(State)
        {
            case GameState.Starting:
                Debug.Log("Start game");
                break;
            case GameState.Main:
                break;
            case GameState.Ending:
                break;
        }
    }
}
