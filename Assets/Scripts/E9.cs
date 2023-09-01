using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E9 : MonoBehaviour
{
    private float a=1;
    private float b=5;

    void Update()
    {
        Sumar();
    }

    public void Sumar()
    {
        Debug.Log(a+b);
    }
}
