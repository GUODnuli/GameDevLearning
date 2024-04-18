using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstructClass;

public class AppleFactor : AbstructClass.AbstructFactor
{
    public override AbstructMouse CreatMouse()
    {
        return new AppleMouse();
    }
}
