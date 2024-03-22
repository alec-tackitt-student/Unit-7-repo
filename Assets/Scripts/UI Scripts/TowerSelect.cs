using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TowerDefence
{
    public class TowerSelect : MonoBehaviour
    {
        Dropdown dropdown;
        Player player;

        public GameObject ArcherTowerPrefab;
        public GameObject CannonTowerPrefab;
        public GameObject GoldTowerPrefab;
        private void Awake()
        {
            dropdown = GetComponent<Dropdown>();
            player = FindFirstObjectByType<Player>();
            dropdown.onValueChanged.AddListener(OnChange);

            
        }

        private void OnChange(int arg0)
        {
            switch (arg0)
            {
                case 0:
                    player.towerPrefab = ArcherTowerPrefab;break;
                case 1: 
                    player.towerPrefab = CannonTowerPrefab; break;
                case 2:
                    player.towerPrefab= GoldTowerPrefab; break;
                default:
                    Debug.Log("no tower selected");
                    break;

            }
        }
    }
}
