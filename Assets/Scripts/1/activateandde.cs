using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateandde : MonoBehaviour
{
    public GameObject activate;
    public GameObject deactivate;
    void OnTriggerEnter2D(Collider2D col)
    {
        deactivate.SetActive(false);
        activate.SetActive(true);
    }
}
