using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_09_ButtonAnimation : MonoBehaviour
{
    public HW_09_BallLauncher targetLauncher; 

    // 이 함수를 애니메이션 이벤트(Function)로 선택하세요.
    public void OnAnimationFinished()
    {
        Debug.Log("1단계: 애니메이션 이벤트가 정상적으로 실행됨!");
        if (targetLauncher != null)
        {
            targetLauncher.Fire();
            Debug.Log("애니메이션 종료: 발사 명령을 전달했습니다.");
        }
        else
        {
            Debug.LogError("에러: Target Launcher가 연결되지 않았습니다!");
        }
    }
}
