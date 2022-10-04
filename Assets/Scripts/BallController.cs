using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 15;

    private void FixedUpdate() {
        rb.velocity = speed * Vector3.forward;
    }
}
