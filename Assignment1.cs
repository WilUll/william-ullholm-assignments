using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        Background(0);
        
        DrawW();

        DrawI1();

        DrawL1();

        DrawL2();

        DrawI2();

        DrawA();

        DrawM();
    }

    private void DrawW(float x = 0, float y = 0)
    {
        //Draws the letter W
        Line(x + 1, y + 4, x + 1, y + 1);
        Line(x + 1, y + 1, x + 2, y + 2);
        Line(x + 2, y + 2, x + 3, y + 1);
        Line(x + 3, y + 1, x + 3, y + 4);
    }

    private void DrawI1(float x = 0, float y = 0)
    {
        //Draws the letter I
        Line(x + 4, y + 1, x + 4, y + 4);
    }

    private void DrawL1(float x = 0, float y = 0)
    {
        //Draws the letter L
        Line(x + 5, y + 1, x + 5, y + 4);
        Line(x + 5, y + 1, x + 6, y + 1);
    }

    private void DrawL2(float x = 0, float y = 0)
    {
        //Draws the letter L
        Line(x + 7, y + 1, x + 7, y + 4);
        Line(x + 7, y + 1, x + 8, y + 1);
    }

    private void DrawI2(float x = 0, float y = 0)
    {
        //Draws the letter I
        Line(x + 9, y + 1, x + 9, y + 4);
    }

    private void DrawA(float x = 0, float y = 0)
    {
        //Draws the letter A
        Line(x + 10, y + 1, x + 10, y + 4);
        Line(x + 10, y + 4, x + 11, y + 4);
        Line(x + 11, y + 1, x + 11, y + 4);
        Line(x + 10, y + 2, x + 11, y + 2);
    }

    private void DrawM(float x = 0, float y = 0)
    {
        //Draws the letter M
        Line(x + 12, y + 1, x + 12, y + 4);
        Line(x + 12, y + 4, x + 13, y + 3);
        Line(x + 13, y + 3, x + 14, y + 4);
        Line(x + 14, y + 1, x + 14, y + 4);
    }
}
