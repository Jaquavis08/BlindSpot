using Unity.VisualScripting;
using UnityEngine;

public class ElevatorYouGoByBy : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Playera"))
        {
            //go to next level
        }
    }
}
