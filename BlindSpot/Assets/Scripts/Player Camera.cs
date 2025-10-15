using UnityEngine;
using System.Collections;
using System;

public class PlayerCamera : MonoBehaviour
{
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;
    GameObject Player;
    bool followPlayer = true;

    public Transform camTransform;
    //--------------------------------------------------------------------
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Playera");
        if (camTransform == null)
        {
            camTransform = Camera.main.transform;
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (followPlayer == true)
        {
            camFollowPlayer();
        }    
    }

    public void setFollowPlayer(bool val)
    {
        followPlayer = val;
    }

    public void camFollowPlayer()
    {
        
        Vector3 newPos = new Vector3(Player.transform.position.x, Player.transform.position.y, this.transform.position.z);
        this.transform.position = newPos;
    }
}
