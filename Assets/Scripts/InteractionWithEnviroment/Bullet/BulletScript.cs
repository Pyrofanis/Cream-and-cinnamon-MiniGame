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

    private Vector3 targetLoc;
    
    // Start is called before the first frame update
    void Start()
    {
    Vector3Int currentDirectionCelled=Vector3Int.CeilToInt(currentGunDirection);
    int rangeInted=Mathf.CeilToInt(range);


    targetLoc=currentGunDirection*range +transform.position;

    }

    // Update is called once per frame
    void Update()
    {

   transform.position= Vector3.MoveTowards(transform.position,targetLoc,bulletSpeed*Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(transform.gameObject);
    }
}
