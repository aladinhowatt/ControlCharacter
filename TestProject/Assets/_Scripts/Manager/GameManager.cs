using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    [Serializable]
    public enum GameState
    {
        Starting,
        Main,
        Ending
    }

    public GameState State;

    [SerializeField]
    private PlayerManager playerManager;

    [SerializeField]
    private InputManager inputManager;

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
                ChangeState(GameState.Main);
                break;
            case GameState.Main:


                break;
            case GameState.Ending:
                break;
        }
    }


}
