using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField]
    private float minDamage;

    [SerializeField]
    private float maxDamage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.TryGetComponent(out Health health))
            {
                health.Damage(Random.Range(minDamage, maxDamage));
            }
        }
    }
}
