using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawning : MonoBehaviour
{
    private float shootTimer;
    [SerializeField]
    [Header("Bullter Prefab")]
    private GameObject bullPrefab;
    [Range(0,10)]
    [SerializeField]
    private float range;

    private GameObject gun;

    // Start is called before the first frame update
    void Start()
    {
        gun=GetComponent<ShootingDirection>().gunObj;

        if (PlayerGeneralControlls.controllScheme.Equals(PlayerGeneralControlls.ControllType.fighter))
        {
            PlayerGeneralControlls.inputActions.MovementSchemeFighting.Shoot.performed += _ => Shoot();
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
            GameObject bullet = Instantiate(bullPrefab, gun.transform.position, gun.transform.rotation);
            BulletScript bullScrip=bullet.GetComponent<BulletScript>();
            bullScrip.rotationOfBull=transform.rotation;
            bullScrip.range=range;
            bullScrip.currentGunDirection=ShootingDirection.gunDirection;
            shootTimer = 0;
        }
    }
}
