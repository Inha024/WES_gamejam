﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    public float xInput;
    public float yInput;
    public float speed = 10;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        ApplyMovement();
    }
    void CheckInput()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
    }
    void ApplyMovement()
    {
        if (xInput != 0 || yInput != 0)
        {
            transform.position += new Vector3(xInput * speed * Time.deltaTime, yInput * speed * Time.deltaTime, transform.position.z * 0);
        }
    }
}
