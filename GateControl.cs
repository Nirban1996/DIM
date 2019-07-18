using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControl : MonoBehaviour {
    public AudioSource gate;
    Vector3 tempPos;
    public Material[] material;
    Renderer rend;
    void Start()
    {
        gate.Play();
        tempPos = transform.position;//*moveSpeed*Time.deltaTime;
        tempPos.y -= 8f;
        transform.position = tempPos;
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.rigidbody.GetComponent<Renderer>().material.color == this.GetComponent<Renderer>().material.color)
        {
            gate.Play();
            tempPos = transform.position;
            tempPos.y += 8f;
            transform.position = tempPos;
        }
    }
}
