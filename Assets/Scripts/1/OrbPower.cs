using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbPower : MonoBehaviour
{
    public int damage = 1;
    public GameObject tongue;
    [SerializeField] private AudioSource hitSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Miscellanious"){
        hitSound.Play();
        tongue.GetComponent<tonguehealth>().TakeDamage(damage);
        DestroySelf();
        Debug.Log("damaged");
        }
    }
    internal void DestroySelf()
    {
        gameObject.SetActive(false);
    }
}
