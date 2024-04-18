using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstructClass;

public class AbstructFactor_Hp : UltraAbstructFactor
{
    public override AbstructMouse CreatMouse()
    {
        return new HpMouse();
    }
    public override AbstructKeyboard CreatKeyboard()
    {
        return new HpKeyboard();
    }
}


