using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    [SerializeField]
    AudioClip sndOpen = null;
    [SerializeField]
    AudioClip sndDenied = null;
    [SerializeField]
    GameObject endPoint = null;

    private AudioSource myAudioSource;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        bool isKey;

        if (other.tag == "Player")
        {
            isKey = other.GetComponent<PlayerController>().useKey();
            if (isKey)
            {
                if (endPoint)
                    endPoint.SetActive(true);
                GetComponent<Animator>().enabled = true;
                myAudioSource.PlayOneShot(sndOpen);
            }
            else
                myAudioSource.PlayOneShot(sndDenied);
        }
    }
}
