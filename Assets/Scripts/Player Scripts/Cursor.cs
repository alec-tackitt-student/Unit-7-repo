using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefence
{
    public class Cursor : MonoBehaviour
    {
        Vector3Int GetTargetTile()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Vector3Int targetTile;
                targetTile = Grid.WorldToGrid(hit.point + hit.normal * .5f);
                return targetTile;
            }
            return Vector3Int.zero;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = GetTargetTile();
        }
    }
}
