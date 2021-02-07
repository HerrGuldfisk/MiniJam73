using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playtime : MonoBehaviour
{
    public static float playtime = 0;
    public static bool running = false;

    private void Start()
    {
        playtime = 0;
        running = true;
    }

    private void Update()
    {
        if (running)
        {
            playtime += Time.deltaTime;
            Debug.Log(playtime);
        }
    }
}
