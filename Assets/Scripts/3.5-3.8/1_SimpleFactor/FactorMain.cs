using System.Collections;
using System.Collections.Generic;
using Factor;
using AbstructClass;
using UnityEngine;

public enum MouseType
{
    None,
    Hp,
    Dell
}
public class FactorMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // RunNormal();
        RunSimpleFactor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RunNormal()
    {
        AbstructClass.AbstructMouse Hpmouse = new HpMouse();
        Hpmouse.Print();
        AbstructClass.AbstructMouse Dellmouse = new DellMouse();
        Dellmouse.Print();
    }

    void RunSimpleFactor()
    {
        SimpleFactor simpleFactor = new SimpleFactor();
        AbstructMouse dellmouse = simpleFactor.CreateMouse(MouseType.Dell);
        AbstructMouse hpmouse = simpleFactor.CreateMouse(MouseType.Hp);

        dellmouse.Print();
        hpmouse.Print();
    }
}
