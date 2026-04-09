using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_09_BallLauncher : MonoBehaviour
{
    public GameObject ballPrefab1; // 아까 만든 공 프리팹
    public GameObject ballPrefab2;
    public Transform firePoint1;
    public Transform firePoint2;// 공이 나올 위치
    public float launchSpeed1= 50f; // 공의 속도 (슬라이더로 조절 가능하게 설정)
    public float launchSpeed2 = 3f; // 공의 속도 (슬라이더로 조절 가능하게 설정)


    public void Fire()
    {
        // 1. 공 생성
        GameObject ball1 = Instantiate(ballPrefab1, firePoint1.position, firePoint1.rotation);
        GameObject ball2 = Instantiate(ballPrefab2, firePoint2.position, firePoint2.rotation);

        // 2. 물리 엔진(Rigidbody) 가져오기
        Rigidbody rb1 = ball1.GetComponent<Rigidbody>();
        Rigidbody rb2 = ball2.GetComponent<Rigidbody>();

        // 3. 앞방향으로 속도 부여
        // [탐구 포인트] 속도가 빠를수록 연산 주기 사이의 '빈틈'이 커집니다.

        Debug.Log($"공 발사! 속도: {launchSpeed1} 방향: {firePoint1.forward}");
        Debug.Log($"공 발사! 속도: {launchSpeed2} 방향: {firePoint2.forward}");
        rb1.velocity = Vector3.zero;
        rb2.velocity = Vector3.zero;
        rb1.angularVelocity = Vector3.zero;
        rb2.angularVelocity = Vector3.zero;
        rb1.velocity = firePoint1.forward * launchSpeed1;
        rb2.velocity = firePoint2.forward * launchSpeed2;

        // 4. 성능을 위해 5초 뒤 삭제
        Destroy(ball1, 1.5f);
        Destroy(ball2, 1.5f);
    }

    // UI 슬라이더와 연결할 함수
    public void UpdateSpeed(float newSpeed)
    {
        launchSpeed1 = newSpeed;
        launchSpeed2 = newSpeed;
    }
}