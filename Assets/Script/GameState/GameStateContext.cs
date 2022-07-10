using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.GameState
{
    public class GameStateContext
    {
        public IGameState CurrentState { get; set; }
        private readonly GameController _gameController;

        public GameStateContext(GameController gameController)
        {
            _gameController = gameController;
        }
        public void Transition()
        {
            CurrentState.Handle(_gameController);
        }
        public void Transition(IGameState state)
        {
            CurrentState = state;
            CurrentState.Handle(_gameController);
        }
    }
}
