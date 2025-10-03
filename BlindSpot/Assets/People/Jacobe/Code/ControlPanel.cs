using UnityEngine;
using UnityEngine.Events;

public class ControlPanel : MonoBehaviour
{
    [SerializeField] public GameObject currentDoor;
    public Animator anim;

    public UnityEvent OnOpen;
    public UnityEvent OnClose;

    public void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");
        currentDoor.GetComponent<Door>().AddControlPanel(this);
        anim.SetBool("Open", true);
        OnOpen.Invoke();
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        print("Trigger Exited");
        currentDoor.GetComponent<Door>().RemoveControlPanel(this);
        anim.SetBool("Open", false);
        OnClose.Invoke();
    }

}
