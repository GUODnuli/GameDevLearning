using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Visit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cat cat = new Cat("Tom");
        Mouse mouseA = new Mouse("Jerry", cat);
        Mouse mouseB = new Mouse("Mickey", cat);
        Mouse mouseC = new Mouse("Mini", cat);
        cat.Coming();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Animal
{
    
    protected string Name;

    public Animal(string Name)
    {
        this.Name = Name;
    }

    public virtual void Run()
    {
        
    }
}

public class Cat: Animal
{
    public Action RunActions;
    public Cat(string Name): base(Name)
    {
        
    }

    public void Coming()
    {
        Debug.LogFormat("{0} is coming.", Name);
        if (RunActions != null)
            { this.RunActions(); }
        this.Run();
    }

    public override void Run()
    {
        Debug.LogFormat("{0} is catching thoes mouses.", Name);
    }
}

public class Mouse: Animal
{
    public Mouse(string Name, Cat cat) : base(Name)
    {
        cat.RunActions += this.Run;
    }

    public override void Run()
    {
        Debug.LogFormat("{0} is running.", Name);
    }
}

//public class MouseB : Animal
//{
//    public MouseB(string Name) : base(Name)
//    {

//    }

//    public override void Run()
//    {
//        Debug.LogFormat("{0} is running.", strName);
//    }
//}

//public class MouseC : Animal
//{
//    public MouseC(string Name) : base(Name)
//    {

//    }

//    public override void Run()
//    {
//        Debug.LogFormat("{0} is running.", strName);
//    }
//}