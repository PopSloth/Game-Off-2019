﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public ColorCode _colordCode;
    public Animator transitionAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") || collision.CompareTag("FreePlayer"))
        {
            transitionAnim.SetTrigger("death");
            _colordCode.KillPlayerAlways(collision.gameObject, collision.transform.tag);
          //  Destroy(collision.gameObject);
        }
    }
}
