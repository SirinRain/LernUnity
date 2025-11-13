using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int limitHealth;

    public void TakeHit(int Damage)
    {
        health -= Damage;
        
        if (health <= 0)
            Destroy(gameObject);
    }

    public void SetHealth(int bonusHealth)
    { 
        health += bonusHealth;
        if (health > limitHealth)
            health = limitHealth;
    }
}
