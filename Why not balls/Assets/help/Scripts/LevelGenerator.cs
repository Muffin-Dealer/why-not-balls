using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelGenerator : MonoBehaviour
{
    ObjectPooler objectPooler;
    public Transform firstPlatform;
    public Transform camPosition;

    public int numberOfPlatforms = 20;
    public float levelWidth = 3f;
    Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.Instance;
        spawnPosition = firstPlatform.position;
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(objectPooler.GetMin("Platform"), objectPooler.GetMax("Platform"));
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            objectPooler.SpawnFromPool("Platform", spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(camPosition.position.y >= (spawnPosition.y - 20))
        {
            spawnPosition.y += Random.Range(objectPooler.GetMin("Platform"), objectPooler.GetMax("Platform"));
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            objectPooler.SpawnFromPool("Platform", spawnPosition, Quaternion.identity);
        }
      
    }
    
    //public GameObject platformPrefab;
    //public Transform firstPlatform;

    //public int numberOfPlatforms = 40;
    //public float levelWidth = 3f;
    //public float minY = .6f;
    //public float maxY = 3.1f;
    //Vector3 spawnPosition;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    spawnPosition = firstPlatform.position;

    //    for (int i = 0; i < numberOfPlatforms; i++)
    //    {
    //        spawnPosition.y += Random.Range(minY, maxY);
    //        spawnPosition.x = Random.Range(-levelWidth, levelWidth);
    //        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
