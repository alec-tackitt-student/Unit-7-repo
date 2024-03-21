using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefence
{
    public class Grid : MonoBehaviour
    {
        private Dictionary<Vector3Int, GameObject> gameObjects = new Dictionary<Vector3Int, GameObject>();

        public bool Occupied(Vector3Int tileCoordinates)
        {
            return gameObjects.ContainsKey(tileCoordinates);
        }
     
        public bool Add(Vector3Int tileCoordinates, GameObject gameObject)
        {
            if (gameObjects.ContainsKey(tileCoordinates)) { return false; }

            gameObjects.Add(tileCoordinates, gameObject);
            return true;
        }

        public void Remove(Vector3Int tileCoordinates)
        {
            if(!gameObjects.ContainsKey(tileCoordinates)) {return; }

            Destroy(gameObjects[tileCoordinates]);
            gameObjects.Remove(tileCoordinates);
        }
        public static Vector3Int WorldToGrid(Vector3 worldPosition)
        {
            int gridX = (int)worldPosition.x;
            int gridY = (int)worldPosition.y;
            int gridZ = (int)worldPosition.z;
            Vector3Int gridCoord = new Vector3Int(gridX, gridY, gridZ);
            return gridCoord;
        }
        public static Vector3 GridToWorld(Vector3Int gridPosition)
        {
            float worldX = gridPosition.x;
            float worldY = gridPosition.y;
            float worldZ = gridPosition.z;
            Vector3 worldPosition = new Vector3(worldZ, worldX, worldY);
            return worldPosition;
        }
    }
}
