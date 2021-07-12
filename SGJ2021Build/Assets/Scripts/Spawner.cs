using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float queueTime = 1.5f;
    private float time = 0;
    public GameObject obstacles;

    public int PipesSpawned;

    public float height;

    private static Spawner instance;
    public static Spawner GetInstance()
    {
        return instance;
    }

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > queueTime)
        {
            GameObject go = Instantiate(obstacles);
            PipesSpawned += 1;
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            time = 0;

            Destroy(go, 10);
        }

        time += Time.deltaTime;

    }

    public int GetPipesSpawned()
    {
        return PipesSpawned;
    }
}
