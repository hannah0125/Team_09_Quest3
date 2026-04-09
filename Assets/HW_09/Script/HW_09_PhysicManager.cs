using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCycleManager : MonoBehaviour
{
    private bool isGlitched = false;

    public Renderer buttonRenderer;
    public Color normalColor = Color.white;
    public Color glitchColor = new Color(1f, 0.4f, 0.4f);
    public float glitchFogDensity = 0.01f; // 안개 농도 (0.15에서 0.05로 대폭 낮춤)
    public Color fogColor = new Color(0.8f, 0.2f, 0.2f, 0.5f); // 약간 투명한 느낌의 빨강

    void Start()
    {
        // 시작할 때는 안개를 끄거나 아주 흐리게 설정
        RenderSettings.fog = false;
        RenderSettings.fogMode = FogMode.ExponentialSquared;
    }

    // 이 함수가 호출될 때마다 물리 법칙이 바뀝니다.
    public void CyclePhysics()
    {
        isGlitched = !isGlitched;

        if (isGlitched)
        {
            // [비정상 상태] 연산 주기를 늘려 물리 법칙을 무너뜨림
            Time.fixedDeltaTime = 0.05f;
            Debug.Log("<color=red>물리 법칙 붕괴: 연산 주기 0.2s</color>");
            RenderSettings.fog = true;
            RenderSettings.fogColor = fogColor;
            RenderSettings.fogDensity = glitchFogDensity;
        }
        else
        {
            // [정상 상태] 유니티 기본값으로 복구
            Time.fixedDeltaTime = 0.02f;
            Debug.Log("<color=green>물리 법칙 복구: 연산 주기 0.02s</color>");
            RenderSettings.fog = false;
        }
    }
}