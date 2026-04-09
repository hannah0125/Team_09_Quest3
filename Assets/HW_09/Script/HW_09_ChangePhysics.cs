using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggerBridge : MonoBehaviour
{
    [Header("연결할 장치")]
    // 물리 법칙을 바꾸는 스크립트(PhysicsCycleManager)를 여기에 연결합니다.
    public PhysicsCycleManager physicsManager;

    // 애니메이션 타임라인의 이벤트 마커에서 호출할 함수 이름입니다.
    public void OnAnimationFinished1()
    {
        if (physicsManager != null)
        {
            // 물리 매니저에게 "법칙을 순환시켜라!"라고 명령합니다.
            physicsManager.CyclePhysics();

            Debug.Log("다리(Bridge): 애니메이션 신호를 받아 물리 매니저에게 전달했습니다.");
        }
        else
        {
            Debug.LogError("다리(Bridge): 연결된 PhysicsManager가 없습니다! 인스펙터에서 확인하세요.");
        }
    }
}