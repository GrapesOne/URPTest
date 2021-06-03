using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectionist : MonoBehaviour
{
    public Transform Target,Owner;
    public float Smoothness;

    private Vector3 MovingVector;
    void Start()
    {
       
    }

   
    void Update()
    {
        Owner.position = Vector3.SmoothDamp(Owner.position, Target.position, ref MovingVector,
            Time.deltaTime * Smoothness);
    }
}
