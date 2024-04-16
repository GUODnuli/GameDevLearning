using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rectangle rectangle = new()
        {
            iLength = 10,
            iWidth = 20,
            strColor = "Red",
            strName = "Rectangle"
        };
        rectangle.ShowProperty();
        rectangle.ShowArea();

        Square square = new()
        {
            iLength = 10,
            iWidth = 10,
            strColor = "Blue",
            strName = "Square"
        };
        square.ShowProperty();
        square.ShowArea();

        Triangle triangle = new()
        {
            iLength = 10,
            iWidth = 20,
            strColor = "Green",
            strName = "Triangle"
        };

        triangle.ShowProperty();
        triangle.ShowArea();

        Polygon polygon1 = rectangle;
        polygon1.ShowName();

        polygon1 = triangle;
        polygon1.ShowName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Polygon
{
    public int iLength { get; set; }
    public int iWidth { get; set; }
    public string strColor { get; set; }
    public string strName { get; set; }

    protected float Area()
    {
        return iLength * iWidth;
    }

    public void ShowProperty()
    {
        Debug.LogFormat("Length: {0}, Width: {1}, Color: {2}, Name: {3}\n", iLength, iWidth, strColor, strName);
    }

    public void ShowArea()
    {
        Debug.LogFormat("Area: {0}\n", Area());
    }

    public virtual void ShowName()
    {
        Debug.LogFormat("Name: {0}\n", strName);
    }
}

class Rectangle : Polygon
{
    public Rectangle()
    {

    }

    ~Rectangle()
    {

    }

    public override void ShowName()
    {
        Debug.LogFormat("Name: {0}\n", strName);
    }
}

class Square : Polygon
{
    public Square()
    {

    }

    ~Square()
    {

    }
}

class Triangle : Polygon
{
    public Triangle()
    {

    }

    ~Triangle()
    {

    }

    private new float Area()
    {
        return (iLength * iWidth) / 2;
    }

    public new void ShowArea()
    {
        Debug.LogFormat("Area: {0}\n", Area());
    }

    public override void ShowName()
    {
        Debug.LogFormat("Name: {0}\n", strName);
    }
}