using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
    public int damage = 5;
    public float speed = 10f;
    public Rigidbody2D rb;
    [SerializeField] 
    private float lifeTime = 2f;
    private void Awake()
    {
        Invoke("DestroySelf", lifeTime);
    }
    
    void Start()
    {
        rb.velocity = transform.right*speed;
        Physics2D.IgnoreLayerCollision(2,11,true);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        playerhealth player = hitInfo.GetComponent<playerhealth>();

        if (player != null)
        {
            player.TookDamage(damage);
        }
        DestroySelf();
    }
    internal void DestroySelf()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
