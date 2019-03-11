using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterBurnerScript : MonoBehaviour
{

    [SerializeField]
    private bool autoIndex = false;

    private int levelToLoad = 0;

    private void Start()
    {
        if (autoIndex)
            levelToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("ActualLevel", levelToLoad);
            if (autoIndex)
                SceneManager.LoadScene(levelToLoad);
            else
                SceneManager.LoadScene(0);
        }
    }
}
