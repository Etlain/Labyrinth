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
             GetComponent<AudioSource>().Play();
             Renderer[] renderers = GetComponentsInChildren<Renderer>();
             foreach (var r in renderers)
                 r.enabled = false;
            Collider[] colliders = GetComponentsInChildren<Collider>();
            foreach (var c in colliders)
                c.enabled = false;
             Destroy(transform.gameObject, 3f);
        }
    }
}
