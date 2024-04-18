using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstructClass;


public class AbstructFactor_Apple : UltraAbstructFactor
{
    public override AbstructMouse CreatMouse()
    {
        return new AppleMouse();
    }
    public override AbstructKeyboard CreatKeyboard()
    {
        return new AppleKeyboard();
    }
}
