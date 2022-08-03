﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class StoryLine : MonoBehaviour
{
    Rigidbody2D playerRigidbody;
    public Flowchart talk;
    public string story;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = FindObjectOfType<player>().GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerRigidbody.Sleep();
            Block say = talk.FindBlock(story);
            talk.ExecuteBlock(say);

        }
    }
}
