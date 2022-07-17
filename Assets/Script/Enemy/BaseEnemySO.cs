using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Enemy", menuName ="Enemy")]
public class BaseEnemySO : ScriptableObject
{
    public int health;
    public float speed;
    public float goldReward;
    public int point;
}
