using System.Collections;
using System.Collections.Generic;
using Factor;
using AbstructClass;
using UnityEngine;

public enum MouseType
{
    None,
    Hp,
    Dell,
    Apple
}
public class FactorMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // RunNormal();
        // RunSimpleFactor();
        RunFactor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RunNormal()
    {
        AbstructMouse Hpmouse = new HpMouse();
        Hpmouse.Print();
        AbstructMouse Dellmouse = new DellMouse();
        Dellmouse.Print();
    }

    void RunSimpleFactor()
    {
        SimpleFactor simpleFactor = new();
        AbstructMouse dellmouse = simpleFactor.CreateMouse(MouseType.Dell);
        AbstructMouse hpmouse = simpleFactor.CreateMouse(MouseType.Hp);

        dellmouse.Print();
        hpmouse.Print();
    }

    void RunFactor()
    {
        DellFactor dellFactor = new();
        HpFactor hpFactor = new();
        AppleFactor appleFactor = new();

        AbstructMouse dellmouse = dellFactor.CreatMouse();
        AbstructMouse hpmouse = hpFactor.CreatMouse();
        AbstructMouse applemouse = appleFactor.CreatMouse();

        dellmouse.Print();
        hpmouse.Print();
        applemouse.Print();
    }
}
