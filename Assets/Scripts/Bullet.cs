using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidbody;

    [SerializeField]
    private ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.velocity = transform.up * 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        particle.Play();
    }
}
