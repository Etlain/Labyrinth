using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{
    [SerializeField]
    private int     time = 60;
    [SerializeField]
    private Text    textCountdown = null;
    [SerializeField]
    private GameObject  player = null;
    // Start is called before the first frame update
    void Start()
    {
        modifyText();
        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        //Debug.Log("hi");
        while(time > 0)
        {
            //Debug.Log("hi");
            yield return new WaitForSeconds(1f);
            time--;
            modifyText();
        }
        player.GetComponent<PlayerController>().gameOver();
        //Debug.Log("you loose");
    }

    void modifyText()
    {
        textCountdown.text = "TimeLeft : "+time;
    }
}
