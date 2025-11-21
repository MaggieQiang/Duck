using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Audio.Instance.ShootSound();
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}