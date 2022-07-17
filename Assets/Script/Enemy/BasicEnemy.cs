using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour,ICloneable
{
    public BaseEnemySO enemyInfo;


    private int _heath;
    private List<Transform> _listCheckpoint;

    public List<Transform> ListCheckpoint { set { _listCheckpoint = value; } }
    public object Clone()
    {
        return this.MemberwiseClone() as BasicEnemy;
    }

    // Start is called before the first frame update
    void Start()
    {
        _heath = enemyInfo.health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
