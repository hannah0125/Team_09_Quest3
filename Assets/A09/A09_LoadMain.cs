using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A09_LoadMain : MonoBehaviour
{
    public string SceneName;

    private void OnMouseDown()
    {
        if (!string.IsNullOrEmpty(SceneName))
        {
            SceneManager.LoadScene(SceneName);
        }
        else
        {
            Debug.LogWarning("이동할 씬의 이름이 설정되지 않았음");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "OVRPlayerController" || other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}