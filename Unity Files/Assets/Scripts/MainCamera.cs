using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

private Transform mainCamera;
private Transform hero;
private GameObject player;

    // Use this for initialization
    public void Start ()
    {

        mainCamera = GetComponent<Transform>();

        player = GameObject.FindGameObjectWithTag("Player");
        hero = player.GetComponent<Transform>();

    }
    public void Update()
    {
        mainCamera.position = hero.position;
    }

}
