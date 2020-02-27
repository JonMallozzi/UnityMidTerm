using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 1;
    public int damage = 1;
    private void FixedUpdate()
    {
        //move along the y
        transform.position += transform.up * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Player"))//placeholder for until Austin makes a character controller
        {
            //other.GetComponent<Health>().TakeDamage(damage);
            Remove();
        }
    }

    private void Remove()
    {
        Destroy(this.gameObject);
    }
}
