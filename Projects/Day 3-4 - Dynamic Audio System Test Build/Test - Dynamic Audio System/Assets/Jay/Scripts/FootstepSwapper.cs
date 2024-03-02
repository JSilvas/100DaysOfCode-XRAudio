using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class FootstepSwapper : MonoBehaviour
{
    private TerrainChecker checker;
    private ThirdPersonController tpc;
    private string currentLayer;
    FootstepSwapper[] terrainFootstepsCollections;
    // Start is called before the first frame update
    void Start()
    {
        checker = new TerrainChecker();
        tpc = GetComponent<ThirdPersonController>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}