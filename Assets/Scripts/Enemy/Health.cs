using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]private int health = 100;
    void Start()
    {
        
    }

    public void DealDamage(int d)
    {
        health = health - d;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
