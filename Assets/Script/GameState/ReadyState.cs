using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.GameState
{
    public class ReadyState : GamePlayBaseState
    {
        public override void Handle(GamePlayStateController controller)
        {
            controller.ReadyButton.onClick.AddListener(delegate { ReadyOnClick(controller); } );
        }

        private void ReadyOnClick(GamePlayStateController controller)
        {
            controller.isWaveEnd = false;
            GameObject button = GameObject.Find("ReadyButton");
            if (button != null)
            {
                button.SetActive(false);
            }
            controller.SwitchCurrentState(controller.DefendState);
        }
    }
}
