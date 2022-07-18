using Assets.Script.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 150;
    private GamePlayStateController state;
    // Start is called before the first frame update
    void Start()
    {
        state = GameObject.Find("GameManager").gameObject.GetComponent<GamePlayStateController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state.CurrentState == state.DefendState)
        {
            Aim(Input.mousePosition);
        }
    }

    public void Aim(Vector2 inputMousePosition)
    {
        var turretDirection = 
            Camera.main.ScreenToWorldPoint(inputMousePosition) - transform.position;
        var finalAngle = 
            Mathf.Atan2(turretDirection.y, turretDirection.x)
            * Mathf.Rad2Deg;
        var rotationStep = rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(
            transform.rotation, Quaternion.Euler(0, 0, finalAngle)
            , rotationStep);
    }
}
