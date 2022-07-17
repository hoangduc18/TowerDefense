using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    public List<Transform> bulletSpawns;
    public GameObject bulletPrefab;
    public float cooldown = 1.0f;
    private bool canShoot = true;

    //private Collider2D[] enemyColliders;
    private float currentCooldown = 0.0f;
    // Start is called before the first frame update
     void Awake()
    {
        //GetComponentInChildren<TurretShoot>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!canShoot)
        {
            currentCooldown -= Time.deltaTime;
            if (currentCooldown <= 0.0f)
            {
                canShoot = true;
            }
        }
        else
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            currentCooldown = cooldown;

            foreach (var bullet in bulletSpawns)
            {
                GameObject bulletObject = Instantiate(bulletPrefab);
                bulletObject.transform.position = bullet.position;
                bulletObject.transform.localRotation = bullet.rotation;
                bulletObject.GetComponent<Bullet>().Initialize();
            }
        }
    }
}
