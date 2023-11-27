using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : IInteractable
{
    public int balloonNo;
    public GameObject balloonNormal;
    public GameObject balloonBroken;

    public AudioSource sfxSource;
    public AudioClip popSfx;

    private bool isBroken = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Weapon") && !isBroken)
        {
            balloonNormal.SetActive(false);
            balloonBroken.SetActive(true);
            GameManager.instance.SetBalloonBroken(balloonNo);
            sfxSource.PlayOneShot(popSfx);
            isBroken = true;
        }
    }
}
