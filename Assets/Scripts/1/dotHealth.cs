using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 40;
    public GameObject[] minis;
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
    public void Awake()
    {
        minis[0].SetActive(false);
        minis[1].SetActive(false);
        minis[2].SetActive(false);
        minis[3].SetActive(false);
        minis[4].SetActive(false);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        hb.SetHealth(health);
        if (health <= 0)
        {
            minis[0].SetActive(false);
            minis[1].SetActive(false);
            minis[2].SetActive(false);
            minis[3].SetActive(false);
            minis[4].SetActive(false);
            Destroy(music);
            Destroy(gameObject);

            Instantiate (endport, endportalpos.position, Quaternion.identity);
        }
        if (health <= 30)
        {
            minis[0].SetActive(true);
            minis[1].SetActive(true);
            minis[2].SetActive(true);
            minis[3].SetActive(true);
            minis[4].SetActive(true);
        }
        if (health<= 5)
        {
            slash.SetActive(true);
        }
    }
}
