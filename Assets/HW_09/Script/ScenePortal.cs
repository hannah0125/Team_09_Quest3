using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePortal : MonoBehaviour
{
    public string targetSceneName = "HW_09_Zone0";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
}