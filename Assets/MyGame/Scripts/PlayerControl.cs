using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;
    public Transform PointC;
    public Transform PointD;
    public float speed = 20f;
    private Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = PointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == PointA.position)
        {
            targetPos = PointB.position;
        }
        else if (transform.position == PointB.position)
        {
            targetPos = PointC.position; 
        }
        else if (transform.position == PointC.position)
        { 
            targetPos = PointD.position; 
        }
        else if (transform.position == PointD.position)
        {
            targetPos = PointA.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
        transform.LookAt(targetPos);
    }
}
