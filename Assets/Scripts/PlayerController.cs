using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float       speed = 10f;
    [SerializeField]
    private float       rot = 80f;
    [SerializeField]
    private GameObject  GoGameOver = null;

    private float curSpeed;
    private Vector3 move = Vector3.zero;
    private bool key = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalAxe;

        if (Input.GetKey(KeyCode.LeftShift))
            curSpeed = speed * 2;
        else
            curSpeed = speed;
        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        verticalAxe = Input.GetAxis("Vertical");
        if (verticalAxe > 0)
            transform.Translate(Vector3.forward * curSpeed * Time.fixedDeltaTime * verticalAxe);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
            gameOver();
    }

    public void getKey()
    {
        key = true;
    }

    public bool useKey()
    {
        if (key)
        {
            key = false;
            return (true);
        }
        return (false);
    }

    public void gameOver()
    {
        GoGameOver.SetActive(true);
        StartCoroutine(loadMenu());
        //SceneManager.LoadScene("Menu");
    }

    IEnumerator loadMenu()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
    }
}
