using UnityEngine;

public class DoorOpenController : MonoBehaviour
{
    public float openAngle = -90f;
    public float openSpeed = 2f;

    private Quaternion closedRotation;
    private Quaternion openedRotation;
    private bool isLookingAt = false;

    void Start()
    {
        closedRotation = transform.rotation;
        openedRotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0, openAngle, 0));
    }

    void Update()
    {
        if (isLookingAt)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, openedRotation, Time.deltaTime * openSpeed);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, closedRotation, Time.deltaTime * openSpeed);
        }
    }

    void OnMouseEnter()
    {
        isLookingAt = true;
    }

    void OnMouseExit()
    {
        isLookingAt = false;
    }
}