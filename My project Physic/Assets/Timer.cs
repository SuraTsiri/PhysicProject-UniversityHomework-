using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitAndFinish());
    }

    IEnumerator WaitAndFinish()
    {
        yield return new WaitForSeconds(60f); // 60 วินาที = 1 นาที
        Debug.Log($"Time out! Your score is {WinCondition.Scores}!");
        
        
            GameObject target = GameObject.Find("Jet_0320091937_texture");

            if (target != null)
            {
                Destroy(target);
                Debug.Log("Jet_0320091937_texture ถูกทำลายแล้ว");
            }
            else
            {
                Debug.LogWarning("ไม่พบ Jet_0320091937_texture ในฉาก");
            }
        

    }
}
