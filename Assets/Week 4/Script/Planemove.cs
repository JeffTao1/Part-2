using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planemove : MonoBehaviour
{
    public List<Vector2> points;
    public float newPositionTHreshold = 0.2f;
    Vector2 lastPosition;
    LineRenderer line;
    Rigidbody2D rb;
    Vector2 currentPosition;
    public float speed = Random.Range(1f,3f);
    public AnimationCurve landing;
    float ltimer = 0;
    private void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 1;
        line.SetPosition(0, transform.position);
        rb = GetComponent<Rigidbody2D>();





    }

    private void FixedUpdate()
    {
        currentPosition = transform.position;
        if (points.Count > 0) {
            Vector2 direction = points[0] - currentPosition;
            float angle = Mathf.Atan2(direction.x,direction.y) * Mathf.Rad2Deg;
            rb.rotation =  -angle;


        }
        rb.MovePosition(rb.position + (Vector2)transform.up * speed * Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {

            ltimer += 0.5f * Time.deltaTime;
            float interpolation = landing.Evaluate(ltimer);
            if (transform.localScale.z < 0.1f) 
            {
                Destroy(gameObject);
            }
            transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, interpolation);
        
        }

        line.SetPosition(0, transform.position);
        if (points.Count>0)
        {
            if (Vector2.Distance(currentPosition, points[0]) < newPositionTHreshold) 
            { 
            
                points.RemoveAt(0);
                for (int i = 0; i < line.positionCount - 2; i++) 
                {
                    line.SetPosition(i, line.GetPosition(i + 1));
                
                }
                line.positionCount--;
            
            }
        }
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