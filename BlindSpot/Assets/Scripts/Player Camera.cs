using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    GameObject Player;
    bool followPlayer = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Playera");
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

    void camFollowPlayer()
    {
        Vector3 newPos = new Vector3(Player.transform.position.x, Player.transform.position.y, this.transform.position.z);
        this.transform.position = newPos;
    }
}
