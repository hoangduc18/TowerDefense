using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour, ICloneable
{
    public BaseEnemySO enemyInfo;
    private int nextPointIndex;
    [SerializeField]
    private Transform[] _wayPoints;
    private Transform nextPoint;
    private GamePlayStateController state;
    private int _heath;

    public Transform[] Waypoint { get { return _wayPoints; } set { _wayPoints = value; } }


    public object Clone()
    {
        return this.MemberwiseClone() as BasicEnemy;
    }

    // Start is called before the first frame update
    void Start()
    {
        state = GameObject.Find("GameManager").gameObject.GetComponent<GamePlayStateController>();
        _heath = enemyInfo.health;
        nextPoint = _wayPoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (state.CurrentState == state.DefendState)
        {
            CreepWalk();
        }
    }

    void CreepWalk()
    {
        if (transform.position == nextPoint.position)
        {
            nextPointIndex++;
            if (nextPointIndex < _wayPoints.Length)
            {
                nextPoint = _wayPoints[nextPointIndex];
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPoint.position, enemyInfo.speed * Time.deltaTime);
        }
    }
}
