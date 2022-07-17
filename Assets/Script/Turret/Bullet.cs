using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float damage = 5f;
    [SerializeField]
    private float maxDistance = 100f;

    private Vector2 startPosition;
    private float traveledDistance = 0;
    private Rigidbody2D rgb2d;


    private void Awake()
    {
        rgb2d = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        traveledDistance = Vector2.Distance(transform.position, startPosition);
        if (traveledDistance >= maxDistance)
        {
            DisableObject();
        }
    }

    private void DisableObject()
    {
        rgb2d.velocity = Vector2.zero;
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided " + collision.name);
        var damageTaken = collision.GetComponent<TakeDamage>();
        if(damageTaken != null)
        {
            damageTaken.Hit(damage);
        }
        DisableObject();
    }

    public void Initialize()
    {
        startPosition = transform.position;
        rgb2d.velocity = transform.up * speed;
    }
}
