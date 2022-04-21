using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayMg : MonoBehaviour
{
    public float currentTime = 40;
    public float multiply = 2;
    
    public Material Sun;
    public Material moon;

    public GameObject dirLight;
    
    private void Update()
    {
        currentTime = currentTime + multiply;
        Mathf.Clamp(currentTime, 1f, 360f);
        if (currentTime >= 360f) currentTime = 1;
        if (currentTime >= 1)
        {
            RenderSettings.skybox = Sun;
            dirLight.SetActive(true);
        }
        if (currentTime >= 180)
        {
            RenderSettings.skybox = moon;
            dirLight.SetActive(false);
        }
        dirLight.transform.rotation = Quaternion.Euler(currentTime, 0, 0);
    }
}
