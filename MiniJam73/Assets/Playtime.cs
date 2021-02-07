using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playtime : MonoBehaviour
{
    public static float playtime = 0;
    public static bool running = false;
    [SerializeField] bool resetOnAwake;

    private void Start()
    {
        if (resetOnAwake)
        {
            playtime = 0;
            running = true;
        }
    }

    static private void Update()
    {
        if (running)
        {
            playtime += Time.deltaTime;
        }
    }
}
