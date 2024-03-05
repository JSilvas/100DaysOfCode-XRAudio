using UnityEngine;
using StarterAssets;
using Unity.VisualScripting;

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

    public void CheckLayers()
    {
        // Debug.Log("CheckLayers() initialized");

        // raycast down
        RaycastHit hit;
        // Debug.Log("Raycast initialized");

        // Added to address raycast protruding from character through terrain and failing
        float offset = 0.1f; // Adjust this value to tune ground detection
        Vector3 rayOrigin = transform.position + new Vector3(0, offset, 0);
        bool RayCastReport = Physics.Raycast(rayOrigin, Vector3.down, out hit, 1);
        
        if (RayCastReport)
        {
            // Debug.Log("Raycast hit: " + hit.transform.GetComponent<Terrain>());
            // check if terrain exists
            if (hit.transform.GetComponent<Terrain>()!= null)
            {
                Terrain t = hit.transform.GetComponent<Terrain>();
                // Debug.Log("Raycast hit: " + t);

                // if layer does not matches currentLayer
                if (currentLayer != checker.GetLayerName(transform.position, t))
                {
                    currentLayer = checker.GetLayerName(transform.position, t);
                    
                    // Debug Current Layer
                    string terrainTest = currentLayer.ToString();
                    Debug.Log("New Terrain Layer: " + terrainTest);

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
        else
        {
            Debug.Log("Raycast did not hit any collider");
        }
    }
}