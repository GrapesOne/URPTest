using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 Offset;
    public float Speed;
    public Material Cubes;
    private int ID;
    void Start()
    {
        ID = Shader.PropertyToID("Vector3_0834d080f4e247578475c91e45b528ca");
    }

    // Update is called once per frame
    void Update()
    {
        Cubes.SetVector(ID, transform.parent.position+Offset);
        transform.Rotate(Vector3.up, Time.deltaTime*Speed);
    }
}
