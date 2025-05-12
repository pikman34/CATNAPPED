using UnityEngine;

public class WoodenballSpawn : MonoBehaviour
{
    public GameObject woodenBallPrefab;
    public bool woodenBallIsCollectible = false;
    public bool woodenBallSpawned = false;
    public void WoodenBallSpawns()
    {
        if(woodenBallIsCollectible)
        {
            DontDestroyOnLoad(Instantiate(woodenBallPrefab, transform.position, Quaternion.identity));
            woodenBallSpawned = true;
        }

        if(woodenBallSpawned) 
        {
            woodenBallIsCollectible = false;
        }
    }

    public void UpdateSpawn()
    {
        if (!woodenBallIsCollectible)
        {
            woodenBallIsCollectible = true;
            WoodenBallSpawns();
        }
    }
}
