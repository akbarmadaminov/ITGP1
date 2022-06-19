using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int direction = 0;
    private Rigidbody _rigidbody;
    private float Speed = 7.0f;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnDisable()
    {
        var velocity = Vector3.zero;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            direction = direction == 0 ? 1 : 0;
        } 
        
    }

    private void FixedUpdate()
    {
        var velocity = direction == 0 ? Speed * Vector3.forward : Speed * Vector3.right;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }
}
