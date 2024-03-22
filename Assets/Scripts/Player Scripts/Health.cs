using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefence
{
    public class Health : MonoBehaviour
    {
        public int currentHealth;

         public void TakeDamage(int damageAmount)
        {

            if (currentHealth <= 0)
            {
                GameObject.Destroy(gameObject);
            }
            else
            {
                currentHealth -= damageAmount;
                ValueDisplay.OnValueChange.Invoke(gameObject.name + "Health", currentHealth);
            }
        }

        public static void TryDamage(GameObject target, int damageAmount) 
        {
            Health health = target.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(damageAmount);
            }
        }
    }
}
