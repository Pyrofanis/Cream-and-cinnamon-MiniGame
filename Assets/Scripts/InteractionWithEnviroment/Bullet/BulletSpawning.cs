using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawning : ShootingDirection
{
    private float shootTimer;
    [SerializeField]
    [Header("Bullter Prefab")]
    private GameObject bullPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if (controllScheme.Equals(ControllType.fighter))
        {
            inputActions.MovementSchemeFighting.Shoot.performed += _ => Shoot();
        }
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;
    }
    private void Shoot()
    {
        if (shootTimer >= 1.5f)
        {
            //Instantiate
            GameObject bullet = Instantiate(bullPrefab, gunObj.transform.position, gunObj.transform.rotation);

            //
            shootTimer = 0;
        }
    }
}
