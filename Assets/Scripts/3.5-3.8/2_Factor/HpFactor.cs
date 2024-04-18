using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpFactor : AbstructClass.AbstructFactor
{
    public override AbstructMouse CreatMouse()
    {
        return new HpMouse();
    }
}
