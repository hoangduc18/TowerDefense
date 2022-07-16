using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.GameState
{
    public class DefendState : GamePlayBaseState
    {
        public override void Handle(GamePlayStateController controller)
        {
            if (controller.PlayerHealth <= 0)
            {
                controller.SwitchCurrentState(controller.GameOverState);
            }
            if(controller.isWaveEnd)
            {
                controller.SwitchCurrentState(controller.ReadyState);
            }
        }
    }
}
