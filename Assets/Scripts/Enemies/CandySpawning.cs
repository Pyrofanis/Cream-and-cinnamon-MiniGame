using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawning : MonoBehaviour
{
    [Header("Points that candies will spawn from")]
    [Header("ListOfPoints")]
    [SerializeField]
    private GameObject[] spawnPoints;

    [SerializeField]
    [Header("Candies to spawn From")]
    [Min(1)]
    private GameObject[] candyPrefabs;

    private List<GameObject> activeCandies;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateInitialCandys();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private GameObject GetPrefab(GameObject[] candyPrefabs)
    {
        int index = Random.Range(0, candyPrefabs.Length);
        return candyPrefabs[index];
    }
    private Vector3 GetLocation(GameObject[] spawnPoints)
    {
        int index = Random.Range(0, spawnPoints.Length);
        return spawnPoints[index].transform.position;
    }

    private void InstantiateObjects()
    {
        GameObject candy = Instantiate(GetPrefab(candyPrefabs), GetLocation(spawnPoints), Quaternion.identity);
        activeCandies.Add(candy);
    }
    private GameObject ObjectToInstantiate()

    {
        return null;
    }
    private void InstantiateInitialCandys()
    {
        foreach (GameObject candy in candyPrefabs)
        {
            GameObject currentCandy = Instantiate(candy, transform.position, Quaternion.identity);
            if (!activeCandies.Contains(currentCandy))
                activeCandies.Add(currentCandy);
        }
    }
}

