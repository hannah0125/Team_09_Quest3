using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HW_09_LoadScene : MonoBehaviour
{
    public string SceneName;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "OVRPlayerController" || other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneName);
        }
    }

}
