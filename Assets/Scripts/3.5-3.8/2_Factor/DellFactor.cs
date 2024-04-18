using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstructClass;

public class DellFactor : AbstructClass.AbstructFactor
{
    public override AbstructMouse CreatMouse()
    {
        return new DellMouse();
    }
}
