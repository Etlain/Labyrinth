using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterBurnerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("win");
        }
    }
}
