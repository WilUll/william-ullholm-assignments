using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : ProcessingLite.GP21
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float axis1 = 10;
        float numberOfLines = 20;

        for (int i = 0; i <= numberOfLines; i++)
        {
            if (axis1 >= i)
            {
                Line(0, (axis1 - i), (0 + i), 0);
            }
            else
            {
                Line(0, (axis1 - i), (numberOfLines - i), 0);
            }

        }
    }
}
