using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TakeDamage : MonoBehaviour
{
    public BaseEnemySO EnemyInfo;
    [SerializeField]
    private float currentHealth;
    public float CurrentHealth
    {
        get { return currentHealth; }
        set
        {
            currentHealth = value;
            OnHealthChange?.Invoke((float)CurrentHealth / EnemyInfo.health);
        }
    }

    public UnityEvent OnDead;
    public UnityEvent<float> OnHealthChange;
    public UnityEvent OnHit;



    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = EnemyInfo.health;
    }

    // Update is called once per frame
    void Update()
    {

    }
    internal void Hit(float damage)
    {
        CurrentHealth -= damage;
        if(CurrentHealth <= 0)
        {
            OnDead?.Invoke();
        }
        else
        {
            OnHit?.Invoke();
        }
    }
}