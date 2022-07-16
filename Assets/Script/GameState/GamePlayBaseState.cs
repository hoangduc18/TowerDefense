using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.GameState
{
    public abstract class GamePlayBaseState 
    {
        public abstract void Handle(GamePlayStateController controller);
    }
}
