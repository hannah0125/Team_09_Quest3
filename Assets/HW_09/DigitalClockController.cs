using TMPro;
using UnityEngine;

public class DigitalClockController : MonoBehaviour
{
    public Transform player;         
    public TextMeshProUGUI clockText;
    public float moveThreshold = 0.001f;

    private Vector3 lastPosition;
    private float timer = 0f;

    void Start()
    {
        if (player != null)
        {
            lastPosition = player.position;
        }

        UpdateClockDisplay();
    }

    void Update()
    {
        if (player == null || clockText == null) return;

        float distance = Vector3.Distance(player.position, lastPosition);

        if (distance > moveThreshold)
        {
            timer += Time.deltaTime;
            UpdateClockDisplay();
        }

        lastPosition = player.position;
    }

    void UpdateClockDisplay()
    {
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        clockText.text = $"{minutes:00}:{seconds:00}";
    }
}