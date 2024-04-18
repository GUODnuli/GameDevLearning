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
        // RunFactor();
        RunAbstructFactor();
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

    void RunAbstructFactor()
    {
        AbstructFactor_Hp Hp = new();
        AbstructMouse hpmouse = Hp.CreatMouse();
        AbstructKeyboard hpkeyboard = Hp.CreatKeyboard();

        hpmouse.Print();
        hpkeyboard.Print();

        AbstructFactor_Apple Apple = new();
        AbstructMouse applemouse = Apple.CreatMouse();
        AbstructKeyboard applekeyboard = Apple.CreatKeyboard();

        applemouse.Print();
        applekeyboard.Print();

        AbstructFactor_Dell Dell = new();
        AbstructMouse dellmouse = Dell.CreatMouse();
        AbstructKeyboard dellkeyboard = Dell.CreatKeyboard();

        dellmouse.Print();
        dellkeyboard.Print();
    }
}
