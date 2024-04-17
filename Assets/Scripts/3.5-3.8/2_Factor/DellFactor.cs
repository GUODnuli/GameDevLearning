using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DellFactor : AbstructClass.AbstructFactor
{
    public override AbstructMouse CreatMouse()
    {
        return new DellMouse();
    }
}
