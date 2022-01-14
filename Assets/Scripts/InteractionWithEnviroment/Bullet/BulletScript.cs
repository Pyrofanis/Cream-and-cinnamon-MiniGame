using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [HideInInspector]
    public float range;
    [HideInInspector]
    public Quaternion rotationOfBull;

    [HideInInspector]
    public float bulletSpeed;
    [HideInInspector]
    public Vector3 currentGunDirection;

    public LayerMask layerToDestoy;

    private Vector3 targetLoc;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, targetLoc, bulletSpeed * Time.deltaTime);

    }
    public void CalculateTargetLoc()
    {
        //round to int
        Vector3Int currentDirectionCelled = Vector3Int.CeilToInt(currentGunDirection);
        int rangeInted = Mathf.CeilToInt(range);
        //calculates location
        targetLoc = currentGunDirection * range + transform.position;
    }
    //interactions with gameObject and disables bullet
    private void OnTriggerEnter2D(Collider2D other)
    {

        CandyInteractionWthBullet(other.gameObject);
        this.gameObject.SetActive(false);
    }
    private void CandyInteractionWthBullet(GameObject candy)
    {

        if (candy.GetComponent<CandyInteractions>() != null)
        {
            candy.GetComponent<CandyInteractions>().InteractionsWithBullet();
        }

    }
}
