using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using UnityEngine;

public class Hero : MonoBehaviour {

    public Rigidbody Ball;
    public bool Grounded;
    public float speed = 50f;


    private void OnCollisionEnter()
    {
        Grounded = true;
    }
    private void OnCollisionExit()
    {
        Grounded = false;
    }
    private void FixedUpdate()
    {
        float x;
        float y;
        x = Input.GetAxis("Horizontal");
        UnityEngine.Debug.LogWarning("Horizontal: " + x);
        y = Input.GetAxis("Vertical");
        UnityEngine.Debug.LogWarning("Vertical: " + y);
        Vector3 road=new Vector3(x, y, 0.0f);
        if (Grounded)
        {
            UnityEngine.Debug.LogWarning("Grounded");
            Roll(road);
        }

    }
    public void Roll(Vector3 move)
    {
        Vector3 force;
        force = move * speed;
        Ball.AddForce(force);
        UnityEngine.Debug.LogWarning("Roll: " + move);
    }
    public void Awake()
    {
        Ball = GetComponent<Rigidbody>();
        Grounded = true;
    }
}
