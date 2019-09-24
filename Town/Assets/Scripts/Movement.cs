﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        if(movement.magnitude < 0.001f)
        {

        }
        else
        {
            animator.SetFloat("LastX", movement.x);
            animator.SetFloat("LastY", movement.y);
        }

        transform.position = transform.position + movement * Time.deltaTime * speed;
    }
}
