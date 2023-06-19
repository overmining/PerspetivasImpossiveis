using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }
}
