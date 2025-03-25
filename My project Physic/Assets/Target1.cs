using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Target1 : MonoBehaviour
{
    public int health = 1; // พลังชีวิตของเป้า

    void OnCollisionEnter(Collision collision)
    {
        // เช็คว่าชนกับกระสุนหรือไม่ โดยใช้ tag
        if (collision.gameObject/*.CompareTag("BulletPrefab(Clone)")*/)
        {
            Destroy(gameObject);
            WinCondition.Scores += 1;
            Debug.Log($"Score {WinCondition.Scores}");
        }
    }

    /*void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log(gameObject.name + " โดนยิง! เหลือพลังชีวิต: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(gameObject.name + " ถูกทำลาย!");
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
