using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawning : MonoBehaviour
{
    [Header("Points that candies will spawn from to left to right")]
    [Header("Left Point")]
    [SerializeField]
    private GameObject leftPoint;
    [SerializeField]
    [Header("Right Point")]
    private GameObject RightPoint;

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

    private void OnDrawGizmos()
    {
        if (leftPoint != null && RightPoint != null)
            Gizmos.DrawLine(leftPoint.transform.position, RightPoint.transform.position);
    }
    private GameObject ObjectToInstantiate()

    {
        return null;
    }
    private void InstantiateInitialCandys()
    {
        foreach (GameObject candy in candyPrefabs)
        {
            GameObject currentCandy=Instantiate(candy,transform.position,Quaternion.identity);
            if (!activeCandies.Contains(currentCandy))
            activeCandies.Add(currentCandy);
        }
    }
    private Vector2 RandomPosition(Vector3 leftPos, Vector3 rightPos)
    {

        float randomX = Random.Range(leftPos.x, rightPos.x);
        return new Vector2(randomX, leftPos.y);
    }
}
