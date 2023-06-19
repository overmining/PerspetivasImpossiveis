using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject wayPoint;
    private float speed = 6.0f;
    private bool seesPlayer = false;

    void Start()
    {
        wayPoint = GameObject.Find("Player");
    }

    void Update()
    {
        if (seesPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPoint.transform.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "Player") seesPlayer = true;
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.tag == "Player") seesPlayer = false;
    }
}
