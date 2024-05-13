using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> prefabList;

    [SerializeField]
    private GameObject player;

    public List<GameObject> getPrefabs()
    {
        return prefabList;
    }

    public void spawnObject(int id)
    {
        Instantiate(prefabList[id - 1], player.transform.position + player.transform.forward * 2, player.transform.rotation, transform.parent);
    }
}
