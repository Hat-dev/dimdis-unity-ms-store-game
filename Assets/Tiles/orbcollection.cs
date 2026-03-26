using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbcollection : MonoBehaviour
{
    public GameObject orb;
    void Start()
    {
        orb.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            orb.SetActive(true);
            gameObject.tag = "killer";
        }
    }
}
