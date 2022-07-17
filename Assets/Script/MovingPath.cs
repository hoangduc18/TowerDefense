using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPath : MonoBehaviour
{
    [SerializeField]
    private float ObjectSpeed;
    private int nextPointIndex;
    [SerializeField]
    private Transform[] WayPoints;
    private Transform nextPoint;
    // Start is called before the first frame update
    void Start()
    {
        nextPoint = WayPoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        CreepWalk();
    }

    void CreepWalk()
    {
        if (transform.position == nextPoint.position)
        {
            nextPointIndex++;
            if(nextPointIndex < WayPoints.Length)
            {
                nextPoint = WayPoints[nextPointIndex];
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPoint.position, ObjectSpeed * Time.deltaTime);
        }
    }
}
