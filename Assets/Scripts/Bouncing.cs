using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Bouncing : MonoBehaviour
{
    public List<Rigidbody> ListRigidbodies;
    public Collider Collider;
    public float Force;
    private bool _playerCollider;
    private bool _bounceState;


    // Use this for initialization
    void Start()
    {
        Collider = GetComponent<Collider>();
        _bounceState = false;
        _playerCollider = false;
    }

    // Update is called once per frame
    void Update()
    {
        _playerCollider = Collider.bounds.Contains(VRTK_DeviceFinder.HeadsetTransform().position);

        if (_playerCollider)
        {
            _bounceState = true;
        }

        if (_bounceState)
        {
            ApplyForces();
        }
    }

    private void ApplyForces()
    {
        ListRigidbodies.ForEach(rb =>
        {
            rb.useGravity = true;
            if (rb.gameObject.transform.position.y < 1)
            {
                rb.AddForce(transform.up * Random.Range(10,Force));
            }
        });
    }
}