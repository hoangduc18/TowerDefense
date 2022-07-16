using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.GameState
{
    public class GameOverState : GamePlayBaseState
    {
        public override void Handle(GamePlayStateController controller)
        {
            Debug.Log("GameOver");
        }
    }
}
