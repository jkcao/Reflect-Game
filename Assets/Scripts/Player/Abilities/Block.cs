﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    protected Rigidbody2D rigidBody;
    private bool isRestricted;
    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        isRestricted = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Character")
		{
            isRestricted = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Character")
        {
            isRestricted = false;
        }
    }

    public bool getRestricted ()
    {
        return isRestricted;
    }
}
