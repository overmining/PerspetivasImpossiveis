using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryScript : MonoBehaviour
{
    public Text memoriesText;

    public int memories;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Memories")
        {
            memories += 1;
            other.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        memoriesText.text = "Memories: " + memories + "/9";
    }
}
