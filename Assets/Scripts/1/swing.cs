using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{
    public Transform upplace;
    public Transform downplace;
    public float range = 0.5f;
    public float damage = 5f;
    public LayerMask enemylayers;
    private Animator anim;
    [SerializeField] private AudioSource killSound;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("sword");
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            Attackup();
        }
        if (Input.GetKey("s"))
        {
            Attackdown();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Attackup();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Attackdown();
        }
    }
    
    void Attackup()
    {
        anim.SetTrigger("swingup");
        Collider2D[] hitEnemiesup = Physics2D.OverlapCircleAll(upplace.position, range, enemylayers);
        foreach (Collider2D enemy in hitEnemiesup)
        {
            enemy.GetComponent<bathealth>().TakeDamage(damage);
            killSound.Play();
        }
    }
    void Attackdown()
    {
        anim.SetTrigger("swingdown");
        Collider2D[] hitEnemiesdown = Physics2D.OverlapCircleAll(downplace.position, range, enemylayers);
        foreach (Collider2D enemy in hitEnemiesdown)
        {
            killSound.Play();
            enemy.GetComponent<bathealth>().TakeDamage(damage);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (upplace == null)
        return;

        Gizmos.DrawWireSphere(upplace.position, range);
        if (downplace == null)
        return;

        Gizmos.DrawWireSphere(downplace.position, range);
    }
}
