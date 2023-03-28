using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbScript : MonoBehaviour
{
    [SerializeField] float orbSpeed;
    [SerializeField] float damage;
    [SerializeField] Rigidbody2D rb2d;

    private void Start()
    {
        rb2d.velocity = transform.right * orbSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthScript hit = collision.GetComponent<HealthScript>();
        if (hit)
        {
            hit.takeDamage(damage);
        }

        Destroy(gameObject);
    }

}
