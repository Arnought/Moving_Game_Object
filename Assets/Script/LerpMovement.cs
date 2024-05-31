using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovement : MonoBehaviour
{
    public Vector3 pointA = new Vector3 (-5f, 0f, 0f);
    public Vector3 pointB = new Vector3 (5f, 0f, 0f);
    public float speed = 1f;
    private float startTime;
    private float timeLength;

    private bool move = true;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = pointA;
        startTime = Time.time;
        timeLength = Vector3.Distance (pointA, pointB);
    }

    // Update is called once per frame
    void Update()
    {
        float dist = (Time.time - startTime) * speed;
        float travelTime = dist / timeLength;
        
        if(move )
        {
            transform.position = Vector3.Lerp(pointA, pointB, travelTime);
            if(travelTime >= 1f)
            {
                move = false;
                startTime = Time.time;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(pointB, pointA, travelTime);
            if(travelTime >= 1f)
            {
                move = true;
                startTime = Time.time;
            }
        }
    }
}
