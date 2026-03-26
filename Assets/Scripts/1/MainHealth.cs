using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHealth : MonoBehaviour
{
    public int maxhealth = 100;
    public int health;
    public healthbar hb;
    public GameObject endportal;
    public Transform endportalpos;
    public GameObject v1,v2;
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
        if (health == 0)
        {
            Debug.Log("f");
            gameObject.SetActive(false);
            v1.SetActive(false);
            v2.SetActive(false);
            Destroy(gameObject);
            Destroy(v1);
            Destroy(v2);
            Destroy(music);
            Instantiate (endportal, endportalpos.position, endportalpos.rotation);
        }
        if (health<=20)
        {
            slash.SetActive(true);
        }
    }
}
