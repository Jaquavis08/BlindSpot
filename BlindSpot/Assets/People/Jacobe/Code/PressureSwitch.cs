using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using System;

public class PressureSwitch : MonoBehaviour
{
    [SerializeField] public GameObject currentDoor;
    public Animator anim;
    public bool keepOpen;
    public UnityEvent OnOpen;
    public UnityEvent OnClose;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet") && keepOpen)
        {
            print("Trigger Entered");
            currentDoor.GetComponent<Door>().AddPressureSwitch(this);
            anim.SetBool("Open", true);
            OnOpen.Invoke();
        }
        else if (other.CompareTag("Box"))
        {
            print("Trigger Entered");
            currentDoor.GetComponent<Door>().AddPressureSwitch(this);
            anim.SetBool("Open", true);
            OnOpen.Invoke();
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {

        if (keepOpen)
        {
            StartCoroutine(Delay());
        }
        else
        {
            print("Trigger Exited");
            currentDoor.GetComponent<Door>().RemovePressureSwitch(this);
            anim.SetBool("Open", false);
            OnClose.Invoke();
        }
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(5f);
        print("Trigger Exited");
        currentDoor.GetComponent<Door>().RemovePressureSwitch(this);
        anim.SetBool("Open", false);
        OnClose.Invoke();
    }
}