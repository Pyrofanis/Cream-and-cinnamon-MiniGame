using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawning : MonoBehaviour
{
    [SerializeField]
    [Range(0, 2)]
    private float shootTimer;
    [SerializeField]
    [Header("Bullter Prefab")]
    private GameObject bullPrefab;
    [Range(0, 10)]
    [SerializeField]
    private float range;
    [SerializeField]
    [Range(0, 5)]
    public float bulletSpeed;
    private GameObject gun;


    public GameObject bulleting;

    [SerializeField]
    private List<GameObject> bullets;

    // Start is called before the first frame update
    void Start()
    {
        gun = GetComponent<ShootingDirection>().gunObj;

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

        if (shootTimer >= 1.5f && ShootingDirection.gunDirection!=Vector3.zero)
        {
            GameObject bullet = null;

            //Instantiate and add bullet to list
            if (DisabledBullet() == null)
            {
                bullet = Instantiate(bullPrefab, gun.transform.position, gun.transform.rotation);
                bullet.name = "bullet " + bullets.Count;
                bullets.Add(bullet);
            }
            else
            {
                //find already instantiated bullet   
                bullet = DisabledBullet();
                //reset position
                bullet.transform.position = gun.transform.position;
                //Set Active
                bullet.SetActive(true);
            }


            //modify bulletscript variables
            BulletScript bullScrip = bullet.GetComponent<BulletScript>();
            ModifyBulletscript(bullScrip);
            //reset timer
            shootTimer = 0;
        }
    }

    private void ModifyBulletscript(BulletScript bullScrip)
    {

        bullScrip.rotationOfBull = transform.rotation;
        bullScrip.range = range;
        bullScrip.currentGunDirection = ShootingDirection.gunDirection;
        bullScrip.bulletSpeed = bulletSpeed;
        bullScrip.CalculateTargetLoc();          
    }
    private GameObject DisabledBullet()
    {
        foreach (GameObject bullet in bullets)
        {
            if (!bullet.activeSelf)
            {
                return bullet;
            }
            else return null;
        }
        return null;
    }
}
