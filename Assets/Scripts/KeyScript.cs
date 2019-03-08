using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Text: " + other.tag);
        if (other.tag == "Player")
        {
            //Debug.Log("T: " + collision.collider.tag);
             //Debug.Log(other.GetComponent<PlayerController>());
             other.GetComponent<PlayerController>().getKey();
             Destroy(transform.gameObject);
        }
    }
}
