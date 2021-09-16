using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{
    public Vector2 circlePosition;
    public Vector2 linePosition;
    public float diameter = 2;
    public float speed;
    public Vector2 circleSpeed;

    private Vector2 betweenCL;


    // Update is called once per frame
    void Update()
    {
        Background(0);
        Fill(255, 255, 255);
        if (Input.GetMouseButton(0))
        {
            linePosition.x = MouseX;
            linePosition.y = MouseY;

            Line(circlePosition.x, circlePosition.y, linePosition.x, linePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            speed = linePosition.magnitude;
            if (speed > 20)
            {
                speed = 20;
            }
            betweenCL = circlePosition - linePosition;
            betweenCL.Normalize();
            circleSpeed = betweenCL * speed * Time.deltaTime;
        }

        if (circlePosition.y > (Height - diameter/2) || circlePosition.y < diameter/2)
        {
            circleSpeed.y = circleSpeed.y * -1;
        }

        if (circlePosition.x > (Width - diameter / 2) || circlePosition.x < diameter/2)
        {
            circleSpeed.x = circleSpeed.x * -1;
        }
        Circle(circlePosition.x += circleSpeed.x, circlePosition.y += circleSpeed.y, diameter);
    }
}
