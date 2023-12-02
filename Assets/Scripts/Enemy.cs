using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosionPrefab; 

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bala"))
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    } 
}
