using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public List<BasicEnemy> enemySpawns;
    public BasicEnemy enemy;
    public List<Transform> targets;
    void Start()
    {
       var _enemy = Instantiate<BasicEnemy>(enemy,transform);
        for (int i = 0; i < 10; i++)
        {
            BasicEnemy _clone = _enemy.Clone() as BasicEnemy;
            Instantiate(_clone, transform);
            _clone.ListCheckpoint = targets; 
            enemySpawns.Add(_clone);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
