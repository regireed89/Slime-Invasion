using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float fireRate = 1;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }


    public IEnumerator Shoot()
    {
        while (true)
        {
            if (Input.GetButton("Fire1"))
            {
                GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.AddForce(firePoint.forward * bulletSpeed, ForceMode.Impulse);
                Destroy(bullet, 3);
            }
            yield return new WaitForSeconds(fireRate);

        }

    }
}
