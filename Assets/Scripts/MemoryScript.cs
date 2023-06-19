using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryScript : MonoBehaviour
{
    public Text memoriesText;
    public Text victoryText;

    public int memories;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Memories")
        {
            memories += 1;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Ending")
        {
            if (memories == 9)
            {
                victoryText.gameObject.SetActive(true);
            }
        }
    }

    void Update()
    {
        memoriesText.text = "Memories: " + memories + "/9";
    }
}
