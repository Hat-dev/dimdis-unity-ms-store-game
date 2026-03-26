using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bathealth : MonoBehaviour
{
    public float health = 20f;
    public GameObject wave2;
    activator act;
    public void Start()
    {
        act = wave2.GetComponent<activator>();
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health < 0)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            act.batamount -= 1;
        }
    }
}
