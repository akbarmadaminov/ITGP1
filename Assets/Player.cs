using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int counter = 0;

    private void OnEnable()
    {
        counter = 0;
    }
}
