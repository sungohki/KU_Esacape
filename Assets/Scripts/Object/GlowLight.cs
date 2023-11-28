using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowLight : MonoBehaviour
{
    public Color lightColor = Color.green; // 전등의 색상
    public float lightRange = 10f; // 전등의 범위
    public float lightIntensity = 1f; // 전등의 강도

    void Start()
    {
        // 녹색 라이트 생성
        Light emergencyLight = gameObject.AddComponent<Light>();
        emergencyLight.color = lightColor;
        emergencyLight.range = lightRange;
        emergencyLight.intensity = lightIntensity;
    }
}
