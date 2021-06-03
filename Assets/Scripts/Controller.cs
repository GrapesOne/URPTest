using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public RectTransform Outer, Inner;
    public int CircleSize;
    public Vector3 Direction2D { private set; get; }

    public Vector3 DirectionXY => Direction2D;

    public Vector3 DirectionXZ => new Vector3(Direction2D.x,0,Direction2D.y);
    private Vector3 temp;
    private bool touched;
    public static Controller Instance  { private set; get; }

    void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        if (Input.touchCount == 1 || Input.GetMouseButton(0))
        {
            var v = Input.mousePosition - temp;
            v = Vector3.Magnitude(v) > CircleSize ? Vector3.Normalize(v)*CircleSize : v;
            Inner.position = temp+v;
            Direction2D = v / CircleSize;
            if(touched) return;
            temp = Input.mousePosition;
            Outer.position = Input.mousePosition;
            Outer.gameObject.SetActive(true);
            Inner.gameObject.SetActive(true);
            touched = true;
        }
        else
        {
            if(!touched) return;
            temp = Vector3.zero;
            Direction2D = Vector3.zero;
            Outer.gameObject.SetActive(false);
            Inner.gameObject.SetActive(false);
            touched = false;
        }
    }
}
