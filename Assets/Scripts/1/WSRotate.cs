using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSRotate : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private float shootTimer;
    [SerializeField] private float coolDownTime = 0.3f;
    void Update()
    {
        shootTimer += Time.deltaTime;
        while (shootTimer > coolDownTime && Input.GetKey("w"))
        {
            shootTimer = 0f;
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            Shoot();
        }
        while (shootTimer > coolDownTime && Input.GetKey("s"))
        {
            shootTimer = 0f;
            transform.rotation = Quaternion.Euler(0f, 0f, 270f);
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
