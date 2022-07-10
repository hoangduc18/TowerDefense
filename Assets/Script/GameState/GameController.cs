using Assets.Script.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool IsBuilding { get; set; }
    public bool IsDefending { get; set; }
    private IGameState _buildingState, _defendState;
    private GameStateContext _gameStateContext;

    // Start is called before the first frame update
    void Start()
    {
        IsBuilding = true;
        IsDefending = false;
        _gameStateContext = new GameStateContext(this);
        _buildingState = gameObject.AddComponent<BuildingState>();
        _defendState = gameObject.AddComponent<DefendState>();

        _gameStateContext.Transition(_buildingState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
