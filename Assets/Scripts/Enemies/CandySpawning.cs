using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    [HideInInspector]
    public  List<GameObject> activeCandies;
    [HideInInspector]
    public  List<GameObject> disabledCandies;

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
        Sprite sprite = GetSprite();
        candy.GetComponentsInChildren<SpriteRenderer>()[1].sprite = GetSprite();
        //name Candy
        candy.name = "Candy" + " Coords:" + loc + " Sprite" + sprite.name;
        //add it to the list
        disabledCandies.Add(candy);
        candy.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    //update function to respawn candies in certain time
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

    //prevents reusing an non existent object
    private void CandyManager()
    {

        //if  Found disabled
        if (SelectDisabled() != null)
        {
            Reuse();
        }
    }

    //reusing function
    private void Reuse()
    {
        GameObject candy = SelectDisabled();
        //sets candy to the disabled object
        candy = SelectDisabled();
        //changes its sprite
        candy.GetComponentsInChildren<SpriteRenderer>()[1].sprite = GetSprite();
        //reactivates its collider
        candy.GetComponentInChildren<BoxCollider2D>().enabled = true;
        //adds It To Active List need to be Re added to disabled list On Hit
        activeCandies.Add(candy);
        disabledCandies.Remove(candy);
        //and sets it active
        candy.SetActive(true);

    }
    //selects randomly disabled Object
    private GameObject SelectDisabled()
    {
        if (disabledCandies.Count > 0)
        {
            int index = Random.Range(0, disabledCandies.Count);
            GameObject candy = disabledCandies[index];
            return candy;
        }
        return null;
    }

}

