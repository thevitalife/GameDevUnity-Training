using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
       {
           Wallet.Instance.AddValue(1);
           Destroy(gameObject);
       }
    }
}
