using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawning : MonoBehaviour
{

    [Header("CandyPrefab")]
    [Tooltip("basecly a target enter you prefeared gameObject here")]
    [SerializeField]
    private GameObject candyPrefab;

    [Header("Points that candies will spawn from")]
    [Header("ListOfPoints")]
    [SerializeField]
    private Transform[] spawnPoints;

    [SerializeField]
    [Header("Candy Variants")]
    [Min(1)]
    private Sprite[] candySprites;

    [SerializeField]
    private List<GameObject> activeCandies;

    private float timer;

    [Header("Spawn Timer")]
    [Range(2, 6)]
    [SerializeField]
    private float spawnTime;

    public GameObject debugObj;
    public GameObject debuggerObj;
    // Start is called before the first frame update
    void Start()
    {
        initialization();
    }
    //initialize spawnPointsWith candies
    private void initialization()
    {
        foreach (Transform loc in spawnPoints)
        {
            CreateCandy(loc);
        }
    }
    //general purpose function
    private Sprite GetSprite()
    {
        int index = Random.Range(0, candySprites.Length);
        return candySprites[index];

    }
    //general purpose function
    private Transform GetLocation(List<Transform> spawnPoints)
    {
        int index = Random.Range(0, spawnPoints.Count);
        return spawnPoints[index].transform;
    }

    //create initial Candies
    private void CreateCandy(Transform loc)
    {

        //instantiate new candy
        GameObject candy = Instantiate(candyPrefab, loc.position, Quaternion.identity, transform);
        //change its sprite
       Sprite sprite=GetSprite();
        candy.GetComponentsInChildren<SpriteRenderer>()[1].sprite = GetSprite();
        //name Candy
        candy.name="Candy"+" Coords:"+loc+" Sprite"+sprite.name;
        //add it to the list
        activeCandies.Add(candy);
        candy.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        Spawn();
        if (FindDisabled() != null)
        {
            debuggerObj = FindDisabled();
        }
    }
    private void Spawn()
    {
        timer += Time.deltaTime;
        //if timer meets criteria and there are evenable spaces
        if (timer >= spawnTime)
        {
            CandyManager();
            timer = 0;
        }
    }

    private void CandyManager()
    {

        //if  Found disabled
        if (FindDisabled() != null)
        {
            Reuse();
        }
    }
    private void Reuse()
    {
        GameObject candy = FindDisabled();
        //sets candy to the disabled object
        candy = FindDisabled();
        //changes its sprite
        candy.GetComponentsInChildren<SpriteRenderer>()[1].sprite = GetSprite();
        //reactivates its collider
        candy.GetComponentInChildren<BoxCollider2D>().enabled = true;
        //and sets it active
        candy.SetActive(true);

    }
    private GameObject FindDisabled()
    {
        foreach (GameObject candy in activeCandies)
        {
            Debug.Log(candy.name);
            if (!candy.activeInHierarchy)
            {
                debuggerObj = candy;
                return candy;
            }
            else return null;
        }

        return null;

    }
}

