using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour
{
    void Update()
    {
        GameObject bullet = GameObject.Find("BulletPrefab(Clone)");

        if (bullet != null && bullet.GetComponent<DestroyAfterTime>() == null)
        {
            bullet.AddComponent<DestroyAfterTime>().lifetime = 0.6f;
        }
    }
}

public class DestroyAfterTime : MonoBehaviour
{
    public float lifetime = 0.6f;

    void Awake()
    {
        Destroy(gameObject, lifetime);
    }
}
