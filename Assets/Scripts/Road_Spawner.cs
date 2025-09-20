using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_Spawner : MonoBehaviour
{
    public static Road_Spawner instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    [SerializeField] GameObject Road_Tile;
    [SerializeField] Transform spawn_pos;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Spawn_Road()
    {
        Instantiate(Road_Tile, spawn_pos.position, Quaternion.identity);
        spawn_pos.position = new Vector3(spawn_pos.transform.position.x, spawn_pos.transform.position.y, spawn_pos.transform.position.z + 58f);
    }

    private void OnDestroy()
    {
        Destroy(instance);
    }
}
