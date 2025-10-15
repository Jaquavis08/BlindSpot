using UnityEngine;
using System.Collections;
using System;

public class PlayerCamera : MonoBehaviour
{
    public static PlayerCamera instance;
    public float crazy;
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;
    GameObject Player;
    bool followPlayer = true;
    Vector3 originalPos;
    public bool shake = false;

    public Transform camTransform;
    //--------------------------------------------------------------------
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Playera");
        //if (camTransform == null)
        //{
        //    camTransform = Camera.main.transform;
        //}
        //originalPos = camTransform.localPosition;
    }
    private void Awake()
    {
        instance = this;
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
        StopCoroutine(SetCameraBack());
        StartCoroutine(SetCameraBack());
        
        Vector3 newPos = new Vector3(Player.transform.position.x, Player.transform.position.y, this.transform.position.z);
        this.transform.position = newPos;
    }

    private IEnumerator SetCameraBack()
    {
        if(shake)
        {
            crazy = UnityEngine.Random.Range(1f, 2f);
            camTransform.localPosition = new Vector2(originalPos.x + crazy * shakeAmount, originalPos.y + crazy * shakeAmount);
            yield return new WaitForSeconds(1);
            camTransform.localPosition = originalPos;
        }
        
    }
}
