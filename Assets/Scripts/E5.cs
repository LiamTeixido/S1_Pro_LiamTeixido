using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] values = new int[4];
        values[0] = 4;
        values[1] = -3;
        values[2] = -5;
        values[3] = 1;

        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] < 0)
            {
                Debug.Log(values[i]);
            }
        }

    }
}
