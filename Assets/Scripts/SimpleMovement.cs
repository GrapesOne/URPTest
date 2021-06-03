using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public Controller controller;
    public bool xzAxis;
    public float speed = 3;
  
    void Start()
    {
        if(controller==null) controller = Controller.Instance;
    }
    void Update()
    {
        if(xzAxis) transform.position += controller.DirectionXZ * Time.deltaTime * speed;
        else transform.position += controller.DirectionXY * Time.deltaTime * speed;
    }
}
