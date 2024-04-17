using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factor {
    public class SimpleFactor
    {
        public AbstructClass.AbstructMouse CreateMouse(MouseType emMouseType)
        {
            AbstructClass.AbstructMouse mouse = null;
            switch (emMouseType)
            {
                case MouseType.Hp:
                    mouse = new HpMouse();
                    break;
                case MouseType.Dell:
                    mouse = new DellMouse();
                    break;
                default:
                    break;
            }
            return mouse;
        }
    }
}
