using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject gear;
    public float timer = 20;

    private void Update()
    {
        if(gear.activeSelf == false)
        {
            timer -= Time.deltaTime;
        }

        if(timer <= 0)
        {
            gear.SetActive(true);
            timer = 20;
        }
    }
}
