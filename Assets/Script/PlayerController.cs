﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    private float curSpeed;
    private float rot = 80f;


    private Vector3 move = Vector3.zero;
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
}
