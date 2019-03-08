using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        bool isKey;

        if (other.tag == "Player")
        {
            isKey = other.GetComponent<PlayerController>().useKey();
            if (isKey)
                GetComponent<Animator>().enabled = true;
        }
    }
}
