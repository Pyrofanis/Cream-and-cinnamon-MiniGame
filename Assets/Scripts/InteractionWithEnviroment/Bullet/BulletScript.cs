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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(transform.gameObject);
    }
}
