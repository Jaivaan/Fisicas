using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
public GameObject bulletPrefab;
public float bulletForce = 10f;

void Update()
{
    if (Input.GetKeyDown(KeyCode.R))
    {
        ShootBullet();
    }
}

void ShootBullet()
{
    GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
    Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
    bulletRb.AddForce(transform.forward * bulletForce, ForceMode.Impulse);
}

}
