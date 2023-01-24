using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private float speed;


    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical");
        float right = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(right, 0, forward).normalized*Time.deltaTime*speed;
        transform.position = transform.position + movement;
        if (movement.magnitude > 0.0000001f)
        {
            transform.forward = movement;
        }

    }
}
