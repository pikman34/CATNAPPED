using UnityEngine;

public class ScrewSpawn : MonoBehaviour
{
    public GameObject screwPrefab;
    public bool screwIsCollectible = false;
    public bool screwSpawned = false;
    public void ScrewSpawns()
    {
        if(screwIsCollectible)
        {
            DontDestroyOnLoad(Instantiate(screwPrefab, transform.position, Quaternion.identity));
            screwSpawned = true;
        }

        if(screwSpawned) 
        {
            screwIsCollectible = false;
        }
    }

    public void UpdateSpawn()
    {
        if (!screwIsCollectible)
        {
            screwIsCollectible = true;
            ScrewSpawns();
        }
    }
}
