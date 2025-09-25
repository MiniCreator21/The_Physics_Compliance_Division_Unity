using UnityEngine;
using UnityEngine.Animations;

public class SlidingDoor : MonoBehaviour
{
    #region Public Fields
    public Transform leftDoor;
    public Transform rightDoor;
    public float slideDistance = 0.5f;
    public float speed = 4f;
    public Transform axisSource;
    #endregion
    #region Private Variables
    Vector3 leftClosed, rightClosed;
    Vector3 leftOpen, rightOpen;
    bool isOpen;
    float t;
    #endregion

    #region Awake
    void Awake()
    {
        if (axisSource == null) axisSource = transform;
    }
    #endregion

    #region Start
    void Start()
    {
        leftClosed = leftDoor.position;
        rightClosed = rightDoor.position;

        Vector3 dir = axisSource.forward;

        leftOpen = leftClosed - dir * slideDistance;
        rightOpen = rightClosed + dir * slideDistance;
    }
    #endregion

    #region Update
    void Update()
    {
        float target = isOpen ? 1f : 0f;

        t = Mathf.Lerp(t, target, Time.deltaTime * speed);

        leftDoor.position = Vector3.Lerp(leftClosed, leftOpen, t);
        rightDoor.position = Vector3.Lerp(rightClosed, rightOpen, t);
    }
    #endregion

    #region Public Functions
    public void ToggleDoor() => isOpen = !isOpen;
    public void OpenDoor() => isOpen = true;
    public void CloseDoor() => isOpen = false;
    #endregion
}
