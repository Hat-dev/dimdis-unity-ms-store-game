using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnabler : MonoBehaviour
{
    public GameObject endlvl;
    void OnCollisionEnter2D(Collision2D col)
    {
        Invoke("activ8",0.2f);
    }
    void activ8()
    {
        endlvl.SetActive(true);
    }
}
