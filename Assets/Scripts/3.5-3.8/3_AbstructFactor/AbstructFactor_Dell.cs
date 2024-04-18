using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstructClass;

public class AbstructFactor_Dell : UltraAbstructFactor
{
    public override AbstructMouse CreatMouse()
    {
        return new DellMouse();
    }
    public override AbstructKeyboard CreatKeyboard()
    {
        return new DellKeyboard();
    }
}
