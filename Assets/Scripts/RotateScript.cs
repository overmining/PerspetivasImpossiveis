using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public Transform uiIndicator;
    public GameObject player;

    public float rotateSpeed = 100f;
    public string rotationPosition = "Down";

    void Update()
    {
        // Rodar mapa
        if (rotationPosition.Contains("Down"))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), rotateSpeed * Time.deltaTime);
            uiIndicator.rotation = Quaternion.Slerp(uiIndicator.rotation, Quaternion.Euler(0, 0, 0), rotateSpeed * Time.deltaTime);
        }
        if (rotationPosition.Contains("Up"))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 180), rotateSpeed * Time.deltaTime);
            uiIndicator.rotation = Quaternion.Slerp(uiIndicator.rotation, Quaternion.Euler(0, 0, 180), rotateSpeed * Time.deltaTime);
        }
        if (rotationPosition.Contains("Left"))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, -90), rotateSpeed * Time.deltaTime);
            uiIndicator.rotation = Quaternion.Slerp(uiIndicator.rotation, Quaternion.Euler(0, 0, -90), rotateSpeed * Time.deltaTime);
        }
        if (rotationPosition.Contains("Right"))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 90), rotateSpeed * Time.deltaTime);
            uiIndicator.rotation = Quaternion.Slerp(uiIndicator.rotation, Quaternion.Euler(0, 0, 90), rotateSpeed * Time.deltaTime);
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (rotationPosition.Contains("Down"))
            {
                rotationPosition = "Left";
            }
            else if (rotationPosition.Contains("Left"))
            {
                rotationPosition = "Up";
            }
            else if (rotationPosition.Contains("Up"))
            {
                rotationPosition = "Right";
            }
            else if (rotationPosition.Contains("Right"))
            {
                rotationPosition = "Down";
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (rotationPosition.Contains("Down"))
            {
                rotationPosition = "Right";
            }
            else if (rotationPosition.Contains("Right"))
            {
                rotationPosition = "Up";
            }
            else if (rotationPosition.Contains("Up"))
            {
                rotationPosition = "Left";
            }
            else if (rotationPosition.Contains("Left"))
            {
                rotationPosition = "Down";
            }
        }

        // Respawn
        if (player.transform.position.y < -50f)
        {
            Respawn();
        }
        if (player.GetComponent<TpsScript>().dead)
        {
            Respawn();
            player.GetComponent<TpsScript>().dead = false;
        }
    }

    void Respawn()
    {
        rotationPosition = "Down";
        player.transform.position = new Vector3(0f, 0f, 0f);
    }
}
