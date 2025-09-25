using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    #region Dependencies
    [SerializeField] SlidingDoor sd;
    #endregion

    #region Collision Functions
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            sd.OpenDoor();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            sd.CloseDoor();
        }
    }
    #endregion
}
