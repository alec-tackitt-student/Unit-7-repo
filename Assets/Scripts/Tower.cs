using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefence
{
    public class Tower : MonoBehaviour
    {

        [SerializeField] private List<GameObject> enimiesInRange = new List<GameObject>();

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Enemy")) enimiesInRange.Add(other.gameObject);
        }
        private void OnTriggerExit(Collider other)
        {
            enimiesInRange.Remove(other.gameObject);
        }
    }
}
