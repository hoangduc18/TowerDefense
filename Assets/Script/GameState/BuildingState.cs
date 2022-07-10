using Assets.Script.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingState : MonoBehaviour, IGameState
{
    private GameController _gameController;
    public void Handle(GameController gameController)
    {
        if (!_gameController)
        {
            _gameController = gameController;
        }
        _gameController.IsBuilding = true;
    }
}
