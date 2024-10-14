using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float time;
    private TMP_Text guiTime;

    void Start()
    {
        guiTime = GetComponent<TMP_Text>();
    }

    void Update()
    {
        time += Time.deltaTime;
        guiTime.text = "Time: " + time.ToString();
    }
}
