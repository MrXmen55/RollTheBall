using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using UnityEngine;

public class Hero : MonoBehaviour {

    public Rigidbody ball;
    public bool grounded;
    public float speed;

    private void OnCollisionEnter()
    {
        grounded = true;
    }
    private void OnCollisionExit()
    {
        grounded = false;
    }
    private void FixedUpdate()
    {
        float x;
        float y;
        x = Input.GetAxis("Horizontal");
        
        y = Input.GetAxis("Vertical");
        Vector3 Road=new Vector3(x,y,0);
        if (grounded)
        {
            Roll(Road);
        }

    }
    public void Roll(Vector3 move)
    {
        move = move * speed;
        ball.AddForce(move);
    }
    public void Awake()
    {
        ball=GetComponent<Rigidbody>();
        speed = 250f;
        grounded = true;
    }
}
