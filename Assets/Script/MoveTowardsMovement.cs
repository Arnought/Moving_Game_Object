using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsMovement : MonoBehaviour
{
    public Vector3 pointA = new Vector3(-5f, 4f, 0f);
    public Vector3 pointB = new Vector3(5f, 4f, 0f);
    public float speed = 1f;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = pointA;
        target = pointB;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position == target)
        {
            if (target == pointB)
            {
                target = pointA;
            }
            else
            {
                target = pointB;
            }
        }
    }
}
