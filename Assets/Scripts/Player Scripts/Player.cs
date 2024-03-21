using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefence
{
    public class Player : MonoBehaviour
    {
        public GameObject towerPrefab;
        public int gold = 50;

        Grid grid;
        Cursor cursor;

        private void Awake()
        {
            grid = FindFirstObjectByType<Grid>();
            cursor = GetComponentInChildren<Cursor>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                
                TryPlaceTower(grid, Grid.WorldToGrid(cursor.transform.position));
            }
        }
        public bool TryPlaceTower(Grid grid, Vector3Int tileCoordinates)
        {
            
            if (gold < Tower_SO.GetCost(towerPrefab)) return false;
            
            if (grid.Occupied(tileCoordinates)) return false;
           
            GameObject newTower = Instantiate(towerPrefab, tileCoordinates, Quaternion.identity);
            grid.Add(tileCoordinates, newTower);
            gold -= Tower_SO.GetCost(towerPrefab);
            return true;
        }
    }
}
