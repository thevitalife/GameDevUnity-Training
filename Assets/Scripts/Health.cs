using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float hp;

    [SerializeField]
    private Slider slider;
    private void Start()
    {
        slider.maxValue = hp;
        slider.value = hp;

    }

    public void Damage(float damage)
    {
        hp -= damage;
        Debug.Log(hp);
        slider.value = hp;
        if (hp <= 0)
        {
            Die();
        }
    }   
    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
