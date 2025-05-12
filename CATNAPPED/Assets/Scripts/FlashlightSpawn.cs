using UnityEngine;

public class FlashlightSpawn : MonoBehaviour
{
    public GameObject flashlightPrefab;
    public bool flashlightIsCollectible = false;
    public bool flashlightSpawned = false;
    public void FlashlightSpawns()
    {
        if(flashlightIsCollectible)
        {
            DontDestroyOnLoad(Instantiate(flashlightPrefab, transform.position, Quaternion.identity));
            flashlightSpawned = true;
        }

        if(flashlightSpawned) 
        {
            flashlightIsCollectible = false;
        }
    }

    public void UpdateSpawn()
    {
        if (!flashlightIsCollectible)
        {
            flashlightIsCollectible = true;
            FlashlightSpawns();
        }
    }
}
