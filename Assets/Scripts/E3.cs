using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3 : MonoBehaviour
{
    void Start()
    {
        int n;
        int mana;
        n = 3;
        mana = 0;
        for (int i = 1; i <= n; i++)
        {
            mana = mana + i;
        }
        Debug.Log(mana);
    }

}
