using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planemove : MonoBehaviour
{
    public List<Vector2> points;
    public float newPositionTHreshold = 0.2f;
    Vector2 lastPosition;
    LineRenderer line;
    private void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 1;
        line.SetPosition(0, transform.position);
    }
    private void OnMouseDown()
    {
        points = new List<Vector2>();

        line.positionCount = 1;
        line.SetPosition(0, transform.position);
    }

    private void OnMouseDrag()
    {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Vector2.Distance(lastPosition, newPosition) > newPositionTHreshold)
        {
            points.Add(newPosition);
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, newPosition);
            lastPosition = newPosition;
        }

    }
}
