using UnityEngine;

public class ScrewSpawn : MonoBehaviour
{
    public GameObject screwPrefab;
    public bool screwIsCollectible = false;
    public bool screwSpawned = false;
    void Update()
    {
        if(screwIsCollectible)
        {
            Instantiate(screwPrefab, transform.position, Quaternion.identity);
            screwSpawned = true;
        }

        if(screwSpawned) 
        {
            screwIsCollectible = false;
        }
    }
}
