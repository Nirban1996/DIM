using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundKS : MonoBehaviour {

    public AudioSource movement;
    public AudioSource power;
    public AudioSource gate;
    public AudioSource menu;
    // Use this for initialization
    void Start()
    {
        movement.Play();
        power.Play();
        gate.Play();
        menu.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
