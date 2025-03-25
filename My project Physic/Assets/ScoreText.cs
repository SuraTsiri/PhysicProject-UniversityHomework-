using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public Text scoreText; // ลาก Text UI เข้ามาใน Inspector

    void Update()
    {
        // สมมุติว่าใช้แบบ static score
        scoreText.text = "Score: " + WinCondition.Scores;
    }
}
