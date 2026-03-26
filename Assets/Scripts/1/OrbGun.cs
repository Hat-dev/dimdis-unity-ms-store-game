using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    [SerializeField] private AudioSource shootSound;
    private float shootTimer;
    [SerializeField] private float coolDownTime = 0.3f;
    void Update()
    {
        shootTimer += Time.deltaTime;
        while (shootTimer > coolDownTime)
        {
            shootTimer = 0f;
            Shoot();
        }
    }
    void Shoot()
    {
        shootSound.Play();
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
