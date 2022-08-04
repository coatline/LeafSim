using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    [SerializeField] float fallAccelerationFactor;
    [SerializeField] float maxFallSpeedVariety;
    [SerializeField] float maxFallSpeed;
    [SerializeField] float maxSwaySpeed;
    bool fastFalling = true;
    float currentSwaySpeed;
    float currentFallSpeed;
    Rigidbody2D rb;

    void Fall()
    {
        if (currentFallSpeed > maxFallSpeed)
        {
            fastFalling = false;
        }
        else if (currentFallSpeed < -maxFallSpeed / 7 + Random.Range(-1f, 1f) || (transform.rotation.z > 50 && transform.rotation.z < 130))
        {
            fastFalling = true;
        }

        if (fastFalling)
        {
            currentFallSpeed += fallAccelerationFactor;
        }
        else
        {
            currentFallSpeed -= fallAccelerationFactor;
        }

        rb.velocity = new Vector2(currentSwaySpeed, -currentFallSpeed);
    }

    void Start()
    {
        currentSwaySpeed = Random.Range(-1, 1);
        currentFallSpeed = maxFallSpeed;
        maxFallSpeed += Random.Range(-maxFallSpeedVariety / 2, maxFallSpeedVariety);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Fall();
    }
}
