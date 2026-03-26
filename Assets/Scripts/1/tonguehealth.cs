using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tonguehealth : MonoBehaviour
{
    public Transform endportalpos;
    public GameObject endport;
    public int maxhealth = 4;
    public int health;
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
        Debug.Log("hit");
        health -= damage;
        hb.SetHealth(health);
        if (health <= 0)
        {
            gameObject.SetActive(false);
            Destroy(music);
            Destroy(gameObject);
            Instantiate (endport, endportalpos.position, Quaternion.identity);
        }
        if (health<=1)
        {
            slash.SetActive(true);
        }
    }
}
