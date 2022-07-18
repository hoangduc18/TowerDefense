using Assets.Script.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ObjectPool))]
public class TurretShoot : MonoBehaviour
{
    public List<Transform> bulletSpawns;
    public GameObject bulletPrefab;
    public float cooldown = 0.2f;
    private bool canShoot = true;
    private float currentCooldown = 0.0f;

    private ObjectPool bulletPool;
    [SerializeField]
    private int bulletPoolCount = 5;
    private GamePlayStateController state;
    private void Awake()
    {
        bulletPool = GetComponent<ObjectPool>();
    }
    // Start is called before the first frame update
    void Start()
    {
        bulletPool.Initialize(bulletPrefab, bulletPoolCount);
        state = GameObject.Find("GameManager").gameObject.GetComponent<GamePlayStateController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state.CurrentState == state.DefendState)
        {
            HandleShoot();
        }
    }

    public void HandleShoot()
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
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }
    }

    public void Shoot()
    {
        canShoot = false;
        currentCooldown = cooldown;

        foreach (var bullet in bulletSpawns)
        {
            //GameObject bulletObject = Instantiate(bulletPrefab);
            GameObject bulletObject = bulletPool.CreateGameObject();
            bulletObject.transform.position = bullet.position;
            bulletObject.transform.localRotation = bullet.rotation;
            bulletObject.GetComponent<Bullet>().Initialize();
        }
        
    }
}
