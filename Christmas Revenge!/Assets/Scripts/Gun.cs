using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 30;

    public float timeForShoot;
    public float newTimeForShoot;
    public bool canShoot;

    private void Start()
    {
        canShoot = true;
        newTimeForShoot = timeForShoot;
    }

    void Update()
   {
        if (canShoot)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
                canShoot = false;
                
            }
        }

        if (!canShoot)
        {
            timeForShoot -= Time.deltaTime;
        }

        if (timeForShoot < 0)
        {
            canShoot = true;
            timeForShoot = newTimeForShoot;
            
        }
     
   }
}
