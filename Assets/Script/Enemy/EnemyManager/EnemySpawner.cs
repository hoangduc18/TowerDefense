using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [System.Serializable]
    public class Wave
    {
        public int count;
        public GameObject enemies;
        public float rate;
    }

    public List<BasicEnemy> enemySpawns;
    public BasicEnemy enemy;
    public Transform[] targets;
    public Wave[] wave;   
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            BasicEnemy _clone = Instantiate<BasicEnemy>(enemy.Clone() as BasicEnemy);
            _clone.Waypoint = targets; 
            enemySpawns.Add(_clone);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
