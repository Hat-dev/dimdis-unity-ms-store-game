using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadBoi : MonoBehaviour
{
    public int health;
    public int maxhealth = 700;
    public Transform endportalpos;
    public GameObject endport;
    public healthbar hb;
    public GameObject slash;
    public GameObject music;

    void Start()
    {
        health=maxhealth;
        hb.SetMaxHealth(maxhealth);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        hb.SetHealth(health);
        if (health<=100)
        {
            slash.SetActive(true);
        }

        if (health <= 0)
        {
            Debug.Log("ded");
            Destroy(music);
            Destroy(gameObject);
            Instantiate (endport, endportalpos.position, Quaternion.identity);
        }
    }
}
