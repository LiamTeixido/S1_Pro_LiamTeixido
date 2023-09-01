using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i;
        int n;
        i = 1;
        n = 20;
        while (n % i == 0)
        {
            Debug.Log(i);
            i++;
        }
    }
}
