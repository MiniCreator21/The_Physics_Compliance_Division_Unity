using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] SlidingDoor SlidingDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SlidingDoor.OpenDoor();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SlidingDoor.CloseDoor();
        }
    }

}
