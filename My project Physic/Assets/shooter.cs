using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    /*public Transform firePoint;

    void Update()
    {
        Shooting();
    }
    void Shooting()
    {
        Debug.DrawRay(firePoint.position, transform.forward * 30f, Color.yellow);
        RaycastHit hit;

        if (Physics.Raycast(firePoint.position, transform.forward, out hit, 30f))
        {
            Debug.DrawRay(firePoint.position, transform.forward * 30f, Color.green);
            print(hit.collider.name);
        }
    }
    */
    //---------------------------------------------------------------------------------------------------------------------------------------------------
    public GameObject bulletPrefab; // Prefab ของ Bullet
    public Transform firePoint; // จุดยิง (กำหนดเป็นลูกของ Player ตำแหน่งที่ต้องการให้ยิง)
    public float bulletSpeed = 1f; // ความเร็วของกระสุน

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // เช็คว่ากดคลิกซ้ายหรือไม่
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = firePoint.forward * bulletSpeed; // ยิงไปตามทิศที่ Player หันหน้าอยู่
                //Destroy(gameObject.BulletPrefab);
            }
        }
        else
        {
            Debug.LogWarning("BulletPrefab หรือ FirePoint ไม่ได้ถูกตั้งค่า!");
        }
    }
}
