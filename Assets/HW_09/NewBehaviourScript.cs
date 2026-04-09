using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCycleManager : MonoBehaviour
{
    private bool isGlitched = false;

    // 이 함수가 호출될 때마다 물리 법칙이 바뀝니다.
    public void CyclePhysics()
    {
        isGlitched = !isGlitched;

        if (isGlitched)
        {
            // [비정상 상태] 연산 주기를 늘려 물리 법칙을 무너뜨림
            Time.fixedDeltaTime = 0.05f;
            Debug.Log("<color=red>물리 법칙 붕괴: 연산 주기 0.2s</color>");

            // 시각적 피드백 (선택사항: 버튼 색상을 빨갛게 변경 등)
            ChangeButtonColor(Color.red);
        }
        else
        {
            // [정상 상태] 유니티 기본값으로 복구
            Time.fixedDeltaTime = 0.02f;
            Debug.Log("<color=green>물리 법칙 복구: 연산 주기 0.02s</color>");

            ChangeButtonColor(Color.white);
        }
    }

    private void ChangeButtonColor(Color color)
    {
        // 버튼의 색상을 바꿔서 현재 상태를 유저에게 알려주면 더 좋습니다.
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null) renderer.material.color = color;
    }
}