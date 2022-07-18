using Assets.Script.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayStateController : MonoBehaviour
{
    private GamePlayBaseState currentState;
    public GamePlayBaseState CurrentState { get { return currentState; } }
    public ReadyState ReadyState = new ReadyState();
    public DefendState DefendState = new DefendState();
    public GameOverState GameOverState = new GameOverState();
    [SerializeField]
    public Button ReadyButton;
    public float PlayerHealth;
    public float Gold;
    public float Point;
    public bool isWaveEnd;
    void Start()
    {
        currentState = ReadyState;
        PlayerHealth = 100f;
        Gold = 0f;
        Point = 0f;
        isWaveEnd = true;
    }

    void Update()
    {
        currentState.Handle(this);
    }

    public void SwitchCurrentState(GamePlayBaseState state)
    {
        currentState = state;
    }
}
