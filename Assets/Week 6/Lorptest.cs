using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lorptest : MonoBehaviour
{
    public AnimationCurve curve;
    public Transform end;
    public Transform start;
    public float Lerptest;
    public Color start2;
    public Color end2;
    public SpriteRenderer SR;

    // Update is called once per frame
    void Update()
    {
        float interpo = curve.Evaluate(Lerptest);
        transform.position = Vector3.Lerp(start.position, end.position, Lerptest);
        Lerptest += Time.deltaTime;
        SR.color = Color.Lerp(start2, end2, interpo);
        
    }
}
