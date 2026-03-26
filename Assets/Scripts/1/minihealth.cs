using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minihealth : MonoBehaviour
{
    public float health = 5f;
    public void TakeDamage(float damage)
    {
        Debug.Log("hit");
        health -= damage;
        if (health <= 0)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
