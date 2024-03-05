using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainChecker
{
    private float[] GetTextureMix(Vector3 playerPos, Terrain t) 
    {
        // Get terrain position and store in variable 
        Vector3 tPos = t.transform.position;
        // Get terrain data and store in variable
        TerrainData tData = t.terrainData;
        // players X and Z positions relative to terrain.
        int mapX = Mathf.RoundToInt((playerPos.x - tPos.x) / tData.size.x * tData.alphamapWidth);
        int mapZ = Mathf.RoundToInt((playerPos.z - tPos.z) / tData.size.z * tData.alphamapHeight);
        // store as float 
        float[,,] splatMapData = tData.GetAlphamaps(mapX, mapZ, 1, 1);
    
        // Store Highest Terrain value as float in variable cellmix
        float[] cellmix = new float[splatMapData.GetUpperBound(2) + 1];
            // Get current terrain values in cell mix and store in array
            for (int i = 0; i < cellmix.Length; i++)
            {
                cellmix[i] = splatMapData[0, 0, i];
            }
            // return highest value
            return cellmix;
    }
    
    public string GetLayerName(Vector3 playerPos, Terrain t)
    {
        float[] cellMix = GetTextureMix(playerPos, t);
        float strongest = 0;
        int maxIndex = 0;
        for (int i = 0; i < cellMix.Length; i++)
        {
            if(cellMix[i] > strongest)
            {
                maxIndex = i;
                strongest = cellMix[i];
            }
        }
        Debug.Log("Terrain Layer: " + t.terrainData.terrainLayers[maxIndex].name);
        return t.terrainData.terrainLayers[maxIndex].name;
    }
}
