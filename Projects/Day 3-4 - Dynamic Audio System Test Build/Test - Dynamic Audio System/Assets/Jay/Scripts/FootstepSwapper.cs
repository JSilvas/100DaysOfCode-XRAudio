using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using TMPro.EditorUtilities;
using UnityEngine.TextCore.Text;
using System;

public class FootstepSwapper : MonoBehaviour
{
    private TerrainChecker checker;
    private ThirdPersonController tpc;
    private string currentLayer;
    public FootstepCollection[] terrainFootstepCollections;
    // Start is called before the first frame update
    void Start()
    {
        checker = new TerrainChecker();
        tpc = GetComponent<ThirdPersonController>();
        currentLayer = "foobarbaz";
    }

    // Update is called once per frame
    public void CheckLayers()
    {
        // Debug.Log("CheckLayers() initialized");

        // raycast down
        RaycastHit hit;
        // Debug.Log("Raycast initialized");

        bool RayCastReport = Physics.Raycast(transform.position, Vector3.down, out hit, 3);
        
        // Debug.Log("Raycast bool: " + RayCastReport);
        if (RayCastReport)
        {
            
            
            // check if terrain exists
            if (hit.transform.GetComponent<Terrain>()!= null)
            {
                Terrain t = hit.transform.GetComponent<Terrain>();
                
                // Debug terrain raycasting                
                string rayHitsTest = t.terrainData.terrainLayers[1].ToString();
                Debug.Log("Raycast hit: " + rayHitsTest);

                // if layer does not matches currentLayer
                if (currentLayer != checker.GetLayerName(transform.position, t))
                {
                    currentLayer = checker.GetLayerName(transform.position, t);
                    
                    // Debug Current Layer
                    string terrainTest = currentLayer.ToString();
                    Debug.Log("Current Terrain: " + terrainTest);

                    // swap footsteps collection
                    foreach (FootstepCollection collection in terrainFootstepCollections)
                    {
                        
                        if (currentLayer == collection.name)
                        {
                            tpc.SwapFootsteps(collection);
                        }
                    }
                } 
            }
            if (hit.transform.GetComponent<SurfaceType>() != null)
            {
                FootstepCollection collection = hit.transform.GetComponent<SurfaceType>().footstepCollection;
                currentLayer = collection.name;
                tpc.SwapFootsteps(collection);
            }
        }
    }
}