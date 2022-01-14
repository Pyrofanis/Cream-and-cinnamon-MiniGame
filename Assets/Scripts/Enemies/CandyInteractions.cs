using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyInteractions : MonoBehaviour
{
    private CandySpawning candySpawning;
    private void Awake()
    {
        candySpawning = GameObject.FindObjectOfType<CandySpawning>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void InteractionsWithBullet()
    {
        //manages lists
        candySpawning.activeCandies.Remove(this.gameObject);
        candySpawning.disabledCandies.Add(this.gameObject);
        //disables bullet
        //disables object
        gameObject.SetActive(false);
    }

}
